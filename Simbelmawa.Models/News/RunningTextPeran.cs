using System;
using System.ComponentModel.DataAnnotations;

namespace Simbelmawa.Models.News
{
    public partial class RunningTextPeran
    {
        [Key]
        public Guid IdRunningTextPeran { get; set; }
        public int IdPeran { get; set; }
        public Guid[] IdRunningText { get; set; }

        public virtual Pengguna.Peran IdPeranNavigation { get; set; }
    }
}
