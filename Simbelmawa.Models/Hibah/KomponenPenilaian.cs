using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class KomponenPenilaian
    {
        public KomponenPenilaian()
        {
            HasilPenilaian = new HashSet<HasilPenilaian>();
        }

        [Key]
        public int IdKomponenPenilaian { get; set; }
        public int? IdTahapanKegiatanSkim { get; set; }
        public short NoUrut { get; set; }
        public string KriteriaPenilaian { get; set; }
        public string Keterangan { get; set; }
        public short? Bobot { get; set; }
        public string Edisi { get; set; }
        public char? KdStsAktif { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public decimal NilaiNormalisasi { get; set; }
        public int? NoUrutAlias { get; set; }

        public virtual TahapanKegiatanSkim IdTahapanKegiatanSkimNavigation { get; set; }
        public virtual ICollection<HasilPenilaian> HasilPenilaian { get; set; }
    }
}
