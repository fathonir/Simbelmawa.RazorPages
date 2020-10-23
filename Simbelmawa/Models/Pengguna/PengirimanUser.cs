using System;
using System.ComponentModel.DataAnnotations;
using Simbelmawa.Models.PDPT;

namespace Simbelmawa.Models.Pengguna
{
    public partial class PengirimanUser
    {
        [Key]
        public Guid IdPengirimanUser { get; set; }
        public Guid? IdKontakPicPenggunaInstitusi { get; set; }
        public string Surel { get; set; }
        public DateTime WaktuPegiriman { get; set; }
        public char? KdStsPengiriman { get; set; }
        public string SurelPengirim { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public Guid? IdPersonal { get; set; }

        public virtual Personal IdPersonalNavigation { get; set; }
    }
}
