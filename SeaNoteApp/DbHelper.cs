using Npgsql;
using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SeaNoteApp
{
    public static class DbHelper
    {
        private static readonly IConfiguration _config = InitConfig();
        private static readonly string _connString = GetAndValidateConnectionString();

        private static IConfiguration InitConfig()
        {
            try
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                return builder.Build();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal baca appsettings.json. Pastiin file-nya ada dan 'Copy to Output Directory' = 'Copy if newer'.", ex);
            }
        }

        private static string GetAndValidateConnectionString()
        {
            string? connString = _config.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(connString))
            {
                throw new Exception("Connection string 'DefaultConnection' gak ditemuin di appsettings.json.");
            }
            return connString;
        }

        public static NpgsqlConnection GetConnection()
        {
            try
            {
                return new NpgsqlConnection(_connString);
            }
            catch (Exception ex)
            {
                throw new Exception("Format connection string salah. Cek appsettings.json.", ex);
            }
        }
    }
}