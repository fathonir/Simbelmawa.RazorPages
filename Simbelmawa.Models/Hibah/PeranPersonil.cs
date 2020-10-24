using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class PeranPersonil
    {
        public PeranPersonil()
        {
            Personil = new HashSet<Personil>();
        }

        [Key]
        public string KdPeranPersonil { get; set; }
        public int? IdSkim { get; set; }
        public string PeranPersonil1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual SkimKegiatan IdSkimNavigation { get; set; }
        public virtual ICollection<Personil> Personil { get; set; }
    }
}
