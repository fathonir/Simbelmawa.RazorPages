using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class Luaran
    {
        [Key]
        public Guid IdLuaran { get; set; }
        public Guid? IdUsulanKegiatan { get; set; }
        public short? NoUrut { get; set; }
        public string Luaran1 { get; set; }
        public char? KdStatusPelaksanaan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual UsulanKegiatan IdUsulanKegiatanNavigation { get; set; }
    }
}
