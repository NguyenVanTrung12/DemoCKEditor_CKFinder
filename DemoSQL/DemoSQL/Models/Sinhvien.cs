using System;
using System.Collections.Generic;

namespace DemoSQL.Models
{
    public partial class Sinhvien
    {
        public Sinhvien()
        {
            Ketquas = new HashSet<Ketqua>();
        }

        public string Masv { get; set; } = null!;
        public string Hosv { get; set; } = null!;
        public string? Tensv { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string? Phai { get; set; }
        public string Makhoa { get; set; } = null!;

        public virtual Khoa MakhoaNavigation { get; set; } = null!;
        public virtual ICollection<Ketqua> Ketquas { get; set; }
    }
}
