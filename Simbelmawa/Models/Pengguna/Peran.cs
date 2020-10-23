using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Simbelmawa.Models.Pengguna
{
    public partial class Peran : IdentityRole<int>
    {
        public const int ManajemenPT = 5;
        
        public Peran()
        {
            PeranOperator = new HashSet<PeranOperator>();
            PeranPengguna = new HashSet<PeranPengguna>();
            SubBagianBelmawa = new HashSet<Messaging.SubBagianBelmawa>();
            RunningTextPeran = new HashSet<News.RunningTextPeran>();
        }

        [Key]
        public int IdPeran { get => base.Id; set => base.Id = value; }
        public string NamaPeran { get => base.Name; set => base.Name = value; }
        public string Keterangan { get; set; }
        public string KdKelompokPeran { get; set; }
        public char KdStsAktif { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual KelompokPeran KdKelompokPeranNavigation { get; set; }
        public virtual ICollection<PeranOperator> PeranOperator { get; set; }
        public virtual ICollection<PeranPengguna> PeranPengguna { get; set; }
        public virtual ICollection<Messaging.SubBagianBelmawa> SubBagianBelmawa { get; set; }
        public virtual ICollection<News.RunningTextPeran> RunningTextPeran { get; set; }
    }
}
