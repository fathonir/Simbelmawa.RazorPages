using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class PengeluaranKegiatan
    {
        [Key]
        public long IdPengeluaranKegiatan { get; set; }
        public Guid? IdCatatanHarian { get; set; }
        public string KdJenisPembelanjaan { get; set; }
        public string NamaPembelanjaan { get; set; }
        public decimal? JmlPembelanjaan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual CatatanHarianPelaksanaan IdCatatanHarianNavigation { get; set; }
        public virtual JenisPembelanjaan KdJenisPembelanjaanNavigation { get; set; }
    }
}
