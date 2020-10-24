using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Pengguna
{
    public partial class Sertifikat
    {
        [Key]
        public Guid IdSertifikat { get; set; }
        public Guid? IdPersonal { get; set; }
        public string IpKomputer { get; set; }
        public DateTime WaktuLogin { get; set; }
        public DateTime? WaktuAksesTerakhir { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual IdentitasPengguna IdPersonalNavigation { get; set; }
    }
}
