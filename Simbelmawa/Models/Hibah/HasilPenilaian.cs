using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class HasilPenilaian
    {
        [Key]
        public Guid IdHasilPenilaian { get; set; }
        public Guid? IdPlottingReviewer { get; set; }
        public int? IdKomponenPenilaian { get; set; }
        public int? Nilai { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual KomponenPenilaian IdKomponenPenilaianNavigation { get; set; }
        public virtual PlottingReviewer IdPlottingReviewerNavigation { get; set; }
    }
}
