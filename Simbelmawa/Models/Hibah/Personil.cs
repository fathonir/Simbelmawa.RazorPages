using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class Personil
    {
        [Key]
        public Guid IdPersonil { get; set; }
        public Guid IdPersonal { get; set; }
        public Guid IdUsulanKegiatan { get; set; }
        public string KdPeranPersonil { get; set; }
        public char? KdStsAktif { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public short IsPimnas { get; set; }
        public string TipeBerkas { get; set; }
        public short IsDibiayai { get; set; }

        public virtual UsulanKegiatan IdUsulanKegiatanNavigation { get; set; }
        public virtual PeranPersonil KdPeranPersonilNavigation { get; set; }
        public virtual PDPT.Personal IdPersonalNavigation { get; set; }
    }
}
