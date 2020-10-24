using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class JenisPerguruanTinggi
    {
        public JenisPerguruanTinggi()
        {
            PerguruanTinggi = new HashSet<PerguruanTinggi>();
        }

        [Key]
        public char KodeJenisPerguruanTinggi { get; set; }
        public string JenisPerguruanTinggi1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual ICollection<PerguruanTinggi> PerguruanTinggi { get; set; }
    }
}
