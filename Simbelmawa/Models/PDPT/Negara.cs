using System;

namespace Simbelmawa.Models.PDPT
{
    public partial class Negara
    {
        public string KodeNegara { get; set; }
        public string NamaNegara { get; set; }
        public string KodeAlpha2 { get; set; }
        public string KodeAlpha3 { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
    }
}
