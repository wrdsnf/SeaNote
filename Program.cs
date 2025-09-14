using System;
using SeaNote.Models;

namespace SeaNoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User { UserID = 1, Username = "admin", Role = "Administrator" };
            user.SetPassword("12345");

            Console.WriteLine(user.Login("admin", "12345") ? "Login sukses" : "Login gagal");

            var trip = new Trip
            {
                TripID = 1,
                KodeTrip = "TRIP-001",
                NamaKapal = "Nusantara",
                TanggalBerangkat = DateTime.Now,
                TanggalSampai = DateTime.Now.AddDays(2),
                TitikBerangkat = "Pelabuhan A",
                Nakhoda = "Pak Jono",
                Notes = "Jaga cuaca",
                UserID = user.UserID
            };

            trip.AddTask(new TripTask { TaskID = 1, NamaTask = "Cek Mesin", Deskripsi = "Periksa mesin utama" });
            trip.AddTask(new TripTask { TaskID = 2, NamaTask = "Cek Navigasi", Deskripsi = "Test alat navigasi" });

            trip.AddLog(new Log { LogID = 1, TanggalLog = DateTime.Now, JenisLog = "Info", IsiLog = "Berangkat" });

            Console.WriteLine($"Trip {trip.KodeTrip} ({trip.NamaKapal}) - Tasks: {trip.Tasks.Count}, Logs: {trip.Logs.Count}");
            Console.WriteLine($"Generated KodeTrip: {trip.GenerateKodeTrip()}");
        }
    }
}
