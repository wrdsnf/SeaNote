using System;
namespace SeaNote.Models
{
    public class Maintenance
    {
        public long MaintenanceId { get; set; }
        public long KapalId { get; set; }
        public string MaintenanceTitle { get; set; } = "";
        public string? Description { get; set; }
        public string Status { get; set; } = "scheduled";
        public DateTime? MaintenanceDate { get; set; }
    }
}
