using System;

namespace Simbelmawa.Models.News
{
    public partial class BeritaFile
    {
        public Guid IdBeritaFile { get; set; }
        public Guid IdBerita { get; set; }
        public string KdBahasa { get; set; }
        public DateTime? TglPemberitaan { get; set; }
        public string JudulFile { get; set; }
        public string FileBerita { get; set; }
        public string Urutan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public char? KdStatusPublikasi { get; set; }

        public virtual Berita IdBeritaNavigation { get; set; }
    }
}
