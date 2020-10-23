using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class CatatanHarianPelaksanaan
    {
        public CatatanHarianPelaksanaan()
        {
            BerkasCatatanHarian = new HashSet<BerkasCatatanHarian>();
            PengeluaranKegiatan = new HashSet<PengeluaranKegiatan>();
        }

        [Key]
        public Guid IdCatatanHarian { get; set; }
        public Guid? IdUsulanKegiatan { get; set; }
        public DateTime? TglPelaksanaan { get; set; }
        public string KegiatanYgDilakukan { get; set; }
        public decimal? BiayaYgTerpakai { get; set; }
        public string Keterangan { get; set; }
        public DateTime? TglDataDibuat { get; set; }
        public DateTime? TglDataDiperbarui { get; set; }
        public short? PersentaseCapaian { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual UsulanKegiatan IdUsulanKegiatanNavigation { get; set; }
        public virtual ICollection<BerkasCatatanHarian> BerkasCatatanHarian { get; set; }
        public virtual ICollection<PengeluaranKegiatan> PengeluaranKegiatan { get; set; }
    }
}
