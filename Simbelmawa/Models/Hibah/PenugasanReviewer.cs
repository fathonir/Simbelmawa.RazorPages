using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class PenugasanReviewer
    {
        [Key]
        public Guid IdPenugasanReviewer { get; set; }
        public int IdSkim { get; set; }
        public string ThnUsulanKegiatan { get; set; }
        public Guid IdReviewer { get; set; }
        public string KdTahapanKegiatan { get; set; }
        public bool? StatusReviewer3 { get; set; }
        public Guid? IdInstitusiYgMenugasi { get; set; }
        public string ThnPelaksanaanKegiatan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual Reviewer IdReviewerNavigation { get; set; }
        public virtual SkimKegiatan IdSkimNavigation { get; set; }
        public virtual TahapanKegiatan KdTahapanKegiatanNavigation { get; set; }
        public virtual PDPT.Institusi IdInstitusiYgMenugasiNavigation { get; set; }
    }
}
