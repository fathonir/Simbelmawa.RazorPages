using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class KuotaKlaster
    {
        [Key]
        public int IdKuotaKlaster { get; set; }
        public int IdKlaster { get; set; }
        public int IdJenis { get; set; }
        public string ThnPelaksanaanKegiatan { get; set; }
        public int Kuota { get; set; }

        public virtual SkimJenis IdJenisNavigation { get; set; }
        public virtual Klaster IdKlasterNavigation { get; set; }
    }
}
