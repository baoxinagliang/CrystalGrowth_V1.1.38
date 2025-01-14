using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace CrystalGrowth.Unities
{
    /// <summary>
    /// CCD参数持久化
    /// </summary>
    public class Parameter
    {
        public static bool IsAutoSerialize = true;


        #region  属性参数
        private float meltGapAbsMeasure_T = 443;
        [JsonProperty("CCD到设备中心距")]
        public float MeltGapAbsMeasure_T
        {
            get { return meltGapAbsMeasure_T; }
            set
            {
                meltGapAbsMeasure_T = value;
                if (IsAutoSerialize)
                {
                    OnPropertyChanged(this);
                }
            }
        }

        private float meltGapAbsMeasure_H = 1500;
        [JsonProperty("CCD到筒底垂直距离")]
        public float MeltGapAbsMeasure_H
        {
            get { return meltGapAbsMeasure_H; }
            set
            {
                meltGapAbsMeasure_H = value;
                if (IsAutoSerialize)
                {
                    OnPropertyChanged(this);
                }
            }
        }

        private float meltGapAbsMeasure_R = 153;
        [JsonProperty("导流筒下口半径")]
        public float MeltGapAbsMeasure_R
        {
            get { return meltGapAbsMeasure_R; }
            set
            {
                meltGapAbsMeasure_R = value;
                if (IsAutoSerialize)
                {
                    OnPropertyChanged(this);
                }
            }
        }

        private float meltGapAbsMeasure_OffSet = 12;
        [JsonProperty("绝对液距偏移量")]
        public float MeltGapAbsMeasure_OffSet
        {
            get { return meltGapAbsMeasure_OffSet; }
            set
            {
                meltGapAbsMeasure_OffSet = value;
                if (IsAutoSerialize)
                {
                    OnPropertyChanged(this);
                }
            }
        }

        private int meltGapAbsFilterNum = 15;
        [JsonProperty("绝对液距滤波长度")]
        public int MeltGapAbsFilterNum
        {
            get { return meltGapAbsFilterNum; }
            set
            {
                meltGapAbsFilterNum = value;
                if (IsAutoSerialize)
                {
                    OnPropertyChanged(this);
                }
            }
        }


        private int saveInterval = 4;
        [JsonProperty("存图间隔")]
        public int SaveInterval
        {
            get { return saveInterval; }
            set
            {
                saveInterval = value;
                if (IsAutoSerialize)
                {
                    OnPropertyChanged(this);
                }
            }
        }



        private string savePicPath = @"D:\LICCS_PIC";
        [JsonProperty("存图文件夹路径")]
        public string SavePicPath
        {
            get { return savePicPath; }
            set
            {
                savePicPath = value;
                if (IsAutoSerialize)
                {
                    OnPropertyChanged(this);
                }
            }
        }
        private int xLineLongGap = 5;
        [JsonProperty("X线长间隔")]
        public int XLineLongGap
        {
            get { return xLineLongGap; }
            set
            {
                xLineLongGap = value;
                if (IsAutoSerialize)
                {
                    OnPropertyChanged(this);
                }
            }
        }
        private int xLineShortGap = 4;
        [JsonProperty("X线短间隔")]
        public int XLineShortGap
        {
            get { return xLineShortGap; }
            set
            {
                xLineShortGap = value;
                if (IsAutoSerialize)
                {
                    OnPropertyChanged(this);
                }
            }
        }

        private int crossLineLongGap = 5;
        [JsonProperty("十字线长间隔")]
        public int CrossLineLongGap
        {
            get { return crossLineLongGap; }
            set
            {
                crossLineLongGap = value;
                if (IsAutoSerialize)
                {
                    OnPropertyChanged(this);
                }
            }
        }
        private int crossLineShortGap = 4;
        [JsonProperty("十字线短间隔")]
        public int CrossLineShortGap
        {
            get { return crossLineShortGap; }
            set
            {
                crossLineShortGap = value;
                if (IsAutoSerialize)
                {
                    OnPropertyChanged(this);
                }
            }
        }

        #endregion

        #region  方法

        protected void OnPropertyChanged(Parameter obj)
        {
            Serialize(FileHelper.ParameterPath, obj);
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="obj"></param>
        public static void Serialize(string FilePath, Parameter obj)
        {
            // 序列化参数对象到文件中，如果不存在会自动创建
            // Formatting.Indentedx写入时使用缩排格式
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Include


            }));
        }


        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool DeSerialize(string FilePath, ref Parameter obj)
        {

            // 文件不存在的话，默认创建一个，并且提示用户。
            if (!File.Exists(FilePath))
            {
                // 如果参数文件不存在
                Serialize(FilePath, obj);
                MessageBox.Show("参数文件缺失，已重新创建参数文件！");
            }

            try
            {
                // 反序列化参数到对象中
                obj = JsonConvert.DeserializeObject<Parameter>(File.ReadAllText(FilePath), new JsonSerializerSettings
                {
                    // 在反序列化时发现json文件里的数据在系统对象中不存在，就忽略它
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    // 如果反序列化的时候参数时空也要包括在内
                    NullValueHandling = NullValueHandling.Include
                });
                return true;
            }
            catch
            {
                MessageBox.Show("参数异常，请联系开发人员！");
                return false;

            }
        }


        #endregion
    }
}
