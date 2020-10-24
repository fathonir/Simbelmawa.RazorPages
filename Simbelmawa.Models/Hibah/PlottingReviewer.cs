using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class PlottingReviewer
    {
        public PlottingReviewer()
        {
            HasilPenilaian = new HashSet<HasilPenilaian>();
            HasilReview = new HashSet<HasilReview>();
        }

        [Key]
        public Guid IdPlottingReviewer { get; set; }
        public Guid IdTransaksiKegiatan { get; set; }
        public Guid IdReviewer { get; set; }
        public DateTime TglPlotting { get; set; }
        public short? NoUrut { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual Reviewer IdReviewerNavigation { get; set; }
        public virtual TransaksiKegiatan IdTransaksiKegiatanNavigation { get; set; }
        public virtual ICollection<HasilReview> HasilReview { get; set; }
        public virtual ICollection<HasilPenilaian> HasilPenilaian { get; set; }
    }
}
