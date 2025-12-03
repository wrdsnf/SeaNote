using Npgsql;
using System;
using System.IO;
using System.Windows; 

namespace SeaNoteWPF.Utils
{
    public static class DbHelper
    {
        private const string SecretFileName = "db_secret.cfg";
        private static readonly string _connString = InitConnectionString();

        private static string InitConnectionString()
        {
            try
            {
                // Folder tempat EXE berada
                var baseDir = AppContext.BaseDirectory;
                var secretPath = Path.Combine(baseDir, SecretFileName);

                if (!File.Exists(secretPath))
                    throw new FileNotFoundException($"File '{SecretFileName}' tidak ditemukan di folder: {baseDir}");

                // Baca ciphertext
                var encrypted = File.ReadAllText(secretPath).Trim();
                if (string.IsNullOrWhiteSpace(encrypted))
                    throw new Exception("Isi db_secret.cfg kosong.");

                // DECRYPT → jadi connection string plain
                var decrypted = AesHelper.Decrypt(encrypted);

                // Sanity check: bisa dipakai bikin NpgsqlConnection?
                using (var testConn = new NpgsqlConnection(decrypted))
                {
                    // Gak perlu open, cuma cek format string doang valid apa nggak
                }

                return decrypted;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal inisialisasi connection string dari db_secret.cfg:\n\n" + ex.Message,
                    "DB Config Error",
                    MessageBoxButton.OK,    // WinForms: MessageBoxButtons.OK
                    MessageBoxImage.Error); // WinForms: MessageBoxIcon.Error

                throw;
            }
        }

        public static NpgsqlConnection GetConnection()
        {
            try
            {
                return new NpgsqlConnection(_connString);
            }
            catch (Exception ex)
            {
                throw new Exception("Format connection string salah. Cek db_secret.cfg / AesHelper.", ex);
            }
        }
    }
}