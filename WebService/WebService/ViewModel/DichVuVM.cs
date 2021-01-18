using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.ViewModel
{
    public class DichVuVM
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public string MoTa { get; set; }
        public double? GiaDV { get; set; }
        public int? TrangThai { get; set; }
        public string Anh { get; set; }
    }
}