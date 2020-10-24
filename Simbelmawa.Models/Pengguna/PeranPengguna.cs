using System;

namespace Simbelmawa.Models.Pengguna
{
    public partial class PeranPengguna
    {
        /// <summary>Dummy Primary Key</summary>
        public Guid PeranPenggunaId { get; set; }
        public Guid IdPersonal { get; set; }
        public int IdPeran { get; set; }
        public char? KdStsPeranPengguna { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public char IsDefault { get; set; }

        public virtual Peran IdPeranNavigation { get; set; }
        public virtual IdentitasPengguna IdPersonalNavigation { get; set; }
        public virtual StatusPeranPengguna KdStsPeranPenggunaNavigation { get; set; }
    }
}
