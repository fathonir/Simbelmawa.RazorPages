using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class SkimJenis
    {
        public SkimJenis()
        {
            BerkasBeritaAcara = new HashSet<BerkasBeritaAcara>();
            KuotaKlaster = new HashSet<KuotaKlaster>();
            SkimKegiatan = new HashSet<SkimKegiatan>();
        }

        [Key]
        public int IdJenis { get; set; }
        public string NamaJenis { get; set; }

        public virtual ICollection<BerkasBeritaAcara> BerkasBeritaAcara { get; set; }
        public virtual ICollection<KuotaKlaster> KuotaKlaster { get; set; }
        public virtual ICollection<SkimKegiatan> SkimKegiatan { get; set; }
    }
}
