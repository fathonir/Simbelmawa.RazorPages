using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Pengguna
{
    public partial class StatusPeranPengguna
    {
        public StatusPeranPengguna()
        {
            PeranPengguna = new HashSet<PeranPengguna>();
        }

        [Key]
        public char KdStsPeranPengguna { get; set; }
        public string StatusPeranPengguna1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual ICollection<PeranPengguna> PeranPengguna { get; set; }
    }
}
