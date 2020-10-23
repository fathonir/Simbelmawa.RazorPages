using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class HostKegiatan
    {
        [Key]
        public Guid IdHostKegiatan { get; set; }
        public string HostKegiatan1 { get; set; }
        public string ThnPelaksanaan { get; set; }
        public string KdTahapanKegiatan { get; set; }
        public DateTime TglMulai { get; set; }
        public DateTime TglBerakhir { get; set; }
        public short JumlahKelas { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime? TglUpdated { get; set; }
    }
}
