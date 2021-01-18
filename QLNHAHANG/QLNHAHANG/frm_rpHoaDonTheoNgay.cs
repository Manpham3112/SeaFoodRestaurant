using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
namespace QLNHAHANG
{
    public partial class frm_rpHoaDonTheoNgay : Form
    {
        HoaDon_BLL_DAL hd = new HoaDon_BLL_DAL();
        string ngayLap;
        public frm_rpHoaDonTheoNgay(string ngaylap)
        {
            InitializeComponent();
            ngayLap = ngaylap;
        }

        private void frm_rpHoaDonTheoNgay_Load(object sender, EventArgs e)
        {
            rpLocHoaDonTheoNgay rp = new rpLocHoaDonTheoNgay();
            crystalReportViewer1.ReportSource = rp;
            rp.SetParameterValue("LocNgayLap", ngayLap);
            rp.SetDatabaseLogon("sa", "sa2012", "DESKTOP-HHM5LAU", "QL_NHAHANG");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }

    }
}
