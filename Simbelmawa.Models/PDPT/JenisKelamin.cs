using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.PDPT
{
    public partial class JenisKelamin
    {
        public JenisKelamin()
        {
            Personal = new HashSet<Personal>();
        }

        [Key]
        public char KodeJenisKelamin { get; set; }
        public string JenisKelamin1 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }

        public virtual ICollection<Personal> Personal { get; set; }
    }
}
