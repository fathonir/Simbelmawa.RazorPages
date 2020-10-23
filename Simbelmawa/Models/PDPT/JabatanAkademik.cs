using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class JabatanAkademik
    {
        [Key]
        public int KodeJabatanAkademik { get; set; }
        public string JabatanAkademik1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
    }
}
