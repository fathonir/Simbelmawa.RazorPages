using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Messaging
{
    public partial class BerkasPesan
    {
        [Key]
        public Guid IdBerkasPesan { get; set; }
        public Guid? IdPesan { get; set; }
        public string NamaBerkas { get; set; }
        public string TipeBerkas { get; set; }
        public int? UkuranBerkas { get; set; }
        public DateTime? TglUnggah { get; set; }

        public virtual Pesan IdPesanNavigation { get; set; }
    }
}
