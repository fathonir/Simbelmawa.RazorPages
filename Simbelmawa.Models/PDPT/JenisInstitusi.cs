using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Simbelmawa.Models.Pengguna;

namespace Simbelmawa.Models.PDPT
{
    public partial class JenisInstitusi
    {
        public JenisInstitusi()
        {
            Institusi = new HashSet<Institusi>();
            KelompokPeran = new HashSet<KelompokPeran>();
        }

        [Key]
        public char KdJenisInstitusi { get; set; }
        public string JenisInstitusi1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual ICollection<Institusi> Institusi { get; set; }
        public virtual ICollection<KelompokPeran> KelompokPeran { get; set; }
    }
}
