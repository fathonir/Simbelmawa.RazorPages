using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class PenetapanPemenang
    {
        [Key]
        public Guid IdPenetapanPemenang { get; set; }
        public Guid IdPenetapanHasilTahapan { get; set; }
        public Guid IdTransaksiKegiatan { get; set; }
        public int? IdSkim { get; set; }
        public string ThnUsulanKegiatan { get; set; }
        public char? KdKlaster { get; set; }
        public char? KdStsPenetapanPemenang { get; set; }
        public decimal? Nilai { get; set; }
        public decimal? DanaDisetujui { get; set; }
        public DateTime TglData { get; set; }
        public string ThnPelaksanaanKegiatan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual PenetapanHasilTahapan IdPenetapanHasilTahapanNavigation { get; set; }
        public virtual SkimKegiatan IdSkimNavigation { get; set; }
        public virtual TransaksiKegiatan IdTransaksiKegiatanNavigation { get; set; }
        public virtual PDPT.Klaster KdKlasterNavigation { get; set; }
    }
}
