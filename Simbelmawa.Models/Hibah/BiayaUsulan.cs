using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class BiayaUsulan
    {
        [Key]
        public Guid IdUsulanKegiatan { get; set; }
        public decimal? DanaUsulan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public decimal? DanaSumberLain { get; set; }
        public string SumberDana { get; set; }

        public virtual UsulanKegiatan UsulanKegiatan { get; set; }
    }
}
