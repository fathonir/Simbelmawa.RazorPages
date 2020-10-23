using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class HasilReview
    {
        [Key]
        public Guid IdPlottingReviewer { get; set; }
        public decimal? RekomendasiDana { get; set; }
        public string Komentar { get; set; }
        public string Catatan { get; set; }
        public string Tempat { get; set; }
        public DateTime? TglReview { get; set; }
        public char? KdStsPermanen { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public string GagalEval1 { get; set; }

        public virtual PlottingReviewer IdPlottingReviewerNavigation { get; set; }
    }
}
