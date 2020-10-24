using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class TahapanKegiatan
    {
        public TahapanKegiatan()
        {
            BerkasUsulanKegiatan = new HashSet<BerkasUsulanKegiatan>();
            PenugasanReviewer = new HashSet<PenugasanReviewer>();
            StatusPublish = new HashSet<StatusPublish>();
            TahapanKegiatanSkim = new HashSet<TahapanKegiatanSkim>();
            UsulanDidanai = new HashSet<UsulanDidanai>();
        }

        [Key]
        public string KdTahapanKegiatan { get; set; }
        public string Tahapan { get; set; }
        public char? KdKategoriTahapan { get; set; }
        public char? KdStsAktif { get; set; }
        public char KdStsTahapanEvaluasi { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public string UrutanTahapanKegiatan { get; set; }

        public virtual KategoriTahapan KdKategoriTahapanNavigation { get; set; }
        public virtual ICollection<BerkasUsulanKegiatan> BerkasUsulanKegiatan { get; set; }
        public virtual ICollection<PenugasanReviewer> PenugasanReviewer { get; set; }
        public virtual ICollection<StatusPublish> StatusPublish { get; set; }
        public virtual ICollection<TahapanKegiatanSkim> TahapanKegiatanSkim { get; set; }
        public virtual ICollection<UsulanDidanai> UsulanDidanai { get; set; }
    }
}
