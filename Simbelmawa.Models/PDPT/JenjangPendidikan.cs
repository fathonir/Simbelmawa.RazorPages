using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class JenjangPendidikan
    {
        public JenjangPendidikan()
        {
            Dosen = new HashSet<Dosen>();
        }

        [Key]
        public int KodeJenjangPendidikan { get; set; }
        public string JenjangPendidikan1 { get; set; }
        public string Degree { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual ICollection<Dosen> Dosen { get; set; }
    }
}
