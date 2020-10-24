using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class SkoringPimnas
    {
        [Key]
        public Guid IdUsulanKegiatan { get; set; }
        public string KdTahapanKegiatan { get; set; }
        public int IdSkim { get; set; }
        public Guid IdReviewer { get; set; }
        public short NoUrut { get; set; }
        public float? Skor { get; set; }
        public float Delta { get; set; }
        public DateTime TglCreated { get; set; }
        public string NamaReviewer { get; set; }

        public virtual Reviewer IdReviewerNavigation { get; set; }
        public virtual UsulanKegiatan IdUsulanKegiatanNavigation { get; set; }
    }
}
