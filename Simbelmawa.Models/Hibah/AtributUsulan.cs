using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class AtributUsulan
    {
        [Key]
        public Guid IdUsulanKegiatan { get; set; }
        public string Jurusan { get; set; }
        public string AlamatRumah { get; set; }
        public string NoTelpRumah { get; set; }
        public string NoHp { get; set; }
        public string Surel { get; set; }
        public string NidnDosenPendamping { get; set; }
        public string JabatanYangMenyetujui { get; set; }
        public string NamaYangMenyetujui { get; set; }
        public string NipYangMenyetujui { get; set; }
        public string JabatanPimpinanPt { get; set; }
        public string NamaPimpinanPt { get; set; }
        public string NipPimpinanPt { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public string KotaUsulan { get; set; }

        public virtual UsulanKegiatan IdUsulanKegiatanNavigation { get; set; }
        public virtual PDPT.Dosen NidnDosenPendampingNavigation { get; set; }
    }
}
