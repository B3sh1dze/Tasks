using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Extentions_
{
    public static class StringExtension
    {
        public static bool IsNumber(this string num)
        {
            bool isInt;
            int number;

            isInt = Int32.TryParse(num, out number);
            if(isInt)
            {
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }
        public static bool IsDate(this string str)
        {
            bool isDate;
            DateTime date;
            isDate = DateTime.TryParse(str, out date);
            if (isDate)
            {
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }
        public static string[] ToWords(this string str)
        {
            return str.Split(' ');
        }
        public static void CalculateHash(this string str)
        {
                //string input = "The quick brown fox jumps over the lazy dog";
                byte[] inputBytes = Encoding.UTF8.GetBytes(str);

                using (SHA256 hash = SHA256.Create())
                {
                    byte[] hashBytes = hash.ComputeHash(inputBytes);
                    string hashString = BitConverter.ToString(hashBytes).Replace("-", "");
                    Console.WriteLine(hashString);
                }  
        }
        //public static string Encrypt(string plainText, string key, string iv)
        //{
        //    byte[] encrypted;
        //    using (Aes aes = Aes.Create())
        //    {
        //        byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(key);

        //        // Resize the key if it is not a valid size
        //        if (!aes.ValidKeySize(keyBytes.Length * 8))
        //        {
        //            int newKeyLength = aes.KeySize / 8;
        //            Array.Resize(ref keyBytes, newKeyLength);
        //        }

        //        aes.Key = keyBytes;
        //        aes.IV = System.Text.Encoding.UTF8.GetBytes(iv);

        //        // Encrypt the plain text
        //        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        //        using (MemoryStream msEncrypt = new MemoryStream())
        //        {
        //            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
        //            {
        //                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
        //                {
        //                    swEncrypt.Write(plainText);
        //                }
        //                encrypted = msEncrypt.ToArray();
        //            }
        //        }
        //    }

        //    // Return the encrypted text as a base64 encoded string
        //    return Convert.ToBase64String(encrypted);
        //}
        //public static string Decrypt(string encryptedText, string key, string iv)
        //{
        //    byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
        //    string decrypted;
        //    using (Aes aes = Aes.Create())
        //    {
        //        byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(key);

        //        // Resize the key if it is not a valid size
        //        if (!aes.ValidKeySize(keyBytes.Length * 8))
        //        {
        //            int newKeyLength = aes.KeySize / 8;
        //            Array.Resize(ref keyBytes, newKeyLength);
        //            aes.Key = keyBytes;
        //        }
        //        else
        //        {
        //            aes.Key = keyBytes;
        //        }

        //        byte[] ivBytes = System.Text.Encoding.UTF8.GetBytes(iv);

        //        // Resize the IV if it is not a valid size
        //        if (!aes.ValidKeySize(ivBytes.Length * 8))
        //        {
        //            int newIvLength = aes.BlockSize / 8;
        //            Array.Resize(ref ivBytes, newIvLength);
        //        }
        //        else
        //        {
        //            aes.IV = ivBytes;
        //        }
        //        // Decrypt the encrypted text
        //        ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        //        using (MemoryStream msDecrypt = new MemoryStream(encryptedBytes))
        //        {
        //            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
        //            {
        //                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
        //                {
        //                    decrypted = srDecrypt.ReadToEnd();
        //                }
        //            }
        //        }

        //        return decrypted;
        //    }

        //}
    }
}
