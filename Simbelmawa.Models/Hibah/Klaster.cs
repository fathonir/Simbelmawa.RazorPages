using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class Klaster
    {
        public Klaster()
        {
            KuotaKlaster = new HashSet<KuotaKlaster>();
            KuotaPerguruanTinggi = new HashSet<KuotaPerguruanTinggi>();
        }

        [Key]
        public int IdKlaster { get; set; }
        public string Klaster1 { get; set; }
        public string KlasterAlias { get; set; }

        public virtual ICollection<KuotaKlaster> KuotaKlaster { get; set; }
        public virtual ICollection<KuotaPerguruanTinggi> KuotaPerguruanTinggi { get; set; }
    }
}
