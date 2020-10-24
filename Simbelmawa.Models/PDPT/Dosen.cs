using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class Dosen
    {
        public Dosen()
        {
            AtributUsulan = new HashSet<Hibah.AtributUsulan>();
        }

        [Key]
        public string Nidn { get; set; }
        public string Golongan { get; set; }
        public string Pangkat { get; set; }
        public string KodePerguruanTinggi { get; set; }
        public Guid? IdProgramStudi { get; set; }
        public Guid? IdFakultas { get; set; }
        public Guid? IdJurusan { get; set; }
        public char? KodeStatusAktif { get; set; }
        public char? KodeJenjangPendidikanProgramStudi { get; set; }
        public Guid? IdPersonal { get; set; }
        public int? KodeJenjangPendidikanTertinggi { get; set; }
        public string NoSertifikasiDosen { get; set; }
        public int? KodeJabatanAkademik { get; set; }
        public string JabatanStruktural { get; set; }
        public string NoPegawai { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public Guid? IdPdpt { get; set; }

        public virtual Personal IdPersonalNavigation { get; set; }
        public virtual ProgramStudi IdProgramStudiNavigation { get; set; }
        public virtual JenjangPendidikan KodeJenjangPendidikanTertinggiNavigation { get; set; }
        public virtual PerguruanTinggi KodePerguruanTinggiNavigation { get; set; }
        public virtual ICollection<Hibah.AtributUsulan> AtributUsulan { get; set; }
    }
}
