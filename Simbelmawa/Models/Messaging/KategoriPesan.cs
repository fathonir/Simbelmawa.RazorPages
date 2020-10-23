using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Messaging
{
    public partial class KategoriPesan
    {
        public KategoriPesan()
        {
            Pesan = new HashSet<Pesan>();
        }

        [Key]
        public int IdKategoriPesan { get; set; }
        public string Kategori { get; set; }
        public int? IdPeran { get; set; }

        public virtual SubBagianBelmawa IdPeranNavigation { get; set; }
        public virtual ICollection<Pesan> Pesan { get; set; }
    }
}
