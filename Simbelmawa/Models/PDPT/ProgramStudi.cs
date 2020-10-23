using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class ProgramStudi
    {
        public ProgramStudi()
        {
            Dosen = new HashSet<Dosen>();
            Mahasiswa = new HashSet<Mahasiswa>();
        }

        [Key]
        public Guid IdProgramStudi { get; set; }
        public string KodeProgramStudi { get; set; }
        public string KodePerguruanTinggi { get; set; }
        public string NamaProgramStudi { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public char KodeStatusAktif { get; set; }
        public Guid? IdPdpt { get; set; }

        public virtual PerguruanTinggi KodePerguruanTinggiNavigation { get; set; }
        public virtual ICollection<Dosen> Dosen { get; set; }
        public virtual ICollection<Mahasiswa> Mahasiswa { get; set; }
    }
}
