using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class SkimMultiTahun
    {
        [Key]
        public Guid IdSkimMultiTahun { get; set; }
        public int IdSkim { get; set; }
        public short ThnMinimal { get; set; }
        public short ThnMaksimal { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual SkimKegiatan IdSkimNavigation { get; set; }
    }
}
