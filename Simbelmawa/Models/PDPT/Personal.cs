using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Simbelmawa.Models.Pengguna;

namespace Simbelmawa.Models.PDPT
{
    public partial class Personal
    {
        public Personal()
        {
            Dosen = new HashSet<Dosen>();
            IdentitasPengguna = new HashSet<IdentitasPengguna>();
            Mahasiswa = new HashSet<Mahasiswa>();
            Pengirim = new HashSet<Messaging.Pengirim>();
            PengirimanUser = new HashSet<PengirimanUser>();
            Personil = new HashSet<Hibah.Personil>();
            UsulanDidanai = new HashSet<Hibah.UsulanDidanai>();
        }

        [Key]
        public Guid IdPersonal { get; set; }
        public string Nama { get; set; }
        public string NomorKtp { get; set; }
        public string GelarAkademikDepan { get; set; }
        public string GelarAkademikBelakang { get; set; }
        public char? KodeJenisKelamin { get; set; }
        public string TempatLahir { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public string Alamat { get; set; }
        public string KodeKota { get; set; }
        public string KodePos { get; set; }
        public string NomorTelepon { get; set; }
        public string NomorHp { get; set; }
        public string Surel { get; set; }
        public Guid? IdInstitusi { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
        public char KodeStatusAktif { get; set; }
        public Guid? IdPdpt { get; set; }

        public virtual Institusi IdInstitusiNavigation { get; set; }
        public virtual JenisKelamin KodeJenisKelaminNavigation { get; set; }
        public virtual Kota KodeKotaNavigation { get; set; }
        public virtual ICollection<Mahasiswa> Mahasiswa { get; set; }
        public virtual ICollection<Dosen> Dosen { get; set; }
        public virtual ICollection<IdentitasPengguna> IdentitasPengguna { get; set; }
        public virtual ICollection<PengirimanUser> PengirimanUser { get; set; }
        public virtual ICollection<Hibah.Personil> Personil { get; set; }
        public virtual ICollection<Hibah.UsulanDidanai> UsulanDidanai { get; set; }
        public virtual ICollection<Messaging.Pengirim> Pengirim { get; set; }
    }
}
