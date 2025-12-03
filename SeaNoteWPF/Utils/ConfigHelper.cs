using Microsoft.Extensions.Configuration;
using System.IO;

namespace SeaNoteWPF.Utils
{
    public static class ConfigHelper
    {
        private static IConfiguration _configuration;

        static ConfigHelper()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _configuration = builder.Build();
        }

        public static string EmailUser => _configuration["EmailSettings:SenderEmail"];

        public static string EmailPass
        {
            get { return AesHelper.Decrypt(_configuration["EmailSettings:AppPassword"]); }
        }

        public static string GeminiApiKey
        {
            get { return _configuration["GeminiSettings:ApiKey"]; } 
        }
    }
}