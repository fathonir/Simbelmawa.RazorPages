using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Pengguna
{
    public partial class PeranOperator
    {
        [Key]
        public Guid IdPeranOperator { get; set; }
        public int? IdPeran { get; set; }
        public char? KdJenisKegiatan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual Peran IdPeranNavigation { get; set; }
    }
}
