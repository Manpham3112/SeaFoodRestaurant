using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.ViewModel
{
    public class PhieuDatHangVM
    {
        public string MaPDH { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public string MaDV { get; set; }
        public DateTime? NgayLap { get; set; }
    }
}