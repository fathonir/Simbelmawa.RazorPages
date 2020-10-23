using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class Provinsi
    {
        public Provinsi()
        {
            Kota = new HashSet<Kota>();
        }

        [Key]
        public string KodeProvinsi { get; set; }
        public string NamaProvinsi { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual ICollection<Kota> Kota { get; set; }
    }
}
