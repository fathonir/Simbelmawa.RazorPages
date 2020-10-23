using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class BerkasCatatanHarian
    {
        [Key]
        public Guid IdBerkasCatatanHarian { get; set; }
        public Guid IdCatatanHarian { get; set; }
        public string NamaBerkas { get; set; }
        public string TipeBerkas { get; set; }
        public int? UkuranBerkas { get; set; }
        public DateTime TglUnggah { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual CatatanHarianPelaksanaan IdCatatanHarianNavigation { get; set; }
    }
}
