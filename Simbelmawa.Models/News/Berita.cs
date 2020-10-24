using System;
using System.Collections.Generic;

namespace Simbelmawa.Models.News
{
    public partial class Berita
    {
        public Berita()
        {
            BeritaFile = new HashSet<BeritaFile>();
        }

        public Guid IdBerita { get; set; }
        public string KdBahasa { get; set; }
        public DateTime TglPemberitaan { get; set; }
        public string Judul { get; set; }
        public string NoSurat { get; set; }
        public DateTime? TglSurat { get; set; }
        public string Ringkasan { get; set; }
        public string IsiBerita { get; set; }
        public DateTime? TglMulaiAktif { get; set; }
        public DateTime? TglBerakhirAktif { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public char? KdStatusPublikasi { get; set; }
        public char? KdStatusFrontpages { get; set; }

        public virtual ICollection<BeritaFile> BeritaFile { get; set; }
    }
}
