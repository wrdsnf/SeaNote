namespace SeaNote.Models
{
    public class TripTask
    {
        public int TaskID { get; set; }
        public string NamaTask { get; set; } = "";
        public string Deskripsi { get; set; } = "";
        public bool IsCompleted { get; set; }
        public int TripID { get; set; }

        public void MarkCompleted() => IsCompleted = true;
    }
}
