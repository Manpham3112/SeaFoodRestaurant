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
    public partial class frm_rpOrder : Form
    {
        HoaDon_BLL_DAL hd = new HoaDon_BLL_DAL();
        frmOrder order = new frmOrder();
        string maHD;
        public frm_rpOrder(string mahd)
        {
            InitializeComponent();
            maHD = mahd;
        }

        private void frm_rpOrder_Load(object sender, EventArgs e)
        {
            rpOrder rp = new rpOrder();
            crystalReportViewer1.ReportSource = rp;
            
            rp.SetParameterValue("LocMaHD", maHD);
            rp.SetDatabaseLogon("sa", "sa2012", "DESKTOP-HHM5LAU", "QL_NHAHANG");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }
    }
}
