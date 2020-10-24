using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class StatusAktifPdpt
    {
        [Key]
        public string KdStatusAktifPdpt { get; set; }
        public string StsKeaktifan { get; set; }
        public char? KdStatusAktif { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
    }
}
