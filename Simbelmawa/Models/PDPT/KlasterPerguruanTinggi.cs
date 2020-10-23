using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class KlasterPerguruanTinggi
    {
        [Key]
        public Guid IdKlasterPerguruanTinggi { get; set; }
        public Guid IdInstitusi { get; set; }
        public string ThnKlaster { get; set; }
        public char KdKlaster { get; set; }
        public DateTime TglData { get; set; }
        public char KdStatusData { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual Institusi IdInstitusiNavigation { get; set; }
        public virtual Klaster KdKlasterNavigation { get; set; }
    }
}
