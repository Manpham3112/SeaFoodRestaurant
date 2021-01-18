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
    public partial class frm_rpLocPhieuNhapKho : Form
    {
        qlCTPhieuNhapKho_BLL_DAL ctpnk = new qlCTPhieuNhapKho_BLL_DAL();
        qlPhieuNhapKho_BLL_DAL pnk = new qlPhieuNhapKho_BLL_DAL();
        string maPNK;
        public frm_rpLocPhieuNhapKho(string mapnk)
        {
            InitializeComponent();
            maPNK = mapnk;
        }

        private void frm_rpLocPhieuNhapKho_Load(object sender, EventArgs e)
        {
            rpLocNhapKho rp = new rpLocNhapKho();
            crystalReportViewer1.ReportSource = rp;
            rp.SetParameterValue("LocPNK", maPNK);
            rp.SetDatabaseLogon("sa", "sa2012", "DESKTOP-HHM5LAU", "QL_NHAHANG");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }
    }
}
