
namespace QLNHAHANG
{
    partial class frmPhanQuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            this.grdNhom = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvManHinh = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbma = new System.Windows.Forms.GroupBox();
            this.txtMaNhom = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbten = new System.Windows.Forms.GroupBox();
            this.txtTenNhom = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvManHinh)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbma.SuspendLayout();
            this.grbten.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdNhom
            // 
            this.grdNhom.AllowUserToAddRows = false;
            this.grdNhom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhom.Location = new System.Drawing.Point(3, 3);
            this.grdNhom.MultiSelect = false;
            this.grdNhom.Name = "grdNhom";
            this.grdNhom.RowHeadersWidth = 62;
            this.grdNhom.RowTemplate.Height = 24;
            this.grdNhom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNhom.Size = new System.Drawing.Size(579, 328);
            this.grdNhom.TabIndex = 18;
            this.grdNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNhom_CellClick);
            this.grdNhom.SelectionChanged += new System.EventHandler(this.grdNhom_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvManHinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(589, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 324);
            this.panel1.TabIndex = 15;
            // 
            // gvManHinh
            // 
            this.gvManHinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvManHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvManHinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column3});
            this.gvManHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvManHinh.Location = new System.Drawing.Point(0, 0);
            this.gvManHinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gvManHinh.Name = "gvManHinh";
            this.gvManHinh.RowHeadersWidth = 62;
            this.gvManHinh.Size = new System.Drawing.Size(577, 324);
            this.gvManHinh.TabIndex = 17;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TENMH";
            this.Column5.HeaderText = "Tên Màn Hình";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "COQUYEN";
            this.Column3.HeaderText = "Có quyền";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.grdNhom, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 267);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1170, 334);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.20148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.79852F));
            this.tableLayoutPanel1.Controls.Add(this.grbma, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbten, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.34375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.65625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1077, 256);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // grbma
            // 
            this.grbma.Controls.Add(this.txtMaNhom);
            this.grbma.Location = new System.Drawing.Point(3, 3);
            this.grbma.Name = "grbma";
            this.grbma.Size = new System.Drawing.Size(846, 93);
            this.grbma.TabIndex = 0;
            this.grbma.TabStop = false;
            this.grbma.Text = "Mã";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.BackColor = System.Drawing.Color.Transparent;
            this.txtMaNhom.BorderRadius = 26;
            this.txtMaNhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhom.DefaultText = "";
            this.txtMaNhom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNhom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNhom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhom.DisabledState.Parent = this.txtMaNhom;
            this.txtMaNhom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhom.FocusedState.Parent = this.txtMaNhom;
            this.txtMaNhom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhom.HoverState.Parent = this.txtMaNhom;
            this.txtMaNhom.Location = new System.Drawing.Point(23, 27);
            this.txtMaNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.PasswordChar = '\0';
            this.txtMaNhom.PlaceholderText = "";
            this.txtMaNhom.SelectedText = "";
            this.txtMaNhom.ShadowDecoration.Parent = this.txtMaNhom;
            this.txtMaNhom.Size = new System.Drawing.Size(816, 55);
            this.txtMaNhom.TabIndex = 0;
            // 
            // grbten
            // 
            this.grbten.Controls.Add(this.txtTenNhom);
            this.grbten.Location = new System.Drawing.Point(3, 126);
            this.grbten.Name = "grbten";
            this.grbten.Size = new System.Drawing.Size(846, 91);
            this.grbten.TabIndex = 1;
            this.grbten.TabStop = false;
            this.grbten.Text = "Tên";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.BackColor = System.Drawing.Color.Transparent;
            this.txtTenNhom.BorderRadius = 26;
            this.txtTenNhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhom.DefaultText = "";
            this.txtTenNhom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhom.DisabledState.Parent = this.txtTenNhom;
            this.txtTenNhom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhom.FocusedState.Parent = this.txtTenNhom;
            this.txtTenNhom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhom.HoverState.Parent = this.txtTenNhom;
            this.txtTenNhom.Location = new System.Drawing.Point(23, 20);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.PasswordChar = '\0';
            this.txtTenNhom.PlaceholderText = "";
            this.txtTenNhom.SelectedText = "";
            this.txtTenNhom.ShadowDecoration.Parent = this.txtTenNhom;
            this.txtTenNhom.Size = new System.Drawing.Size(816, 55);
            this.txtTenNhom.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Animated = true;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(1112, 11);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Enabled = true;
            this.btnThem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnThem.Size = new System.Drawing.Size(50, 52);
            this.btnThem.TabIndex = 31;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Animated = true;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(1112, 76);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Enabled = true;
            this.btnSua.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnSua.Size = new System.Drawing.Size(50, 47);
            this.btnSua.TabIndex = 33;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Animated = true;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(1112, 137);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Enabled = true;
            this.btnXoa.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnXoa.Size = new System.Drawing.Size(50, 52);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Animated = true;
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(1112, 203);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Enabled = true;
            this.btnLuu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnLuu.Size = new System.Drawing.Size(50, 52);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhom)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvManHinh)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grbma.ResumeLayout(false);
            this.grbten.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdNhom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvManHinh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grbma;
        private System.Windows.Forms.GroupBox grbten;
        private Guna.UI2.WinForms.Guna2CircleButton btnThem;
        private Guna.UI2.WinForms.Guna2CircleButton btnSua;
        private Guna.UI2.WinForms.Guna2CircleButton btnXoa;
        private Guna.UI2.WinForms.Guna2CircleButton btnLuu;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhom;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
    }
}