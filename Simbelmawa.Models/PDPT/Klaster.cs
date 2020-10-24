using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class Klaster
    {
        public Klaster()
        {
            KlasterPerguruanTinggi = new HashSet<KlasterPerguruanTinggi>();
            PenetapanPemenang = new HashSet<Hibah.PenetapanPemenang>();
        }

        [Key]
        public char KdKlaster { get; set; }
        public string Keterangan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public int? UrutanKlaster { get; set; }

        public virtual ICollection<KlasterPerguruanTinggi> KlasterPerguruanTinggi { get; set; }
        public virtual ICollection<Hibah.PenetapanPemenang> PenetapanPemenang { get; set; }
    }
}
