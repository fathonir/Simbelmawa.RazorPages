using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class PenetapanHasilTahapan
    {
        public PenetapanHasilTahapan()
        {
            PenetapanPemenang = new HashSet<PenetapanPemenang>();
        }

        [Key]
        public Guid IdPenetapanHasilTahapan { get; set; }
        public Guid IdTransaksiKegiatan { get; set; }
        public DateTime? TglPenetapan { get; set; }
        public char? KdStsHasilTahapan { get; set; }
        public DateTime TglData { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual TransaksiKegiatan IdTransaksiKegiatanNavigation { get; set; }
        public virtual ICollection<PenetapanPemenang> PenetapanPemenang { get; set; }
    }
}
