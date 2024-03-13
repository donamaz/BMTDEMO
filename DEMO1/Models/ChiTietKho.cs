﻿using System;
using System.Collections.Generic;

namespace DEMO1.Models
{
    public partial class ChiTietKho
    {
        public int MaChiTietKho { get; set; }
        public int? MaKho { get; set; }
        public int? MaSanPham { get; set; }
        public int? SoLuong { get; set; }
        public string? KhayKhe { get; set; }

        public virtual Kho? MaKhoNavigation { get; set; }
        public virtual SanPham? MaSanPhamNavigation { get; set; }
    }
}
