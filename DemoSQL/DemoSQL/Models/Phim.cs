using System;
using System.Collections.Generic;

namespace DemoSQL.Models
{
    public partial class Phim
    {
        public Phim()
        {
            GiaoPhims = new HashSet<GiaoPhim>();
            Macds = new HashSet<ChuDe>();
        }

        public string Maphim { get; set; } = null!;
        public string Tenphim { get; set; } = null!;
        public DateTime NgayPh { get; set; }
        public int Sldia { get; set; }
        public int Dongia { get; set; }

        public virtual ICollection<GiaoPhim> GiaoPhims { get; set; }

        public virtual ICollection<ChuDe> Macds { get; set; }
    }
}
