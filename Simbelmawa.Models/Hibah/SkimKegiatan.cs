using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class SkimKegiatan
    {
        public SkimKegiatan()
        {
            Bidang = new HashSet<Bidang>();
            PenetapanPemenang = new HashSet<PenetapanPemenang>();
            PenugasanReviewer = new HashSet<PenugasanReviewer>();
            PeranPersonil = new HashSet<PeranPersonil>();
            SkimMultiTahun = new HashSet<SkimMultiTahun>();
            StatusPublish = new HashSet<StatusPublish>();
            TahapanKegiatanSkim = new HashSet<TahapanKegiatanSkim>();
            Usulan = new HashSet<Usulan>();
            UsulanDidanai = new HashSet<UsulanDidanai>();
        }

        [Key]
        public int IdSkim { get; set; }
        public string KdSkim { get; set; }
        public string NamaSkim { get; set; }
        public string NamaSingkatSkim { get; set; }
        public char? KdStsAktif { get; set; }
        public short JmlMinimalPersonil { get; set; }
        public short JmlMaksimalPersonil { get; set; }
        public short JmlMaksimalKeikutsertaan { get; set; }
        public short JmlMaksimalSbgKetua { get; set; }
        public decimal DanaMaksimalThnBerjalan { get; set; }
        public decimal? DanaMinimalThnBerjalan { get; set; }
        public string Keterangan { get; set; }
        public int DeviasiNilai { get; set; }
        public decimal PassingGrade { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public int? IdJenis { get; set; }

        public virtual SkimJenis IdJenisNavigation { get; set; }
        public virtual ICollection<Bidang> Bidang { get; set; }
        public virtual ICollection<PenetapanPemenang> PenetapanPemenang { get; set; }
        public virtual ICollection<PenugasanReviewer> PenugasanReviewer { get; set; }
        public virtual ICollection<PeranPersonil> PeranPersonil { get; set; }
        public virtual ICollection<SkimMultiTahun> SkimMultiTahun { get; set; }
        public virtual ICollection<StatusPublish> StatusPublish { get; set; }
        public virtual ICollection<TahapanKegiatanSkim> TahapanKegiatanSkim { get; set; }
        public virtual ICollection<Usulan> Usulan { get; set; }
        public virtual ICollection<UsulanDidanai> UsulanDidanai { get; set; }
    }
}
