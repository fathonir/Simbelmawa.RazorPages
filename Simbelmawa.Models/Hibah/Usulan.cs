using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class Usulan
    {
        public Usulan()
        {
            UsulanKegiatan = new HashSet<UsulanKegiatan>();
        }

        [Key]
        public Guid IdUsulan { get; set; }
        public string KodePerguruanTinggi { get; set; }
        public int? IdSkim { get; set; }
        public string Judul { get; set; }
        public short? LamaKegiatan { get; set; }
        public string ThnUsulan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public int? IdBidang { get; set; }

        public virtual SkimKegiatan IdSkimNavigation { get; set; }
        public virtual ICollection<UsulanKegiatan> UsulanKegiatan { get; set; }
        public virtual PDPT.PerguruanTinggi KodePerguruanTinggiNavigation { get; set; }
    }
}
