using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class Bidang
    {
        [Key]
        public int IdBidang { get; set; }
        public int? IdSkim { get; set; }
        public string Bidang1 { get; set; }
        public string Keterangan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual SkimKegiatan IdSkimNavigation { get; set; }
    }
}
