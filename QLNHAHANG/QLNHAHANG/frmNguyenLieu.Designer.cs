﻿
namespace QLNHAHANG
{
    partial class frmNguyenLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguyenLieu));
            this.cboLoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgrv_HienThiNguyenLieu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnThem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaNguyenLieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TenNguyenLieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbo_TenLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbTen = new System.Windows.Forms.GroupBox();
            this.grbMa = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_HSD = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_DonVi = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_SoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRP = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_HienThiNguyenLieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbTen.SuspendLayout();
            this.grbMa.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboLoc
            // 
            this.cboLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoc.BackColor = System.Drawing.Color.Transparent;
            this.cboLoc.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboLoc.BorderRadius = 4;
            this.cboLoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoc.FillColor = System.Drawing.SystemColors.Control;
            this.cboLoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoc.FocusedState.Parent = this.cboLoc;
            this.cboLoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoc.HoverState.Parent = this.cboLoc;
            this.cboLoc.ItemHeight = 20;
            this.cboLoc.Items.AddRange(new object[] {
            "Tất cả",
            "Hàng hết hạn sử dụng",
            "Hàng đã hết trong kho"});
            this.cboLoc.ItemsAppearance.Parent = this.cboLoc;
            this.cboLoc.Location = new System.Drawing.Point(608, 5);
            this.cboLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.ShadowDecoration.Parent = this.cboLoc;
            this.cboLoc.Size = new System.Drawing.Size(311, 26);
            this.cboLoc.TabIndex = 1;
            this.cboLoc.SelectedIndexChanged += new System.EventHandler(this.cboLoc_SelectedIndexChanged);
            // 
            // dgrv_HienThiNguyenLieu
            // 
            this.dgrv_HienThiNguyenLieu.AllowUserToAddRows = false;
            this.dgrv_HienThiNguyenLieu.AllowUserToDeleteRows = false;
            this.dgrv_HienThiNguyenLieu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgrv_HienThiNguyenLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrv_HienThiNguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrv_HienThiNguyenLieu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgrv_HienThiNguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrv_HienThiNguyenLieu.CausesValidation = false;
            this.dgrv_HienThiNguyenLieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrv_HienThiNguyenLieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrv_HienThiNguyenLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrv_HienThiNguyenLieu.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrv_HienThiNguyenLieu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrv_HienThiNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrv_HienThiNguyenLieu.EnableHeadersVisualStyles = false;
            this.dgrv_HienThiNguyenLieu.GridColor = System.Drawing.SystemColors.Control;
            this.dgrv_HienThiNguyenLieu.Location = new System.Drawing.Point(0, 44);
            this.dgrv_HienThiNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgrv_HienThiNguyenLieu.Name = "dgrv_HienThiNguyenLieu";
            this.dgrv_HienThiNguyenLieu.ReadOnly = true;
            this.dgrv_HienThiNguyenLieu.RowHeadersVisible = false;
            this.dgrv_HienThiNguyenLieu.RowHeadersWidth = 51;
            this.dgrv_HienThiNguyenLieu.RowTemplate.Height = 24;
            this.dgrv_HienThiNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrv_HienThiNguyenLieu.Size = new System.Drawing.Size(940, 121);
            this.dgrv_HienThiNguyenLieu.TabIndex = 10;
            this.dgrv_HienThiNguyenLieu.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.dgrv_HienThiNguyenLieu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgrv_HienThiNguyenLieu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.HeaderStyle.Height = 40;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.ReadOnly = true;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.RowsStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgrv_HienThiNguyenLieu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgrv_HienThiNguyenLieu.ThemeStyle.RowsStyle.Height = 24;
            this.dgrv_HienThiNguyenLieu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgrv_HienThiNguyenLieu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgrv_HienThiNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_HienThiNguyenLieu_CellClick);
            this.dgrv_HienThiNguyenLieu.SelectionChanged += new System.EventHandler(this.dgrv_HienThiNguyenLieu_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaButton1);
            this.panel1.Controls.Add(this.cboLoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 44);
            this.panel1.TabIndex = 3;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(459, 4);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(142, 30);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Lọc dữ liệu";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.dgrv_HienThiNguyenLieu);
            this.gunaPanel2.Controls.Add(this.panel1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(3, 301);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(940, 165);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(55, 14);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(137, 30);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Nguyên liệu";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.btnThem);
            this.gunaPanel1.Controls.Add(this.txtTimKiem);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(940, 62);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Animated = true;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(889, 14);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Enabled = true;
            this.btnThem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnThem.Size = new System.Drawing.Size(44, 42);
            this.btnThem.TabIndex = 36;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BorderRadius = 10;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FillColor = System.Drawing.SystemColors.Control;
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.IconRight = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.IconRight")));
            this.txtTimKiem.IconRightSize = new System.Drawing.Size(22, 22);
            this.txtTimKiem.Location = new System.Drawing.Point(208, 10);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập thông tin nguyên liệu tìm kiếm ...";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(644, 43);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txt_MaNguyenLieu
            // 
            this.txt_MaNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_MaNguyenLieu.BackColor = System.Drawing.Color.Transparent;
            this.txt_MaNguyenLieu.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_MaNguyenLieu.BorderRadius = 3;
            this.txt_MaNguyenLieu.BorderThickness = 0;
            this.txt_MaNguyenLieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNguyenLieu.DefaultText = "";
            this.txt_MaNguyenLieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaNguyenLieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaNguyenLieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNguyenLieu.DisabledState.Parent = this.txt_MaNguyenLieu;
            this.txt_MaNguyenLieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNguyenLieu.FillColor = System.Drawing.SystemColors.Control;
            this.txt_MaNguyenLieu.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_MaNguyenLieu.FocusedState.Parent = this.txt_MaNguyenLieu;
            this.txt_MaNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_MaNguyenLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txt_MaNguyenLieu.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_MaNguyenLieu.HoverState.Parent = this.txt_MaNguyenLieu;
            this.txt_MaNguyenLieu.Location = new System.Drawing.Point(7, 22);
            this.txt_MaNguyenLieu.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.txt_MaNguyenLieu.Name = "txt_MaNguyenLieu";
            this.txt_MaNguyenLieu.PasswordChar = '\0';
            this.txt_MaNguyenLieu.PlaceholderText = "Mã nguyên liệu";
            this.txt_MaNguyenLieu.SelectedText = "";
            this.txt_MaNguyenLieu.ShadowDecoration.Parent = this.txt_MaNguyenLieu;
            this.txt_MaNguyenLieu.Size = new System.Drawing.Size(248, 27);
            this.txt_MaNguyenLieu.TabIndex = 0;
            // 
            // txt_TenNguyenLieu
            // 
            this.txt_TenNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TenNguyenLieu.BackColor = System.Drawing.Color.Transparent;
            this.txt_TenNguyenLieu.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_TenNguyenLieu.BorderRadius = 3;
            this.txt_TenNguyenLieu.BorderThickness = 0;
            this.txt_TenNguyenLieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenNguyenLieu.DefaultText = "";
            this.txt_TenNguyenLieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenNguyenLieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenNguyenLieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenNguyenLieu.DisabledState.Parent = this.txt_TenNguyenLieu;
            this.txt_TenNguyenLieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenNguyenLieu.FillColor = System.Drawing.SystemColors.Control;
            this.txt_TenNguyenLieu.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_TenNguyenLieu.FocusedState.Parent = this.txt_TenNguyenLieu;
            this.txt_TenNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_TenNguyenLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txt_TenNguyenLieu.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_TenNguyenLieu.HoverState.Parent = this.txt_TenNguyenLieu;
            this.txt_TenNguyenLieu.Location = new System.Drawing.Point(7, 22);
            this.txt_TenNguyenLieu.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.txt_TenNguyenLieu.Name = "txt_TenNguyenLieu";
            this.txt_TenNguyenLieu.PasswordChar = '\0';
            this.txt_TenNguyenLieu.PlaceholderText = "Tên nguyên liệu";
            this.txt_TenNguyenLieu.SelectedText = "";
            this.txt_TenNguyenLieu.ShadowDecoration.Parent = this.txt_TenNguyenLieu;
            this.txt_TenNguyenLieu.Size = new System.Drawing.Size(256, 27);
            this.txt_TenNguyenLieu.TabIndex = 0;
            // 
            // cbo_TenLoai
            // 
            this.cbo_TenLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_TenLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbo_TenLoai.BorderColor = System.Drawing.SystemColors.Control;
            this.cbo_TenLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_TenLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TenLoai.FillColor = System.Drawing.SystemColors.Control;
            this.cbo_TenLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_TenLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_TenLoai.FocusedState.Parent = this.cbo_TenLoai;
            this.cbo_TenLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_TenLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_TenLoai.HoverState.Parent = this.cbo_TenLoai;
            this.cbo_TenLoai.ItemHeight = 20;
            this.cbo_TenLoai.ItemsAppearance.Parent = this.cbo_TenLoai;
            this.cbo_TenLoai.Location = new System.Drawing.Point(7, 21);
            this.cbo_TenLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_TenLoai.Name = "cbo_TenLoai";
            this.cbo_TenLoai.ShadowDecoration.Parent = this.cbo_TenLoai;
            this.cbo_TenLoai.Size = new System.Drawing.Size(250, 26);
            this.cbo_TenLoai.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.grbTen, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.grbMa, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(826, 62);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_TenLoai);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(557, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(264, 53);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại nguyên liệu";
            // 
            // grbTen
            // 
            this.grbTen.Controls.Add(this.txt_TenNguyenLieu);
            this.grbTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTen.Location = new System.Drawing.Point(277, 4);
            this.grbTen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.grbTen.Name = "grbTen";
            this.grbTen.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTen.Size = new System.Drawing.Size(270, 53);
            this.grbTen.TabIndex = 11;
            this.grbTen.TabStop = false;
            this.grbTen.Text = "Tên nguyên liệu";
            // 
            // grbMa
            // 
            this.grbMa.Controls.Add(this.txt_MaNguyenLieu);
            this.grbMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMa.Location = new System.Drawing.Point(5, 4);
            this.grbMa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.grbMa.Name = "grbMa";
            this.grbMa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMa.Size = new System.Drawing.Size(262, 53);
            this.grbMa.TabIndex = 10;
            this.grbMa.TabStop = false;
            this.grbMa.Text = "Mã nguyên liệu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_HSD);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(5, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(262, 53);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hạn sử dụng";
            // 
            // txt_HSD
            // 
            this.txt_HSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_HSD.BackColor = System.Drawing.Color.Transparent;
            this.txt_HSD.BaseColor = System.Drawing.SystemColors.Control;
            this.txt_HSD.BorderColor = System.Drawing.Color.Transparent;
            this.txt_HSD.CustomFormat = "dd/MM/yyyy";
            this.txt_HSD.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_HSD.FocusedColor = System.Drawing.Color.Black;
            this.txt_HSD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HSD.ForeColor = System.Drawing.Color.Black;
            this.txt_HSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_HSD.Location = new System.Drawing.Point(7, 20);
            this.txt_HSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HSD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_HSD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_HSD.Name = "txt_HSD";
            this.txt_HSD.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.txt_HSD.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.txt_HSD.OnHoverForeColor = System.Drawing.Color.Black;
            this.txt_HSD.OnPressedColor = System.Drawing.Color.Empty;
            this.txt_HSD.Size = new System.Drawing.Size(248, 26);
            this.txt_HSD.TabIndex = 2;
            this.txt_HSD.Text = "12/11/2020";
            this.txt_HSD.Value = new System.DateTime(2020, 11, 12, 0, 0, 0, 0);
            // 
            // txt_DonVi
            // 
            this.txt_DonVi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DonVi.BackColor = System.Drawing.Color.Transparent;
            this.txt_DonVi.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_DonVi.BorderRadius = 3;
            this.txt_DonVi.BorderThickness = 0;
            this.txt_DonVi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DonVi.DefaultText = "";
            this.txt_DonVi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DonVi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DonVi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DonVi.DisabledState.Parent = this.txt_DonVi;
            this.txt_DonVi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DonVi.FillColor = System.Drawing.SystemColors.Control;
            this.txt_DonVi.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_DonVi.FocusedState.Parent = this.txt_DonVi;
            this.txt_DonVi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_DonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txt_DonVi.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_DonVi.HoverState.Parent = this.txt_DonVi;
            this.txt_DonVi.Location = new System.Drawing.Point(7, 22);
            this.txt_DonVi.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.txt_DonVi.Name = "txt_DonVi";
            this.txt_DonVi.PasswordChar = '\0';
            this.txt_DonVi.PlaceholderText = "Đơn vị tính";
            this.txt_DonVi.SelectedText = "";
            this.txt_DonVi.ShadowDecoration.Parent = this.txt_DonVi;
            this.txt_DonVi.Size = new System.Drawing.Size(243, 27);
            this.txt_DonVi.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_DonVi);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(277, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(257, 53);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đơn vị tính";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.34811F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.64696F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 74);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(826, 62);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SoLuong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(544, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(277, 53);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lượng";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txt_SoLuong.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_SoLuong.BorderRadius = 3;
            this.txt_SoLuong.BorderThickness = 0;
            this.txt_SoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoLuong.DefaultText = "";
            this.txt_SoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoLuong.DisabledState.Parent = this.txt_SoLuong;
            this.txt_SoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoLuong.FillColor = System.Drawing.SystemColors.Control;
            this.txt_SoLuong.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_SoLuong.FocusedState.Parent = this.txt_SoLuong;
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txt_SoLuong.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_SoLuong.HoverState.Parent = this.txt_SoLuong;
            this.txt_SoLuong.Location = new System.Drawing.Point(7, 22);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.PasswordChar = '\0';
            this.txt_SoLuong.PlaceholderText = "Số lượng";
            this.txt_SoLuong.SelectedText = "";
            this.txt_SoLuong.ShadowDecoration.Parent = this.txt_SoLuong;
            this.txt_SoLuong.Size = new System.Drawing.Size(262, 27);
            this.txt_SoLuong.TabIndex = 0;
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(24, 82);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(832, 140);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnRP);
            this.guna2Panel1.Controls.Add(this.btnXoa);
            this.guna2Panel1.Controls.Add(this.btnSua);
            this.guna2Panel1.Controls.Add(this.btnLuu);
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel2);
            this.guna2Panel1.Controls.Add(this.gunaPanel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(940, 289);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnRP
            // 
            this.btnRP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRP.Animated = true;
            this.btnRP.CheckedState.Parent = this.btnRP;
            this.btnRP.CustomImages.Parent = this.btnRP;
            this.btnRP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.btnRP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRP.ForeColor = System.Drawing.Color.White;
            this.btnRP.HoverState.Parent = this.btnRP;
            this.btnRP.Image = global::QLNHAHANG.Properties.Resources.ic_report_2;
            this.btnRP.Location = new System.Drawing.Point(889, 229);
            this.btnRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRP.Name = "btnRP";
            this.btnRP.ShadowDecoration.Enabled = true;
            this.btnRP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRP.ShadowDecoration.Parent = this.btnRP;
            this.btnRP.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnRP.Size = new System.Drawing.Size(44, 42);
            this.btnRP.TabIndex = 40;
            this.btnRP.Click += new System.EventHandler(this.btnRP_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Animated = true;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(889, 126);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Enabled = true;
            this.btnXoa.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnXoa.Size = new System.Drawing.Size(44, 42);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Animated = true;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(889, 73);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Enabled = true;
            this.btnSua.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnSua.Size = new System.Drawing.Size(44, 42);
            this.btnSua.TabIndex = 38;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Animated = true;
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(889, 181);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Enabled = true;
            this.btnLuu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnLuu.Size = new System.Drawing.Size(44, 42);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gunaPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(946, 470);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // frmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 470);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNguyenLieu";
            this.Text = "NguyenLieu";
            this.Load += new System.EventHandler(this.frmNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_HienThiNguyenLieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grbTen.ResumeLayout(false);
            this.grbMa.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cboLoc;
        private Guna.UI2.WinForms.Guna2DataGridView dgrv_HienThiNguyenLieu;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaNguyenLieu;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenNguyenLieu;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_TenLoai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbTen;
        private System.Windows.Forms.GroupBox grbMa;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI.WinForms.GunaDateTimePicker txt_HSD;
        private Guna.UI2.WinForms.Guna2TextBox txt_DonVi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2CircleButton btnXoa;
        private Guna.UI2.WinForms.Guna2CircleButton btnSua;
        private Guna.UI2.WinForms.Guna2CircleButton btnLuu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoLuong;
        private Guna.UI2.WinForms.Guna2CircleButton btnRP;
    }
}