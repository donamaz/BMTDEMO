using System;
using System.Collections.Generic;

namespace DEMO1.Models
{
    public partial class Menu
    {
        public int MaMenu { get; set; }
        public string TenMenu { get; set; } = null!;
        public bool TrangThai { get; set; }
    }
}
