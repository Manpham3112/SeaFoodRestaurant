using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clb_QLNHAHANG
{
    public partial class usSanPham : UserControl
    {
        Boolean check = true;
        public usSanPham()
        {
            InitializeComponent();
        }
        public void setValueDV(int gia, string path, string ten)
        {
            lbgia.Text = gia.ToString() ;
            try
            {
                this.pictureBox1.Image = Image.FromFile(path);
            }
            catch
            {
                this.pictureBox1.Image = Image.FromFile("../../img/img_sanpham/" + "no-image.jpg");
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pnLine.Click += pnLine_Click;



            lbTenSanPham.Text = ten;
        }

        public void setValueSP(int gia, string path, string ten)
        {
            lbgia.Text = gia.ToString();
            try
            {
                this.pictureBox1.LoadAsync(path);
            }
            catch
            {
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pnLine.Click += pnLine_Click;



            lbTenSanPham.Text = ten;
        }

        public void setEventForALL()
        {
            foreach (Control item in pnMain.Controls)
            {
                item.Click += lbgia_Click;
            }
            pnLine.Click += pnLine_Click;
        }
        void pnLine_Click(object sender, EventArgs e)
        {
            //  btnchon.Visible = false;
            pnLine.Visible = false;
            check = false;
        }
        void lbgia_Click(object sender, EventArgs e)
        {
            if (pnLine.Visible == false)
            {
                //btnchon.Visible = true;
                pnLine.Visible = true;
                check = false;
            }
            else
            {
                //btnchon.Visible = false;
                pnLine.Visible = false;
                check = true;
            }

        }
        
    }
}
