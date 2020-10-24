using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Pengguna
{
    public partial class StatusPengguna
    {
        public StatusPengguna()
        {
            IdentitasPengguna = new HashSet<IdentitasPengguna>();
        }

        [Key]
        public char KdStsPengguna { get; set; }
        public string StatusPengguna1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual ICollection<IdentitasPengguna> IdentitasPengguna { get; set; }
    }
}
