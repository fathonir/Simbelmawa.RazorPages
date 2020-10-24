using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Hibah
{
    public partial class UsulanKegiatan
    {
        public UsulanKegiatan()
        {
            AtributUsulan = new HashSet<AtributUsulan>();
            BerkasLaporanAkhir = new HashSet<BerkasLaporanAkhir>();
            BerkasLaporanKemajuan = new HashSet<BerkasLaporanKemajuan>();
            BerkasUsulanKegiatan = new HashSet<BerkasUsulanKegiatan>();
            CatatanHarianPelaksanaan = new HashSet<CatatanHarianPelaksanaan>();
            Luaran = new HashSet<Luaran>();
            Personil = new HashSet<Personil>();
            SkoringPimnas = new HashSet<SkoringPimnas>();
            SumberPenulisan = new HashSet<SumberPenulisan>();
            TransaksiKegiatan = new HashSet<TransaksiKegiatan>();
            UsulanDidanai = new HashSet<UsulanDidanai>();
        }

        [Key]
        public Guid IdUsulanKegiatan { get; set; }
        public Guid? IdUsulan { get; set; }
        public string ThnUsulanKegiatan { get; set; }
        public char? KdStsAktif { get; set; }
        public short? UrutanThnUsulanKegiatan { get; set; }
        public string ThnPelaksanaanKegiatan { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual Usulan IdUsulanNavigation { get; set; }
        public virtual ICollection<AtributUsulan> AtributUsulan { get; set; }
        public virtual ICollection<BerkasLaporanAkhir> BerkasLaporanAkhir { get; set; }
        public virtual ICollection<BerkasLaporanKemajuan> BerkasLaporanKemajuan { get; set; }
        public virtual ICollection<BerkasUsulanKegiatan> BerkasUsulanKegiatan { get; set; }
        public virtual ICollection<BiayaUsulan> BiayaUsulan { get; set; }
        public virtual ICollection<CatatanHarianPelaksanaan> CatatanHarianPelaksanaan { get; set; }
        public virtual ICollection<DataTambahanKegiatan> DataTambahanKegiatan { get; set; }
        public virtual ICollection<Luaran> Luaran { get; set; }
        public virtual ICollection<Personil> Personil { get; set; }
        public virtual ICollection<SkoringPimnas> SkoringPimnas { get; set; }
        public virtual ICollection<SumberPenulisan> SumberPenulisan { get; set; }
        public virtual ICollection<TopikUsulan> TopikUsulan { get; set; }
        public virtual ICollection<TransaksiKegiatan> TransaksiKegiatan { get; set; }
        public virtual ICollection<UsulanDidanai> UsulanDidanai { get; set; }
        public virtual ICollection<UsulanPimnas> UsulanPimnas { get; set; }
    }
}
