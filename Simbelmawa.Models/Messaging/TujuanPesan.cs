using System;

namespace Simbelmawa.Models.Messaging
{
    public partial class TujuanPesan
    {
        /// <summary>Dummy Primary Key</summary>
        public Guid TujuanPesanId { get; set; }
        public Guid IdPesan { get; set; }
        public int? IdPeran { get; set; }
        public bool? StatusBacaPesan { get; set; }
        public DateTime? TglBacaPesan { get; set; }
        public bool? StatusHapusPesan { get; set; }
        public DateTime? TglHapusPesan { get; set; }
        public Guid? IdPersonalPenghapusPesan { get; set; }

        public virtual SubBagianBelmawa IdPeranNavigation { get; set; }
        public virtual Pesan IdPesanNavigation { get; set; }
    }
}
