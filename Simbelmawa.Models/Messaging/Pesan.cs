using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Messaging
{
    public partial class Pesan
    {
        public Pesan()
        {
            BerkasPesan = new HashSet<BerkasPesan>();
            Penerima = new HashSet<Penerima>();
            Pengirim = new HashSet<Pengirim>();
            TujuanPesan = new HashSet<TujuanPesan>();
        }

        [Key]
        public Guid IdPesan { get; set; }
        public string Judul { get; set; }
        public string IsiPesan { get; set; }
        public DateTime? TglDibuat { get; set; }
        public int? IdKategoriPesan { get; set; }

        public virtual KategoriPesan IdKategoriPesanNavigation { get; set; }
        public virtual ICollection<BerkasPesan> BerkasPesan { get; set; }
        public virtual ICollection<Penerima> Penerima { get; set; }
        public virtual ICollection<Pengirim> Pengirim { get; set; }
        public virtual ICollection<TujuanPesan> TujuanPesan { get; set; }
    }
}
