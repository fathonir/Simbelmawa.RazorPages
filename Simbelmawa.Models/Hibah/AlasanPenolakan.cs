using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class AlasanPenolakan
    {
        [Key]
        public Guid IdAlasanPenolakan { get; set; }
        public string AlasanPenolakan1 { get; set; }
        public int? IdTahapanKegiatanSkim { get; set; }
        public int? NoUrut { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual TahapanKegiatanSkim IdTahapanKegiatanSkimNavigation { get; set; }
    }
}
