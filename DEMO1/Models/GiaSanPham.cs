using System;
using System.Collections.Generic;

namespace DEMO1.Models
{
    public partial class GiaSanPham
    {
        public int MaGiaSanPham { get; set; }
        public int MaSanPham { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public double? Gia { get; set; }
    }
}
