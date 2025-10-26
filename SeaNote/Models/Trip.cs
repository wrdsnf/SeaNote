using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaNote.Models
{
    public class Trip
    {
        public int TripID { get; set; }
        public string KodeTrip { get; set; } = "";
        public string NamaKapal { get; set; } = "";
        public DateTime TanggalBerangkat { get; set; }
        public DateTime? TanggalSampai { get; set; }
        public string TitikBerangkat { get; set; } = "";
        public string Nakhoda { get; set; } = "";
        public string Notes { get; set; } = "";
        public int UserID { get; set; }

        public List<TripTask> Tasks { get; } = new List<TripTask>();
        public List<Log> Logs { get; } = new List<Log>();

        public void AddTask(TripTask t)
        {
            t.TripID = this.TripID;
            Tasks.Add(t);
        }

        public bool DeleteTask(int taskId)
        {
            var t = Tasks.FirstOrDefault(x => x.TaskID == taskId);
            if (t == null) return false;
            Tasks.Remove(t);
            return true;
        }

        public void AddLog(Log l)
        {
            l.TripID = this.TripID;
            Logs.Add(l);
        }

        public string GenerateKodeTrip()
        {
            return $"TRIP-{DateTime.Now:yyyyMMddHHmmss}-{Guid.NewGuid().ToString().Substring(0, 6)}";
        }

        public void EditTrip(
            string? namaKapal = null,
            DateTime? tglBerangkat = null,
            DateTime? tglSampai = null,
            string? titik = null,
            string? nahkoda = null,
            string? notes = null)
        {
            if (namaKapal != null) NamaKapal = namaKapal;
            if (tglBerangkat.HasValue) TanggalBerangkat = tglBerangkat.Value;
            if (tglSampai.HasValue) TanggalSampai = tglSampai.Value;
            if (titik != null) TitikBerangkat = titik;
            if (nahkoda != null) Nakhoda = nahkoda;
            if (notes != null) Notes = notes;
        }

    }
}
