using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class PerguruanTinggi
    {
        public PerguruanTinggi()
        {
            Dosen = new HashSet<Dosen>();
            Mahasiswa = new HashSet<Mahasiswa>();
            ProgramStudi = new HashSet<ProgramStudi>();
            BerkasBeritaAcara = new HashSet<Hibah.BerkasBeritaAcara>();
            KuotaPerguruanTinggi = new HashSet<Hibah.KuotaPerguruanTinggi>();
            Usulan = new HashSet<Hibah.Usulan>();
        }

        [Key]
        public string KodePerguruanTinggi { get; set; }
        public DateTime? TglAwalBerdiri { get; set; }
        public char? KodeJenisPerguruanTinggi { get; set; }
        public decimal? KodeKategoriPerguruanTinggi { get; set; }
        public Guid IdInstitusi { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual Institusi IdInstitusiNavigation { get; set; }
        public virtual JenisPerguruanTinggi KodeJenisPerguruanTinggiNavigation { get; set; }
        public virtual KategoriPerguruanTinggi KodeKategoriPerguruanTinggiNavigation { get; set; }
        public virtual ICollection<Dosen> Dosen { get; set; }
        public virtual ICollection<Mahasiswa> Mahasiswa { get; set; }
        public virtual ICollection<ProgramStudi> ProgramStudi { get; set; }
        public virtual ICollection<Hibah.BerkasBeritaAcara> BerkasBeritaAcara { get; set; }
        public virtual ICollection<Hibah.KuotaPerguruanTinggi> KuotaPerguruanTinggi { get; set; }
        public virtual ICollection<Hibah.Usulan> Usulan { get; set; }
    }
}
