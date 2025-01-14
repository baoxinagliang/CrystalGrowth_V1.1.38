using CrystalGrowth.Unities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
	internal partial class FrmCrownTrack : Form
	{
		static int count = 0;
		static string State = "0.0";
		static List<Track> RealCrownT;
		readonly List<Track> trackList;
		readonly float halfW = 0;
		readonly Pen blackPen;
		readonly Font songFont;
		Graphics g;
		readonly bool flag = false;
		public FrmCrownTrack(bool flag1)
		{
			InitializeComponent();
			flag = flag1;
			trackList = new List<Track>();
			halfW = Width / 2;
			blackPen = new Pen(Color.Black, 1);
			songFont = new Font("宋体", 8, FontStyle.Regular);
		}
		private void FrmCrownTrack_Load(object sender, EventArgs e)
		{
			float[] fLen = Sop.SData.Crown.Skip(156).Take(16).ToArray();//146
			float[] fDia = Sop.SData.Crown.Skip(188).Take(16).ToArray();//178
			if (fLen.Length == 16 && fDia.Length == 16)
			{
				for (int i = 0; i < 16; i++)
				{
					Track TrackData = new Track
					{
						Len = fLen[i],
						Dia = fDia[i] / 2,
					};
					if (TrackData.Len > 1 && TrackData.Dia > 1)
					{
						trackList.Add(TrackData);
					}
				}
			}
		}
		private void FrmCrownTrack_DoubleClick(object sender, EventArgs e)
		{
			if (flag == false)
			{
				FrmSwitch.LastForm.Close();
				FrmCrown fcn = new FrmCrown();
				FrmSwitch.Open(fcn, 30, new Point(0, 200), new Size(520, 494));
				fcn.Show();
				FrmSwitch.LastForm = fcn;
			}
		}
		private void FrmCrownTrack_Paint(object sender, PaintEventArgs e)
		{
			g = e.Graphics;
			DarwXAxis();
			DarwYAxis();
			DarwTrack(trackList, Brushes.Black, -180, true);
			DarwTrack(RealCrownT, Brushes.Blue, 260, false);
		}
		private void DarwTrack(List<Track> trackData, Brush brush, int offset, bool flag)
		{
			if (trackData != null)
			{
				int i = 1;
				PointF lastL = new PointF(halfW, 14);
				PointF lastR = lastL;
				foreach (Track track in trackData)
				{
					PointF pointL = new PointF((float)(halfW - track.Dia * 1.333 - 1.5), (float)(track.Len * 1.333 - 1.5 + 15));
					PointF pointR = new PointF((float)(halfW + track.Dia * 1.333 - 1.5), (float)(track.Len * 1.333 - 1.5 + 15));
					PointF pointR1 = new PointF((float)(halfW + track.Dia * 1.333 - 1.5), (float)(track.Len * 1.333 - 1.5 + 15));
					PointF pointL1 = new PointF((float)(halfW - track.Dia * 1.333), (float)(track.Len * 1.333 + 15));
					PointF pointOff = new PointF((float)(halfW - offset), (float)(track.Len * 1.333 + 15));
					RectangleF rectL = new RectangleF(pointL, new Size(3, 3));
					RectangleF rectR = new RectangleF(pointR, new Size(3, 3));
					if (flag) { g.DrawString($"({track.Dia},{track.Len})", songFont, brush, pointOff); }
					g.FillEllipse(brush, rectL);
					g.FillEllipse(brush, rectR);
					g.DrawLine(new Pen(brush, 1), lastL, pointL1);
					g.DrawLine(new Pen(brush, 1), lastR, pointR1);
					lastL = pointL1;
					lastR = pointR1;
					i++;
				}
			}
		}
		private void DarwXAxis()
		{
			g.DrawLine(blackPen, new PointF(halfW, 14), new PointF(halfW, Height));
			for (int i = 0; i <= 12; i++)
			{
				g.DrawString((i * 15).ToString(), songFont, Brushes.Black, new PointF(halfW + i * 20 - 8, 2));
				g.DrawString((i * 15).ToString(), songFont, Brushes.Black, new PointF(halfW - i * 20 - 8, 2));
				g.DrawLine(blackPen, new PointF(halfW + 20 * i, 12), new PointF(halfW + 20 * i, 18));
				g.DrawLine(blackPen, new PointF(halfW - 20 * i, 12), new PointF(halfW - 20 * i, 18));
			}
		}
		private void DarwYAxis()
		{
			g.DrawLine(blackPen, new PointF(0, 14), new PointF(Width, 14));
			for (int i = 1; i <= 16; i++)
			{
				g.DrawString((i * 15).ToString(), songFont, Brushes.Black, new PointF(halfW - 25, 20 * i + 10));
				g.DrawLine(blackPen, new PointF(halfW - 3, 20 * i + 14), new PointF(halfW + 3, 20 * i + 14));
			}
		}
		private void FrmCrownTrack_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (g != null) { g.Dispose(); }
		}
		public static void RecordCrownTrack()
		{
			string realState = Math.Round(PLC.ReadValue[1], 1).ToString("f1");
			if (State != "11.0" && realState == "11.0")
			{
				RealCrownT = new List<Track>();
				State = "11.0";
			}
			else if (State == "11.0" && realState == "11.0")
			{
				if (count >= 60)
				{
					if (PLC.ReadValue[7] < 390 && PLC.ReadCalcValue[14] < 240)
					{
						Track track = new Track
						{
							Dia = PLC.ReadValue[7] / 2,
							Len = PLC.ReadCalcValue[14]
						};
						RealCrownT.Add(track);
					}
					count = 0;
				}
				else
				{
					count++;
				}
			}
			else if (State == "11.0" && realState != "11.0")
			{
				if (RealCrownT != null)
				{
					RealCrownT.Clear();
					RealCrownT = null;
				}
				State = "0.0";
			}
			else
			{
				return;
			}
		}
	}
	internal class Track
	{
		public float Len;
		public float Dia;
	}
}
