using System;
namespace SeaNote.Models
{
    public class Log
    {
        public long LogId { get; set; }
        public long TripId { get; set; }
        public string? JenisLog { get; set; }
        public string? IsiLog { get; set; }
        public DateTime TanggalLog { get; set; }
    }
}
