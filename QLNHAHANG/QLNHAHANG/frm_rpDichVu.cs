﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHAHANG
{
    public partial class frm_rpDichVu : Form
    {
        public frm_rpDichVu()
        {
            InitializeComponent();

        }
        private void frm_rpDichVu_Load(object sender, EventArgs e)
        {
            rpDichVu rp = new rpDichVu();
            rp.SetDatabaseLogon("sa", "sa2012", "DESKTOP-HHM5LAU", "QL_NHAHANG");
            crystalReportViewer1.ReportSource = rp;
            
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }
    }
}
