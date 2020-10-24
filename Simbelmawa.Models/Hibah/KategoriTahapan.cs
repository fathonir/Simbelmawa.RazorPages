using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class KategoriTahapan
    {
        public KategoriTahapan()
        {
            TahapanKegiatan = new HashSet<TahapanKegiatan>();
        }

        [Key]
        public char KdKategoriTahapan { get; set; }
        public string KategoriTahapan1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual ICollection<TahapanKegiatan> TahapanKegiatan { get; set; }
    }
}
