using System;

namespace Simbelmawa.Models.Pengguna
{
    public partial class LoginGagal
    {
        public string NamaUser { get; set; }
        public string Pswd { get; set; }
        public string IpKomputer { get; set; }
        public int? IdPeran { get; set; }
        public DateTime? WaktuAkses { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
    }
}
