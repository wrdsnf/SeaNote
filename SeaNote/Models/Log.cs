using System;

namespace SeaNote.Models
{
    public class Log
    {
        public int LogID { get; set; }
        public DateTime TanggalLog { get; set; }
        public string JenisLog { get; set; } = "";
        public string IsiLog { get; set; } = "";
        public int TripID { get; set; }

        public void Update(string jenis, string isi)
        {
            JenisLog = jenis;
            IsiLog = isi;
            TanggalLog = DateTime.Now;
        }
    }
}
