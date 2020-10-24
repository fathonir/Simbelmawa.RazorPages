using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class TopikUsulan
    {
        [Key]
        public Guid IdUsulanKegiatan { get; set; }
        public string Abstrak { get; set; }
        public string Keywords { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual UsulanKegiatan IdUsulanKegiatanNavigation { get; set; }
    }
}
