using System;

namespace Simbelmawa.Models.News
{
    public partial class RunningText
    {
        public Guid IdRunningText { get; set; }
        public DateTime? TglMulaiAktif { get; set; }
        public DateTime? TglBerakhirAktif { get; set; }
        public string ItemRunningText { get; set; }
        public DateTime TglData { get; set; }
    }
}
