using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class UsulanDidanai
    {
        [Key]
        public Guid IdUsulanKegiatan { get; set; }
        public Guid? IdTransaksiKegiatan { get; set; }
        public int? IdSkim { get; set; }
        public decimal? Nilai { get; set; }
        public decimal? DanaDisetujui { get; set; }
        public Guid? IdPersonalKetua { get; set; }
        public Guid? IdInstitusi { get; set; }
        public string KdTahapanKegiatan { get; set; }
        public DateTime TglData { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual SkimKegiatan IdSkimNavigation { get; set; }
        public virtual TransaksiKegiatan IdTransaksiKegiatanNavigation { get; set; }
        public virtual UsulanKegiatan IdUsulanKegiatanNavigation { get; set; }
        public virtual TahapanKegiatan KdTahapanKegiatanNavigation { get; set; }
        public virtual PDPT.Institusi IdInstitusiNavigation { get; set; }
        public virtual PDPT.Personal IdPersonalKetuaNavigation { get; set; }
    }
}
