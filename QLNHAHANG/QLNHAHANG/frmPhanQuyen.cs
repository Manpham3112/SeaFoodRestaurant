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
    public partial class frmPhanQuyen : Form
    {
        NhanVien_BLL_DAL qlns = new NhanVien_BLL_DAL();
        Login_BLL_DAL login = new Login_BLL_DAL();
        List<PHANQUYEN> lstPQ;
        List<MANHINH> lstMH;
        NHANVIEN nv;
        public frmPhanQuyen()
        {
            InitializeComponent();
        }
        private void trangthaiBD()
        {
            grbten.Enabled = false;
            grbma.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            grdNhom.Enabled = true;
            loadGrdViewNhom();

        }
        private void loadGrdViewNhom()
        {
            grdNhom.DataSource = qlns.layNhomNQ();
        }
        private void txtTenNhom_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            loadGrdViewNhom();
            setHeaderMANHINH();
            trangthaiBD();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private List<PHANQUYEN> layPQ()
        {
            List<PHANQUYEN> lst = new List<PHANQUYEN>();
            foreach (DataGridViewRow item in gvManHinh.Rows)
            {
                PHANQUYEN pq = new PHANQUYEN()
                {
                    MAMH = item.Cells[1].Value.ToString(),
                    MANQ = txtMaNhom.Text,
                };
                if (item.Cells[2].Value.ToString() == "True")
                {
                    pq.COQUYEN = true;
                }
                else
                    pq.COQUYEN = false;

                lst.Add(pq);
            }
            return lst;


        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            NHOMQUYEN nq = new NHOMQUYEN()
            {
                MANQ = txtMaNhom.Text,
                TENNQ = txtTenNhom.Text
            };
            lstPQ = layPQ();
            if (btnThem.Enabled == true)
            {
                if (qlns.themNhomNQ(nq, lstPQ))
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                if (qlns.suaNhomNQ(nq, lstPQ))
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            qlns.submitChange();
            trangthaiBD();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            frmPhanQuyen_Load(sender, e);
        }

        private void grdNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int r = e.RowIndex;
            if (r < 0)
                return;
            txtMaNhom.Text = grdNhom.Rows[r].Cells[0].Value.ToString();
            txtTenNhom.Text = grdNhom.Rows[r].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            grdNhom.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtTenNhom.Text = "";

            txtMaNhom.Text = "NQ" + grdNhom.Rows.Count;
            grbma.Enabled = false;
            grbten.Enabled = true;
            btnLuu.Enabled = true;
            lstPQ = new List<PHANQUYEN>();

            foreach (MANHINH item in qlns.layMH())
            {
                PHANQUYEN newqp = new PHANQUYEN()
                {
                    MANQ = txtMaNhom.Text,
                    MAMH = item.MAMH,
                    COQUYEN = false,
                    TENMH = item.TENMH
                };
                lstPQ.Add(newqp);
            }

            gvManHinh.DataSource = lstPQ;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grdNhom.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            grbma.Enabled = false;
            grbten.Enabled = true;

            btnLuu.Enabled = true;
            lstPQ = layPQ();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (grdNhom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhóm cần xóa");
            }
            else
            {
                DialogResult r = new DialogResult();
                r = MessageBox.Show("Bạn có muốn xóa nhóm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {

                    foreach (DataGridViewRow nhom in grdNhom.SelectedRows)
                    {
                        if (qlns.xoaNhomNQ(nhom.Cells[0].Value.ToString()))
                        {
                            MessageBox.Show("Xóa nhóm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhóm thất bại");
                        }
                    }
                }
                txtMaNhom.Text = txtTenNhom.Text = string.Empty;
                trangthaiBD();
            }
            frmPhanQuyen_Load(sender, e);
        }

        private void grdNhom_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in grdNhom.SelectedRows)
            {
                gvManHinh.DataSource = qlns.layMH(item.Cells[0].Value.ToString().Trim());
                txtMaNhom.Text = item.Cells[0].Value.ToString();
                txtTenNhom.Text = item.Cells[1].Value.ToString();
            }
        }
        public void setHeaderMANHINH()
        {
            //    gvNL_SP.Columns["MASP"].HeaderText = "Mã sản phẩm";
            //    gvNL_SP.Columns["MALSP"].Visible = true;
            //    gvSanPham.Columns["TENLSP"].Visible = false;
            gvManHinh.Columns["MANQ"].Visible = false;
            gvManHinh.Columns["MAMH"].Visible = false;
            gvManHinh.Columns["MANHINH"].Visible = false;
            gvManHinh.Columns["NHOMQUYEN"].Visible = false;

        }

    }
}
