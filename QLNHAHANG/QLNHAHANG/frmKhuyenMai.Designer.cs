
namespace QLNHAHANG
{
    partial class frmKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhuyenMai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.lbDichVu = new Guna.UI.WinForms.GunaLabel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dtpickNGAYBD = new Guna.UI.WinForms.GunaDateTimePicker();
            this.grbDiaChi = new System.Windows.Forms.GroupBox();
            this.dtpickNGAYKT = new Guna.UI.WinForms.GunaDateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMAKM = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbMa = new System.Windows.Forms.GroupBox();
            this.txtTENKM = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPTKM = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gbTenNhaCungCap = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.NGAYKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHANTRAMKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewKhuyenMai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gunaPanel2.SuspendLayout();
            this.grbDiaChi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grbMa.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gbTenNhaCungCap.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhuyenMai)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.txtTimKiem.Location = new System.Drawing.Point(222, 12);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập thông tin nhà cung cấp tìm kiếm ...";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(878, 54);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
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
            this.btnThem.Location = new System.Drawing.Point(1119, 26);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Enabled = true;
            this.btnThem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnThem.Size = new System.Drawing.Size(50, 52);
            this.btnThem.TabIndex = 30;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.txtTimKiem);
            this.gunaPanel2.Controls.Add(this.lbDichVu);
            this.gunaPanel2.Controls.Add(this.btnThem);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1183, 78);
            this.gunaPanel2.TabIndex = 0;
            // 
            // lbDichVu
            // 
            this.lbDichVu.AutoSize = true;
            this.lbDichVu.Font = new System.Drawing.Font("Segoe UI", 12.8F, System.Drawing.FontStyle.Bold);
            this.lbDichVu.Location = new System.Drawing.Point(27, 18);
            this.lbDichVu.Name = "lbDichVu";
            this.lbDichVu.Size = new System.Drawing.Size(160, 36);
            this.lbDichVu.TabIndex = 0;
            this.lbDichVu.Text = "Khuyến mãi";
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
            this.btnXoa.Location = new System.Drawing.Point(1119, 80);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Enabled = true;
            this.btnXoa.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnXoa.Size = new System.Drawing.Size(50, 52);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(1119, 12);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Enabled = true;
            this.btnSua.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnSua.Size = new System.Drawing.Size(50, 52);
            this.btnSua.TabIndex = 32;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(1119, 148);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Enabled = true;
            this.btnLuu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnLuu.Size = new System.Drawing.Size(50, 52);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dtpickNGAYBD
            // 
            this.dtpickNGAYBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpickNGAYBD.BackColor = System.Drawing.Color.Transparent;
            this.dtpickNGAYBD.BaseColor = System.Drawing.SystemColors.Control;
            this.dtpickNGAYBD.BorderColor = System.Drawing.Color.Transparent;
            this.dtpickNGAYBD.CustomFormat = "dd/MM/yyyy";
            this.dtpickNGAYBD.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpickNGAYBD.FocusedColor = System.Drawing.Color.Black;
            this.dtpickNGAYBD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpickNGAYBD.ForeColor = System.Drawing.Color.Black;
            this.dtpickNGAYBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickNGAYBD.Location = new System.Drawing.Point(8, 28);
            this.dtpickNGAYBD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpickNGAYBD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpickNGAYBD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpickNGAYBD.Name = "dtpickNGAYBD";
            this.dtpickNGAYBD.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.dtpickNGAYBD.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.dtpickNGAYBD.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtpickNGAYBD.OnPressedColor = System.Drawing.Color.Empty;
            this.dtpickNGAYBD.Size = new System.Drawing.Size(491, 32);
            this.dtpickNGAYBD.TabIndex = 4;
            this.dtpickNGAYBD.Text = "03/08/2020";
            this.dtpickNGAYBD.Value = new System.DateTime(2020, 8, 3, 0, 0, 0, 0);
            // 
            // grbDiaChi
            // 
            this.grbDiaChi.Controls.Add(this.dtpickNGAYBD);
            this.grbDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDiaChi.Location = new System.Drawing.Point(6, 2);
            this.grbDiaChi.Margin = new System.Windows.Forms.Padding(6, 2, 6, 6);
            this.grbDiaChi.Name = "grbDiaChi";
            this.grbDiaChi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDiaChi.Size = new System.Drawing.Size(505, 76);
            this.grbDiaChi.TabIndex = 10;
            this.grbDiaChi.TabStop = false;
            this.grbDiaChi.Text = "Ngày bắt đầu";
            // 
            // dtpickNGAYKT
            // 
            this.dtpickNGAYKT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpickNGAYKT.BackColor = System.Drawing.Color.Transparent;
            this.dtpickNGAYKT.BaseColor = System.Drawing.SystemColors.Control;
            this.dtpickNGAYKT.BorderColor = System.Drawing.Color.Transparent;
            this.dtpickNGAYKT.CustomFormat = "dd/MM/yyyy";
            this.dtpickNGAYKT.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpickNGAYKT.FocusedColor = System.Drawing.Color.Black;
            this.dtpickNGAYKT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpickNGAYKT.ForeColor = System.Drawing.Color.Black;
            this.dtpickNGAYKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickNGAYKT.Location = new System.Drawing.Point(7, 28);
            this.dtpickNGAYKT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpickNGAYKT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpickNGAYKT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpickNGAYKT.Name = "dtpickNGAYKT";
            this.dtpickNGAYKT.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.dtpickNGAYKT.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.dtpickNGAYKT.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtpickNGAYKT.OnPressedColor = System.Drawing.Color.Empty;
            this.dtpickNGAYKT.Size = new System.Drawing.Size(520, 32);
            this.dtpickNGAYKT.TabIndex = 5;
            this.dtpickNGAYKT.Text = "03/08/2020";
            this.dtpickNGAYKT.Value = new System.DateTime(2020, 8, 3, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpickNGAYKT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(523, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 2, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(534, 76);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày kết thúc";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.71481F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.28519F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.grbDiaChi, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1063, 84);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtMAKM
            // 
            this.txtMAKM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMAKM.BackColor = System.Drawing.Color.Transparent;
            this.txtMAKM.BorderColor = System.Drawing.SystemColors.Control;
            this.txtMAKM.BorderRadius = 3;
            this.txtMAKM.BorderThickness = 0;
            this.txtMAKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMAKM.DefaultText = "";
            this.txtMAKM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMAKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMAKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMAKM.DisabledState.Parent = this.txtMAKM;
            this.txtMAKM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMAKM.FillColor = System.Drawing.SystemColors.Control;
            this.txtMAKM.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtMAKM.FocusedState.Parent = this.txtMAKM;
            this.txtMAKM.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMAKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtMAKM.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtMAKM.HoverState.Parent = this.txtMAKM;
            this.txtMAKM.Location = new System.Drawing.Point(8, 28);
            this.txtMAKM.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtMAKM.Name = "txtMAKM";
            this.txtMAKM.PasswordChar = '\0';
            this.txtMAKM.PlaceholderText = "Mã khuyến mãi";
            this.txtMAKM.SelectedText = "";
            this.txtMAKM.ShadowDecoration.Parent = this.txtMAKM;
            this.txtMAKM.Size = new System.Drawing.Size(292, 34);
            this.txtMAKM.TabIndex = 0;
            // 
            // grbMa
            // 
            this.grbMa.Controls.Add(this.txtMAKM);
            this.grbMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMa.Location = new System.Drawing.Point(6, 2);
            this.grbMa.Margin = new System.Windows.Forms.Padding(6, 2, 6, 6);
            this.grbMa.Name = "grbMa";
            this.grbMa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbMa.Size = new System.Drawing.Size(306, 75);
            this.grbMa.TabIndex = 9;
            this.grbMa.TabStop = false;
            this.grbMa.Text = "Mã khuyến mãi";
            // 
            // txtTENKM
            // 
            this.txtTENKM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTENKM.BackColor = System.Drawing.Color.Transparent;
            this.txtTENKM.BorderColor = System.Drawing.SystemColors.Control;
            this.txtTENKM.BorderRadius = 3;
            this.txtTENKM.BorderThickness = 0;
            this.txtTENKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTENKM.DefaultText = "";
            this.txtTENKM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTENKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTENKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTENKM.DisabledState.Parent = this.txtTENKM;
            this.txtTENKM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTENKM.FillColor = System.Drawing.SystemColors.Control;
            this.txtTENKM.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtTENKM.FocusedState.Parent = this.txtTENKM;
            this.txtTENKM.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTENKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtTENKM.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtTENKM.HoverState.Parent = this.txtTENKM;
            this.txtTENKM.Location = new System.Drawing.Point(8, 28);
            this.txtTENKM.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtTENKM.Name = "txtTENKM";
            this.txtTENKM.PasswordChar = '\0';
            this.txtTENKM.PlaceholderText = "Tên khuyến mãi";
            this.txtTENKM.SelectedText = "";
            this.txtTENKM.ShadowDecoration.Parent = this.txtTENKM;
            this.txtTENKM.Size = new System.Drawing.Size(396, 34);
            this.txtTENKM.TabIndex = 0;
            // 
            // txtPTKM
            // 
            this.txtPTKM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPTKM.BackColor = System.Drawing.Color.Transparent;
            this.txtPTKM.BorderColor = System.Drawing.SystemColors.Control;
            this.txtPTKM.BorderRadius = 3;
            this.txtPTKM.BorderThickness = 0;
            this.txtPTKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPTKM.DefaultText = "";
            this.txtPTKM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPTKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPTKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPTKM.DisabledState.Parent = this.txtPTKM;
            this.txtPTKM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPTKM.FillColor = System.Drawing.SystemColors.Control;
            this.txtPTKM.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtPTKM.FocusedState.Parent = this.txtPTKM;
            this.txtPTKM.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPTKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtPTKM.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtPTKM.HoverState.Parent = this.txtPTKM;
            this.txtPTKM.Location = new System.Drawing.Point(8, 28);
            this.txtPTKM.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtPTKM.Name = "txtPTKM";
            this.txtPTKM.PasswordChar = '\0';
            this.txtPTKM.PlaceholderText = "Phần trăm khuyến mãi";
            this.txtPTKM.SelectedText = "";
            this.txtPTKM.ShadowDecoration.Parent = this.txtPTKM;
            this.txtPTKM.Size = new System.Drawing.Size(292, 34);
            this.txtPTKM.TabIndex = 0;
            this.txtPTKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPTKM_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPTKM);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(749, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 2, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(308, 75);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phần trăm khuyến mãi";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.gbTenNhaCungCap, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.grbMa, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1063, 83);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // gbTenNhaCungCap
            // 
            this.gbTenNhaCungCap.Controls.Add(this.txtTENKM);
            this.gbTenNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTenNhaCungCap.Location = new System.Drawing.Point(324, 2);
            this.gbTenNhaCungCap.Margin = new System.Windows.Forms.Padding(6, 2, 6, 6);
            this.gbTenNhaCungCap.Name = "gbTenNhaCungCap";
            this.gbTenNhaCungCap.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTenNhaCungCap.Size = new System.Drawing.Size(413, 75);
            this.gbTenNhaCungCap.TabIndex = 11;
            this.gbTenNhaCungCap.TabStop = false;
            this.gbTenNhaCungCap.Text = "Tên khuyến mãi";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 28);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1069, 175);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 230);
            this.panel1.TabIndex = 2;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.panel1);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(3, 2);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1183, 308);
            this.gunaPanel1.TabIndex = 10;
            // 
            // NGAYKT
            // 
            this.NGAYKT.DataPropertyName = "NGAYKT";
            this.NGAYKT.HeaderText = "Ngày kết thúc";
            this.NGAYKT.MinimumWidth = 6;
            this.NGAYKT.Name = "NGAYKT";
            // 
            // NGAYBD
            // 
            this.NGAYBD.DataPropertyName = "NGAYBD";
            this.NGAYBD.HeaderText = "Ngày bắt đầu";
            this.NGAYBD.MinimumWidth = 6;
            this.NGAYBD.Name = "NGAYBD";
            // 
            // PHANTRAMKM
            // 
            this.PHANTRAMKM.DataPropertyName = "PHANTRAMKM";
            this.PHANTRAMKM.HeaderText = "Phần trăm khuyến mãi";
            this.PHANTRAMKM.MinimumWidth = 6;
            this.PHANTRAMKM.Name = "PHANTRAMKM";
            // 
            // TENKM
            // 
            this.TENKM.DataPropertyName = "TENKM";
            this.TENKM.HeaderText = "Tên khuyến mãi";
            this.TENKM.MinimumWidth = 6;
            this.TENKM.Name = "TENKM";
            // 
            // MAKM
            // 
            this.MAKM.DataPropertyName = "MAKM";
            this.MAKM.HeaderText = "Mã khuyến mãi";
            this.MAKM.MinimumWidth = 6;
            this.MAKM.Name = "MAKM";
            // 
            // dataGridViewKhuyenMai
            // 
            this.dataGridViewKhuyenMai.AllowUserToAddRows = false;
            this.dataGridViewKhuyenMai.AllowUserToDeleteRows = false;
            this.dataGridViewKhuyenMai.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewKhuyenMai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKhuyenMai.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKhuyenMai.CausesValidation = false;
            this.dataGridViewKhuyenMai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewKhuyenMai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKhuyenMai.ColumnHeadersHeight = 40;
            this.dataGridViewKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKM,
            this.TENKM,
            this.PHANTRAMKM,
            this.NGAYBD,
            this.NGAYKT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKhuyenMai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKhuyenMai.EnableHeadersVisualStyles = false;
            this.dataGridViewKhuyenMai.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewKhuyenMai.Location = new System.Drawing.Point(3, 314);
            this.dataGridViewKhuyenMai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKhuyenMai.Name = "dataGridViewKhuyenMai";
            this.dataGridViewKhuyenMai.RowHeadersVisible = false;
            this.dataGridViewKhuyenMai.RowHeadersWidth = 51;
            this.dataGridViewKhuyenMai.RowTemplate.Height = 24;
            this.dataGridViewKhuyenMai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhuyenMai.Size = new System.Drawing.Size(1183, 234);
            this.dataGridViewKhuyenMai.TabIndex = 9;
            this.dataGridViewKhuyenMai.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewKhuyenMai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewKhuyenMai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewKhuyenMai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewKhuyenMai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewKhuyenMai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewKhuyenMai.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewKhuyenMai.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewKhuyenMai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Salmon;
            this.dataGridViewKhuyenMai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewKhuyenMai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewKhuyenMai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewKhuyenMai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewKhuyenMai.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewKhuyenMai.ThemeStyle.ReadOnly = false;
            this.dataGridViewKhuyenMai.ThemeStyle.RowsStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewKhuyenMai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewKhuyenMai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewKhuyenMai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewKhuyenMai.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewKhuyenMai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewKhuyenMai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhuyenMai_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewKhuyenMai, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gunaPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1189, 550);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // frmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhuyenMai";
            this.Text = "frmKhuyenMai";
            this.Load += new System.EventHandler(this.frmKhuyenMai_Load);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.grbDiaChi.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grbMa.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gbTenNhaCungCap.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhuyenMai)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2CircleButton btnThem;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaLabel lbDichVu;
        private Guna.UI2.WinForms.Guna2CircleButton btnXoa;
        private Guna.UI2.WinForms.Guna2CircleButton btnSua;
        private Guna.UI2.WinForms.Guna2CircleButton btnLuu;
        private Guna.UI.WinForms.GunaDateTimePicker dtpickNGAYBD;
        private System.Windows.Forms.GroupBox grbDiaChi;
        private Guna.UI.WinForms.GunaDateTimePicker dtpickNGAYKT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2TextBox txtMAKM;
        private System.Windows.Forms.GroupBox grbMa;
        private Guna.UI2.WinForms.Guna2TextBox txtTENKM;
        private Guna.UI2.WinForms.Guna2TextBox txtPTKM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox gbTenNhaCungCap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHANTRAMKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKM;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewKhuyenMai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}