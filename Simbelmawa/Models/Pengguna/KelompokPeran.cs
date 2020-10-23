using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Simbelmawa.Models.PDPT;

namespace Simbelmawa.Models.Pengguna
{
    public partial class KelompokPeran
    {
        public KelompokPeran()
        {
            Peran = new HashSet<Peran>();
        }

        [Key]
        public string KdKelompokPeran { get; set; }
        public string KelompokPeran1 { get; set; }
        public char? KdJenisInstitusi { get; set; }
        public char? KdTataranPengguna { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual TataranPengguna KdTataranPenggunaNavigation { get; set; }
        public virtual ICollection<Peran> Peran { get; set; }
        public virtual JenisInstitusi KdJenisInstitusiNavigation { get; set; }
    }
}
