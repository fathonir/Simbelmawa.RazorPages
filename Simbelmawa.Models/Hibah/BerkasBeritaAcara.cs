using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class BerkasBeritaAcara
    {
        [Key]
        public Guid IdBerkasBeritaAcara { get; set; }
        public string KodePerguruanTinggi { get; set; }
        public int IdJenis { get; set; }
        public string ThnPelaksanaanKegiatan { get; set; }
        public string NamaBerkas { get; set; }
        public string TipeBerkas { get; set; }
        public int UkuranBerkas { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime? TglUpdated { get; set; }

        public virtual SkimJenis IdJenisNavigation { get; set; }
        public virtual PDPT.PerguruanTinggi KodePerguruanTinggiNavigation { get; set; }
    }
}
