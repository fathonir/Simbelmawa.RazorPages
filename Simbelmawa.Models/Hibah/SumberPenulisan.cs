using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class SumberPenulisan
    {
        [Key]
        public Guid IdSumberPenulisan { get; set; }
        public Guid? IdUsulanKegiatan { get; set; }
        public short? NoUrut { get; set; }
        public string SumberPenulisan1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual UsulanKegiatan IdUsulanKegiatanNavigation { get; set; }
    }
}
