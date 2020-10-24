using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Pengguna
{
    public partial class TataranPengguna
    {
        public TataranPengguna()
        {
            KelompokPeran = new HashSet<KelompokPeran>();
        }
        
        [Key]
        public char KdTataranPengguna { get; set; }
        public string TataranPengguna1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual ICollection<KelompokPeran> KelompokPeran { get; set; }
    }
}
