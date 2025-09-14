using System;

namespace SeaNote.Models
{
    public class Ship
    {
        public int ShipID { get; set; }
        public DateTime Maintenance { get; set; }
        public string Name { get; set; } = "";
        public int Year { get; set; }
        public int Capacity { get; set; }
        public int TotalTrip { get; set; }
        public int Fuel { get; set; }

        // stub methods — implement sesuai kebutuhan (DB, dll)
        public void AddShip() { }
        public void EditShip() { }
        public void DeleteShip() { }
    }
}
