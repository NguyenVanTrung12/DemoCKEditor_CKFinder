using System;
using System.Collections.Generic;

namespace DemoSQL.Models
{
    public partial class Ketqua
    {
        public string Masv { get; set; } = null!;
        public string Mamh { get; set; } = null!;
        public int? Lanthi { get; set; }
        public int? Diem { get; set; }

        public virtual Monhoc MamhNavigation { get; set; } = null!;
        public virtual Sinhvien MasvNavigation { get; set; } = null!;
    }
}
