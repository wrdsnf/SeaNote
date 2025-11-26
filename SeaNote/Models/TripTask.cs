using System;
namespace SeaNote.Models
{
    public class TripTask
    {
        public long TaskId { get; set; }
        public long TripId { get; set; }
        public string TaskName { get; set; } = "";
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
