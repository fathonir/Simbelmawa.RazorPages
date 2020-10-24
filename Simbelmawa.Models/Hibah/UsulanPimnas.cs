using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class UsulanPimnas
    {
        [Key]
        public Guid IdUsulanKegiatan { get; set; }
        public char KdStsPermanen { get; set; }
        public DateTime TglCreated { get; set; }

        public virtual UsulanKegiatan IdUsulanKegiatanNavigation { get; set; }
    }
}
