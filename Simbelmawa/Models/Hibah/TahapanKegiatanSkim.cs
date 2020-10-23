using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class TahapanKegiatanSkim
    {
        public TahapanKegiatanSkim()
        {
            AlasanPenolakan = new HashSet<AlasanPenolakan>();
            KomponenPenilaian = new HashSet<KomponenPenilaian>();
            TransaksiKegiatan = new HashSet<TransaksiKegiatan>();
        }
        
        [Key]
        public int IdTahapanKegiatanSkim { get; set; }
        public int? IdSkim { get; set; }
        public string KdTahapanKegiatan { get; set; }
        public short? NoUrut { get; set; }
        public char? KdStsAktif { get; set; }
        public char KdStsAkhirKategoriTahapan { get; set; }
        public int? Max { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual SkimKegiatan IdSkimNavigation { get; set; }
        public virtual TahapanKegiatan KdTahapanKegiatanNavigation { get; set; }
        public virtual ICollection<AlasanPenolakan> AlasanPenolakan { get; set; }
        public virtual ICollection<KomponenPenilaian> KomponenPenilaian { get; set; }
        public virtual ICollection<TransaksiKegiatan> TransaksiKegiatan { get; set; }
    }
}
