using System;
using System.Collections.Generic;

namespace DemoSQL.Models
{
    public partial class Monhoc
    {
        public Monhoc()
        {
            Ketquas = new HashSet<Ketqua>();
        }

        public string Mamh { get; set; } = null!;
        public string? Tenmh { get; set; }
        public int? Sotiet { get; set; }

        public virtual ICollection<Ketqua> Ketquas { get; set; }
    }
}
