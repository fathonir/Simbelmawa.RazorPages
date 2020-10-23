using System;

namespace Simbelmawa.Models.PDPT
{
    public partial class KopertisPerguruanTinggi
    {
        public string KodeKopertis { get; set; }
        public Guid IdInstitusi { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
    }
}
