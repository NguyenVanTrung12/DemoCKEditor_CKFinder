using System;
using System.Collections.Generic;

namespace DemoSQL.Models
{
    public partial class GiaoPhim
    {
        public int Sttgiao { get; set; }
        public DateTime Ngaygiao { get; set; }
        public string Maphim { get; set; } = null!;
        public int Sobo { get; set; }
        public int? Sotien { get; set; }

        public virtual Phim MaphimNavigation { get; set; } = null!;
    }
}
