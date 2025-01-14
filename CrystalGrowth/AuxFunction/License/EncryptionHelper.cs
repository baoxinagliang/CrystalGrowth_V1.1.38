using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CrystalGrowth.AuxFunction.License
{
    internal enum EncryptionKeyEnum
    {
        KeyA,
        KeyB
    }
    internal class EncryptionHelper
    {
        readonly string EncryptionKeyA = "ThankYou";
        readonly string EncryptionKeyB = "WorkHard";
        readonly string MD5Begin = "Linton";
        readonly string MD5End = "Kayex";
        string EncryptionKey = string.Empty;
        public EncryptionHelper()
        {
            InitKey();
        }
        public EncryptionHelper(EncryptionKeyEnum Key)
        {
            InitKey(Key);
        }
        private void InitKey(EncryptionKeyEnum Key = EncryptionKeyEnum.KeyA)
        {
            switch (Key)
            {
                case EncryptionKeyEnum.KeyA:
                    EncryptionKey = EncryptionKeyA;
                    return;
                case EncryptionKeyEnum.KeyB:
                    EncryptionKey = EncryptionKeyB;
                    return;
            }
        }
        public string EncryptString(string Str)
        {
            return Encrypt(Str, EncryptionKey);
        }
        public string DecryptString(string Str)
        {
            return Decrypt(Str, EncryptionKey);
        }
        public string GetMD5String(string str)
        {
            str = string.Concat(MD5Begin, str, MD5End);
            MD5 NewMD5 = new MD5CryptoServiceProvider();
            byte[] FromData = Encoding.Unicode.GetBytes(str);
            byte[] TargetData = NewMD5.ComputeHash(FromData);
            string MD5String = string.Empty;
            foreach (byte index in TargetData)
            {
                MD5String = string.Concat(MD5String, index.ToString("x2"));
            }
            return MD5String;
        }
        private string Encrypt(string Str, string StrKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            byte[] InputByteArray = Encoding.Default.GetBytes(Str);
            DES.Key = ASCIIEncoding.ASCII.GetBytes(StrKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(StrKey);
            MemoryStream MS = new MemoryStream();
            CryptoStream CS = new CryptoStream(MS, DES.CreateEncryptor(), CryptoStreamMode.Write);
            CS.Write(InputByteArray, 0, InputByteArray.Length);
            CS.FlushFinalBlock();
            MS.Flush();
            return Convert.ToBase64String(MS.GetBuffer(), 0, (int)MS.Length);
        }
        private string Decrypt(string PToDecrypt, string StrKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            byte[] InputByteArray = Convert.FromBase64String(PToDecrypt);
            DES.Key = ASCIIEncoding.ASCII.GetBytes(StrKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(StrKey);
            MemoryStream MS = new MemoryStream(InputByteArray);
            CryptoStream CS = new CryptoStream(MS, DES.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader SR = new StreamReader(CS);
            return SR.ReadToEnd();
        }
    }
}

