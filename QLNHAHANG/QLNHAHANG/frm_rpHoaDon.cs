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
    public partial class frm_rpHoaDon : Form
    {
        HoaDon_BLL_DAL hd = new HoaDon_BLL_DAL();
        string maHD;
        public frm_rpHoaDon(string mahd)
        {
            InitializeComponent();
            maHD = mahd;
        }
        private void frm_rpHoaDon_Load(object sender, EventArgs e)
        {
            rpHoaDon rp = new rpHoaDon();
            crystalReportViewer1.ReportSource = rp;
            rp.SetParameterValue("LocMaHD", maHD);
            rp.SetDatabaseLogon("sa", "sa2012", "DESKTOP-HHM5LAU", "QL_NHAHANG");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }
    }
}
