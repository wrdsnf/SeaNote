using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SeaNoteApp
{
    public static class AesHelper
    {
        // PENTING: jangan ubah lagi setelah dipakai encrypt!
        // Panjang harus 32 karakter (256-bit)
        private static readonly string EncryptionKey = "MieAyamSGLC16KIniPWyangBikinSTRE";
        private static readonly byte[] KeyBytes = Encoding.UTF8.GetBytes(EncryptionKey);

        // IV 16 karakter (128-bit)
        private static readonly byte[] IVBytes = Encoding.UTF8.GetBytes("SeaNoteInitVecto");

        public static string Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = KeyBytes;
                aesAlg.IV = IVBytes;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        public static string Decrypt(string cipherText)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = KeyBytes;
                aesAlg.IV = IVBytes;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
