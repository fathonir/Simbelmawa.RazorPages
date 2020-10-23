using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class StatusPublish
    {
        [Key]
        public int IdStatusPublish { get; set; }
        public int? IdSkim { get; set; }
        public string ThnUsulanKegiatan { get; set; }
        public string ThnPelaksanaanKegiatan { get; set; }
        public string KdTahapanKegiatan { get; set; }
        public DateTime? TglCreated { get; set; }
        public DateTime? TglUpdated { get; set; }

        public virtual SkimKegiatan IdSkimNavigation { get; set; }
        public virtual TahapanKegiatan KdTahapanKegiatanNavigation { get; set; }
    }
}
