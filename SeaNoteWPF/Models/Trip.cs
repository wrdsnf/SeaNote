//using System;
//using System.Collections.Generic;
//namespace SeaNote.Models
//{
//    public class Trip
//    {
//        public long TripId { get; set; }
//        public long? KapalId { get; set; }
//        public DateTime? TanggalBerangkat { get; set; }
//        public DateTime? TanggalSampai { get; set; }
//        public string? TitikBerangkat { get; set; }
//        public string? Nakhoda { get; set; }
//        public string? Notes { get; set; }
//        public List<TripTask> Tasks { get; } = new List<TripTask>();
//        public List<Log> Logs { get; } = new List<Log>();
//    }
//}


using System;
using System.Collections.Generic;

namespace SeaNote.Models
{
    public class Trip : ReportableBase
    {
        public long TripId { get; set; }
        public long? KapalId { get; set; }
        public DateTime? TanggalBerangkat { get; set; }
        public DateTime? TanggalSampai { get; set; }
        public string? TitikBerangkat { get; set; }
        public string? Nakhoda { get; set; }
        public string? Notes { get; set; }
        public List<TripTask> Tasks { get; } = new List<TripTask>();
        public List<Log> Logs { get; } = new List<Log>();

        public override string GetSummary()
        {
            return $"[TRIP] Dari: {this.TitikBerangkat ?? "N/A"} (Kapten: {this.Nakhoda ?? "N/A"})";
        }
    }
}