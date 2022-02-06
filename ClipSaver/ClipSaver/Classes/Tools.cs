using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipSaver
{
    class Tools
    {
        public static string DBase64(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static string EBase64(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes, Base64FormattingOptions.InsertLineBreaks);
        }



        //public string ENC(string text, string password)
        //{
        //    System.Security.Cryptography.RijndaelManaged AES = new System.Security.Cryptography.RijndaelManaged();
        //    System.Security.Cryptography.MD5CryptoServiceProvider Hash_AES = new System.Security.Cryptography.MD5CryptoServiceProvider();
        //    string encrypted = "";
        //    byte[] hash = new byte[32];
        //    byte[] temp = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password));
        //    Array.Copy(temp, 0, hash, 0, 16);
        //    Array.Copy(temp, 0, hash, 15, 16);
        //    AES.Key = hash;
        //    AES.Mode = System.Security.Cryptography.CipherMode.ECB;
        //    System.Security.Cryptography.ICryptoTransform DESEncrypter = AES.CreateEncryptor();
        //    byte[] Buffer = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
        //    encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length),Base64FormattingOptions.InsertLineBreaks);
        //    return encrypted;
        //}
        //public string DEC(string text, string password)
        //{
        //    System.Security.Cryptography.RijndaelManaged AES = new System.Security.Cryptography.RijndaelManaged();
        //    System.Security.Cryptography.MD5CryptoServiceProvider Hash_AES = new System.Security.Cryptography.MD5CryptoServiceProvider();
        //    string decrypted = "";
        //    byte[] hash = new byte[32];
        //    byte[] temp = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password));
        //    Array.Copy(temp, 0, hash, 0, 16);
        //    Array.Copy(temp, 0, hash, 15, 16);
        //    AES.Key = hash;
        //    AES.Mode = System.Security.Cryptography.CipherMode.ECB;
        //    System.Security.Cryptography.ICryptoTransform DESDecrypter = AES.CreateDecryptor();
        //    byte[] Buffer = Convert.FromBase64String(text);
        //    decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length));
        //    return decrypted;
        //}
    }
}
