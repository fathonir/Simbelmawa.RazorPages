using System;

namespace Simbelmawa.Models.Hibah
{
    public partial class HasilAlasanPenolakan
    {
        public Guid IdPlottingReviewer { get; set; }
        public Guid IdAlasanPenolakan { get; set; }
        public DateTime TglData { get; set; }
        public DateTime TglCreated { get; set; }
        public DateTime TglUpdated { get; set; }
    }
}
