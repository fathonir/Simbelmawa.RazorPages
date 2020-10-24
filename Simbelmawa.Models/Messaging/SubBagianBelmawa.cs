using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Messaging
{
    public partial class SubBagianBelmawa
    {
        public SubBagianBelmawa()
        {
            KategoriPesan = new HashSet<KategoriPesan>();
            TujuanPesan = new HashSet<TujuanPesan>();
        }

        [Key]
        public int IdPeran { get; set; }
        public string NamaSubBagian { get; set; }

        public virtual ICollection<KategoriPesan> KategoriPesan { get; set; }
        public virtual ICollection<TujuanPesan> TujuanPesan { get; set; }
        public virtual Pengguna.Peran IdPeranNavigation { get; set; }
    }
}
