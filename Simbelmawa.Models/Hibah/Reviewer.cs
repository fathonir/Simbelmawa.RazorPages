using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class Reviewer
    {
        public Reviewer()
        {
            PenugasanReviewer = new HashSet<PenugasanReviewer>();
            PlottingReviewer = new HashSet<PlottingReviewer>();
            SkoringPimnas = new HashSet<SkoringPimnas>();
        }

        [Key]
        public Guid IdReviewer { get; set; }
        public char? KdKategoriReviewer { get; set; }
        public char? KdStsAktif { get; set; }
        public string Kompetensi { get; set; }
        public Guid? IdPersonal { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public string Kelompok { get; set; }

        public virtual ICollection<PenugasanReviewer> PenugasanReviewer { get; set; }
        public virtual ICollection<PlottingReviewer> PlottingReviewer { get; set; }
        public virtual ICollection<SkoringPimnas> SkoringPimnas { get; set; }
    }
}
