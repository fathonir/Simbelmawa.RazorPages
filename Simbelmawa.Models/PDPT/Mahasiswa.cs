using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class Mahasiswa
    {
        [Key]
        public Guid IdPersonal { get; set; }
        public string KodePerguruanTinggi { get; set; }
        public string NomorMahasiswa { get; set; }
        public string TahunMasuk { get; set; }
        public char? KodeSemesterMasuk { get; set; }
        public char? KodeStsMasuk { get; set; }
        public decimal? KodeJenjangPendidikan { get; set; }
        public Guid? IdProgramStudi { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public Guid? IdPdpt { get; set; }

        public virtual Personal IdPersonalNavigation { get; set; }
        public virtual ProgramStudi IdProgramStudiNavigation { get; set; }
        public virtual PerguruanTinggi KodePerguruanTinggiNavigation { get; set; }
    }
}
