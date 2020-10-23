using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class Kota
    {
        public Kota()
        {
            Institusi = new HashSet<Institusi>();
            Personal = new HashSet<Personal>();
        }

        [Key]
        public string KodeKota { get; set; }
        public string NamaKota { get; set; }
        public string KodeProvinsi { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual Provinsi KodeProvinsiNavigation { get; set; }
        public virtual ICollection<Institusi> Institusi { get; set; }
        public virtual ICollection<Personal> Personal { get; set; }
    }
}
