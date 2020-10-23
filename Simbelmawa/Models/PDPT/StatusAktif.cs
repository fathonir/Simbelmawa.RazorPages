using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class StatusAktif
    {
        [Key]
        public char KodeStatusAktif { get; set; }
        public string StatusAktif1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
    }
}
