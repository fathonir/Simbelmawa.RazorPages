using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class TransaksiKegiatan
    {
        public TransaksiKegiatan()
        {
            PenetapanHasilTahapan = new HashSet<PenetapanHasilTahapan>();
            PenetapanPemenang = new HashSet<PenetapanPemenang>();
            PlottingReviewer = new HashSet<PlottingReviewer>();
            UsulanDidanai = new HashSet<UsulanDidanai>();
        }

        [Key]
        public Guid IdTransaksiKegiatan { get; set; }
        public Guid? IdUsulanKegiatan { get; set; }
        public int IdTahapanKegiatanSkim { get; set; }
        public char? KdStsPelaksanaan { get; set; }
        public DateTime? TglPelaksanaan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual TahapanKegiatanSkim IdTahapanKegiatanSkimNavigation { get; set; }
        public virtual UsulanKegiatan IdUsulanKegiatanNavigation { get; set; }
        public virtual ICollection<PenetapanHasilTahapan> PenetapanHasilTahapan { get; set; }
        public virtual ICollection<PenetapanPemenang> PenetapanPemenang { get; set; }
        public virtual ICollection<PlottingReviewer> PlottingReviewer { get; set; }
        public virtual ICollection<UsulanDidanai> UsulanDidanai { get; set; }
    }
}
