using System;

namespace SeaNote.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = "";
        private string password = "";
        public string Role { get; set; } = "";

        // set password (simpan private)
        public void SetPassword(string pwd) => password = pwd;

        public bool Login(string username, string pwd)
        {
            return Username == username && password == pwd;
        }

        public void ChangePassword(string newPwd)
        {
            password = newPwd;
        }
    }
}
