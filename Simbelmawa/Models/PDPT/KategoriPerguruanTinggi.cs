using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class KategoriPerguruanTinggi
    {
        public KategoriPerguruanTinggi()
        {
            PerguruanTinggi = new HashSet<PerguruanTinggi>();
        }

        [Key]
        public decimal KodeKategoriPerguruanTinggi { get; set; }
        public string KategoriPerguruanTinggi1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual ICollection<PerguruanTinggi> PerguruanTinggi { get; set; }
    }
}
