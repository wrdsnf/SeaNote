using System;
namespace SeaNote.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; } = "";
        private string password = "";
        public string? Role { get; set; }
        public string? NamaLengkap { get; set; }
        public string? Email { get; set; }
        public string? NomorTelepon { get; set; }
        public void SetPassword(string pwd) => password = pwd;
        public bool Login(string username, string pwd)
        {
            return Username == username && password == pwd && Role != null;
        }
    }
}

