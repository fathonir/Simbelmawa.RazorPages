using System;
using System.Collections.Generic;
using Simbelmawa.Models.PDPT;

namespace Simbelmawa.Models.Pengguna
{
    /// <summary>
    /// IdentitasPengguna merupakan class untuk login sebagai implementasi dari IdentityUser
    /// </summary>
    public partial class IdentitasPengguna
    {
        public IdentitasPengguna()
        {
            PeranPengguna = new HashSet<PeranPengguna>();
            Sertifikat = new HashSet<Sertifikat>();
        }

        public Guid IdPersonal { get; set; }
        public string NamaUser { get; set; }
        public string Pswd { get; set; }
        public DateTime? TglData { get; set; }
        public char KdStsPengguna { get; set; }
        public Guid? IdInstitusi { get; set; }
        public DateTime TglUpdated { get; set; }
        public DateTime TglCreated { get; set; }

        public virtual StatusPengguna KdStsPenggunaNavigation { get; set; }
        public virtual ICollection<PeranPengguna> PeranPengguna { get; set; }
        public virtual ICollection<Sertifikat> Sertifikat { get; set; }
        public virtual Institusi IdInstitusiNavigation { get; set; }
        public virtual Personal IdPersonalNavigation { get; set; }
    }
}
