using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.ViewModel
{
    public class SanPhamVM
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string HinhAnh { get; set; }
        public double? GiaBan { get; set; }
        public string TrangThai { get; set; }
        public string MaLSP { get; set; }
    }
}