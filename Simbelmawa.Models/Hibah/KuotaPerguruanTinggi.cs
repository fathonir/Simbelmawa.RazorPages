using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class KuotaPerguruanTinggi
    {
        [Key]
        public int IdKuotaPerguruanTinggi { get; set; }
        public string KodePerguruanTinggi { get; set; }
        public string ThnPelaksanaanKegiatan { get; set; }
        public int IdKlaster { get; set; }

        public virtual Klaster IdKlasterNavigation { get; set; }
        public virtual PDPT.PerguruanTinggi KodePerguruanTinggiNavigation { get; set; }
    }
}
