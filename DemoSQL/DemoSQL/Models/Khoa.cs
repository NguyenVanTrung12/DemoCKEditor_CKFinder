using System;
using System.Collections.Generic;

namespace DemoSQL.Models
{
    public partial class Khoa
    {
        public Khoa()
        {
            Sinhviens = new HashSet<Sinhvien>();
        }

        public string Makhoa { get; set; } = null!;
        public string? Tenkhoa { get; set; }

        public virtual ICollection<Sinhvien> Sinhviens { get; set; }
    }
}
