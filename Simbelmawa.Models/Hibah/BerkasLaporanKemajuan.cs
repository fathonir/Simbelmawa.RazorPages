using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class BerkasLaporanKemajuan
    {
        [Key]
        public Guid IdUsulanKegiatan { get; set; }
        public string NamaBerkas { get; set; }
        public string TipeBerkas { get; set; }
        public int UkuranBerkas { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime? TglUpdated { get; set; }

        public virtual UsulanKegiatan IdUsulanKegiatanNavigation { get; set; }
    }
}
