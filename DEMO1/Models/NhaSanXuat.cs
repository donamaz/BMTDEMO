using System;
using System.Collections.Generic;

namespace DEMO1.Models
{
    public partial class NhaSanXuat
    {
        public int MaNhaSanXuat { get; set; }
        public string TenNhaSanXuat { get; set; } = null!;
        public string? MoTa { get; set; }
    }
}
