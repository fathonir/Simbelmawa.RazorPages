using System;
using Microsoft.AspNetCore.Identity;
using Simbelmawa.Models.PDPT;
using Simbelmawa.Models.Pengguna;

namespace Simbelmawa.Identity
{
    public class SimbelmawaUser : IdentityUser<Guid>
    {
        public virtual IdentitasPengguna IdentitasPengguna { get; set; }
        public virtual Personal Personal { get; set; }
    }
}