using SeaNote.Models;
using System.Collections.Generic;

namespace SeaNoteApp
{
    public static class UserData
    {
        // database user dummy
        public static List<User> dummyUsers = new List<User>();

        public static void InitializeDummyUsers()
        {
            if (dummyUsers.Count == 0)
            {
                var admin = new User
                {
                    UserID = 1,
                    Username = "admin",
                    Role = "admin",
                    NamaLengkap = "Admin Utama",
                    Email = "admin@seanote.com",
                    NomorTelepon = "08123"
                };
                admin.SetPassword("123");
                dummyUsers.Add(admin);
            }
        }
    }
}

