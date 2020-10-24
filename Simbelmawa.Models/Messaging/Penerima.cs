using System;

namespace Simbelmawa.Models.Messaging
{
    public partial class Penerima
    {
        /// <summary>Dummy Primary Key</summary>
        public Guid PenerimaId { get; set; }
        public Guid IdPesan { get; set; }
        public Guid IdPersonal { get; set; }
        public bool StatusBacaPesan { get; set; }
        public DateTime? TglBacaPesan { get; set; }
        public bool? StatusHapusPesan { get; set; }
        public DateTime? TglHapusPesan { get; set; }

        public virtual Pesan IdPesanNavigation { get; set; }
        public virtual PDPT.Personal IdPersonalNavigation { get; set; }
    }
}
