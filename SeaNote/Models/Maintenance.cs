using System;

namespace SeaNote.Models
{
    public class Maintenance
    {
        public int MaintenanceID { get; set; }
        public int ShipID { get; set; }

        // Kita tambahin ShipName di sini biar gampang nampilin di grid,
        // gak perlu join-join-an
        public string ShipName { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime DateScheduled { get; set; }
        public string Status { get; set; } = "Pending"; // Default status
    }
}
