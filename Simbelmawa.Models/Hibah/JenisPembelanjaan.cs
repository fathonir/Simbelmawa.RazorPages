using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class JenisPembelanjaan
    {
        public JenisPembelanjaan()
        {
            PengeluaranKegiatan = new HashSet<PengeluaranKegiatan>();
        }

        [Key]
        public string KdJenisPembelanjaan { get; set; }
        public string JenisPembelanjaan1 { get; set; }
        public string Keterangan { get; set; }
        public char KdStsAktif { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual ICollection<PengeluaranKegiatan> PengeluaranKegiatan { get; set; }
    }
}
