using System;

namespace SeaNote.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = "";
        private string password = "";

        public string? Role { get; set; } = null;

        public string NamaLengkap { get; set; } = "";
        public string Email { get; set; } = "";
        public string NomorTelepon { get; set; } = "";

        public void SetPassword(string pwd) => password = pwd;

        public bool Login(string username, string pwd)
        {
            return Username == username && password == pwd && Role != null;
        }

        public void ChangePassword(string newPwd)
        {
            password = newPwd;
        }
    }
}
