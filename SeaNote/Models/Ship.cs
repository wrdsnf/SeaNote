//using System;
//namespace SeaNote.Models
//{
//    public class Ship
//    {
//        public long KapalId { get; set; }
//        public string Name { get; set; } = "";
//        public int? Year { get; set; }
//        public int? Capacity { get; set; }
//        public int? TotalTrip { get; set; }
//        public string? Fuel { get; set; }
//    }
//}

using System;

namespace SeaNote.Models
{
    public class Ship : ReportableBase
    {
        public long KapalId { get; set; }
        public string Name { get; set; } = "";
        public int? Year { get; set; }
        public int? Capacity { get; set; }
        public int? TotalTrip { get; set; }
        public string? Fuel { get; set; }


        public override string GetSummary()
        {
            return $"[KAPAL] {this.Name} (Tahun: {(this.Year.HasValue ? this.Year.Value.ToString() : "N/A")})";
        }
    }
}