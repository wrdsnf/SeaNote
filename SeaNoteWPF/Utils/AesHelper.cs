using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SeaNoteWPF.Utils // <-- Sesuaikan sama folder project baru
{
    public static class AesHelper
    {
        // Key & IV (Jangan diubah lagi kalo udah ada data yang dienkripsi!)
        private static readonly string EncryptionKey = "MieAyamSGLC16KIniPWyangBikinSTRE"; // 32 chars
        private static readonly byte[] KeyBytes = Encoding.UTF8.GetBytes(EncryptionKey);
        private static readonly byte[] IVBytes = Encoding.UTF8.GetBytes("SeaNoteInitVecto"); // 16 chars

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
            try
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
            catch
            {
                return ""; // Balikin kosong kalo gagal decrypt (biar gak crash)
            }
        }
    }
}