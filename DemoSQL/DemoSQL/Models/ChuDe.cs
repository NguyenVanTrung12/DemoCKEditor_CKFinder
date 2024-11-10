using System;
using System.Collections.Generic;

namespace DemoSQL.Models
{
    public partial class ChuDe
    {
        public ChuDe()
        {
            Maphims = new HashSet<Phim>();
        }

        public string Macd { get; set; } = null!;
        public string Tencd { get; set; } = null!;

        public virtual ICollection<Phim> Maphims { get; set; }
    }
}
