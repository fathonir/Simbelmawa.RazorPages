using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Simbelmawa.Models.Pengguna;

namespace Simbelmawa.Models.PDPT
{
    public partial class Institusi
    {
        public Institusi()
        {
            KlasterPerguruanTinggi = new HashSet<KlasterPerguruanTinggi>();
            PerguruanTinggi = new HashSet<PerguruanTinggi>();
            Personal = new HashSet<Personal>();
            IdentitasPengguna = new HashSet<IdentitasPengguna>();
            PenugasanReviewer = new HashSet<Hibah.PenugasanReviewer>();
            UsulanDidanai = new HashSet<Hibah.UsulanDidanai>();
        }
        
        [Key]
        public Guid IdInstitusi { get; set; }
        public char KdJenisInstitusi { get; set; }
        public string NamaInstitusi { get; set; }
        public string Alamat { get; set; }
        public string KodeKota { get; set; }
        public string KodePos { get; set; }
        public string Telepon { get; set; }
        public string Fax { get; set; }
        public string Surel { get; set; }
        public string Website { get; set; }
        public char KdStsData { get; set; }
        public Guid? IdPdpt { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime? TglUpdated { get; set; }

        public virtual JenisInstitusi KdJenisInstitusiNavigation { get; set; }
        public virtual Kota KodeKotaNavigation { get; set; }
        public virtual ICollection<KlasterPerguruanTinggi> KlasterPerguruanTinggi { get; set; }
        public virtual ICollection<PerguruanTinggi> PerguruanTinggi { get; set; }
        public virtual ICollection<Personal> Personal { get; set; }
        public virtual ICollection<IdentitasPengguna> IdentitasPengguna { get; set; }
        public virtual ICollection<Hibah.PenugasanReviewer> PenugasanReviewer { get; set; }
        public virtual ICollection<Hibah.UsulanDidanai> UsulanDidanai { get; set; }
    }
}
