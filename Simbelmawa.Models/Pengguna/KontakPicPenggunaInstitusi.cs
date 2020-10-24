using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.Pengguna
{
    public partial class KontakPicPenggunaInstitusi
    {
        [Key]
        public Guid IdKontakPicPenggunaInstitusi { get; set; }
        public Guid IdInstitusi { get; set; }
        public char? KdJenisKegiatan { get; set; }
        public int? IdPeran { get; set; }
        public string Surel { get; set; }
        public string Telepon { get; set; }
        public string Fax { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
    }
}
