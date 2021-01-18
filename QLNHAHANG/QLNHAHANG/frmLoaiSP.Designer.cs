
namespace QLNHAHANG
{
    partial class frmLoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSP));
            this.dgrv_HienThiLoaiSP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnThem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaLSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbMa = new System.Windows.Forms.GroupBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.txt_TenLSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.grbTen = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRP = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MALSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_HienThiLoaiSP)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.grbMa.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grbTen.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrv_HienThiLoaiSP
            // 
            this.dgrv_HienThiLoaiSP.AllowUserToAddRows = false;
            this.dgrv_HienThiLoaiSP.AllowUserToDeleteRows = false;
            this.dgrv_HienThiLoaiSP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgrv_HienThiLoaiSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrv_HienThiLoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrv_HienThiLoaiSP.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgrv_HienThiLoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrv_HienThiLoaiSP.CausesValidation = false;
            this.dgrv_HienThiLoaiSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrv_HienThiLoaiSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrv_HienThiLoaiSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrv_HienThiLoaiSP.ColumnHeadersHeight = 40;
            this.dgrv_HienThiLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALSP,
            this.TENLSP});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrv_HienThiLoaiSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrv_HienThiLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrv_HienThiLoaiSP.EnableHeadersVisualStyles = false;
            this.dgrv_HienThiLoaiSP.GridColor = System.Drawing.SystemColors.Control;
            this.dgrv_HienThiLoaiSP.Location = new System.Drawing.Point(0, 0);
            this.dgrv_HienThiLoaiSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgrv_HienThiLoaiSP.Name = "dgrv_HienThiLoaiSP";
            this.dgrv_HienThiLoaiSP.ReadOnly = true;
            this.dgrv_HienThiLoaiSP.RowHeadersVisible = false;
            this.dgrv_HienThiLoaiSP.RowHeadersWidth = 51;
            this.dgrv_HienThiLoaiSP.RowTemplate.Height = 24;
            this.dgrv_HienThiLoaiSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrv_HienThiLoaiSP.Size = new System.Drawing.Size(923, 158);
            this.dgrv_HienThiLoaiSP.TabIndex = 10;
            this.dgrv_HienThiLoaiSP.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgrv_HienThiLoaiSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgrv_HienThiLoaiSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgrv_HienThiLoaiSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgrv_HienThiLoaiSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgrv_HienThiLoaiSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgrv_HienThiLoaiSP.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgrv_HienThiLoaiSP.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.dgrv_HienThiLoaiSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.dgrv_HienThiLoaiSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgrv_HienThiLoaiSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgrv_HienThiLoaiSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgrv_HienThiLoaiSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgrv_HienThiLoaiSP.ThemeStyle.HeaderStyle.Height = 40;
            this.dgrv_HienThiLoaiSP.ThemeStyle.ReadOnly = true;
            this.dgrv_HienThiLoaiSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgrv_HienThiLoaiSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrv_HienThiLoaiSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgrv_HienThiLoaiSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgrv_HienThiLoaiSP.ThemeStyle.RowsStyle.Height = 24;
            this.dgrv_HienThiLoaiSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgrv_HienThiLoaiSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgrv_HienThiLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_HienThiLoaiSP_CellClick);
            this.dgrv_HienThiLoaiSP.SelectionChanged += new System.EventHandler(this.dgrv_HienThiLoaiSP_SelectionChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(19, 14);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(161, 30);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Loại sản phẩm";
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
            this.gunaPanel1.Size = new System.Drawing.Size(923, 62);
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
            this.btnThem.Location = new System.Drawing.Point(871, 14);
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
            this.txtTimKiem.PlaceholderText = "Nhập thông tin loại sản phẩm tìm kiếm ...";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(626, 43);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txt_MaLSP
            // 
            this.txt_MaLSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_MaLSP.BackColor = System.Drawing.Color.Transparent;
            this.txt_MaLSP.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_MaLSP.BorderRadius = 3;
            this.txt_MaLSP.BorderThickness = 0;
            this.txt_MaLSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaLSP.DefaultText = "";
            this.txt_MaLSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaLSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaLSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaLSP.DisabledState.Parent = this.txt_MaLSP;
            this.txt_MaLSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaLSP.FillColor = System.Drawing.SystemColors.Control;
            this.txt_MaLSP.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_MaLSP.FocusedState.Parent = this.txt_MaLSP;
            this.txt_MaLSP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_MaLSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txt_MaLSP.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_MaLSP.HoverState.Parent = this.txt_MaLSP;
            this.txt_MaLSP.Location = new System.Drawing.Point(7, 22);
            this.txt_MaLSP.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.txt_MaLSP.Name = "txt_MaLSP";
            this.txt_MaLSP.PasswordChar = '\0';
            this.txt_MaLSP.PlaceholderText = "Mã loại sản phẩm";
            this.txt_MaLSP.SelectedText = "";
            this.txt_MaLSP.ShadowDecoration.Parent = this.txt_MaLSP;
            this.txt_MaLSP.Size = new System.Drawing.Size(372, 45);
            this.txt_MaLSP.TabIndex = 0;
            // 
            // grbMa
            // 
            this.grbMa.Controls.Add(this.txt_MaLSP);
            this.grbMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMa.Location = new System.Drawing.Point(5, 4);
            this.grbMa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.grbMa.Name = "grbMa";
            this.grbMa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMa.Size = new System.Drawing.Size(387, 85);
            this.grbMa.TabIndex = 10;
            this.grbMa.TabStop = false;
            this.grbMa.Text = "Mã loại sản phẩm";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.dgrv_HienThiLoaiSP);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(3, 276);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(923, 158);
            this.gunaPanel2.TabIndex = 1;
            // 
            // txt_TenLSP
            // 
            this.txt_TenLSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TenLSP.BackColor = System.Drawing.Color.Transparent;
            this.txt_TenLSP.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_TenLSP.BorderRadius = 3;
            this.txt_TenLSP.BorderThickness = 0;
            this.txt_TenLSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenLSP.DefaultText = "";
            this.txt_TenLSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenLSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenLSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenLSP.DisabledState.Parent = this.txt_TenLSP;
            this.txt_TenLSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenLSP.FillColor = System.Drawing.SystemColors.Control;
            this.txt_TenLSP.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_TenLSP.FocusedState.Parent = this.txt_TenLSP;
            this.txt_TenLSP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_TenLSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txt_TenLSP.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txt_TenLSP.HoverState.Parent = this.txt_TenLSP;
            this.txt_TenLSP.Location = new System.Drawing.Point(7, 22);
            this.txt_TenLSP.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.txt_TenLSP.Name = "txt_TenLSP";
            this.txt_TenLSP.PasswordChar = '\0';
            this.txt_TenLSP.PlaceholderText = "Tên loại sản phẩm";
            this.txt_TenLSP.SelectedText = "";
            this.txt_TenLSP.ShadowDecoration.Parent = this.txt_TenLSP;
            this.txt_TenLSP.Size = new System.Drawing.Size(387, 49);
            this.txt_TenLSP.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.Controls.Add(this.grbTen, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.grbMa, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(808, 94);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // grbTen
            // 
            this.grbTen.Controls.Add(this.txt_TenLSP);
            this.grbTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTen.Location = new System.Drawing.Point(402, 4);
            this.grbTen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.grbTen.Name = "grbTen";
            this.grbTen.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTen.Size = new System.Drawing.Size(401, 85);
            this.grbTen.TabIndex = 11;
            this.grbTen.TabStop = false;
            this.grbTen.Text = "Tên loại sản phẩm";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(24, 96);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.59259F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(814, 111);
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
            this.guna2Panel1.Size = new System.Drawing.Size(923, 264);
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
            this.btnRP.Location = new System.Drawing.Point(870, 213);
            this.btnRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRP.Name = "btnRP";
            this.btnRP.ShadowDecoration.Enabled = true;
            this.btnRP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRP.ShadowDecoration.Parent = this.btnRP;
            this.btnRP.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnRP.Size = new System.Drawing.Size(44, 42);
            this.btnRP.TabIndex = 38;
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
            this.btnXoa.Location = new System.Drawing.Point(871, 115);
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
            this.btnSua.Location = new System.Drawing.Point(871, 64);
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
            this.btnLuu.Location = new System.Drawing.Point(871, 165);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 438);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MALSP
            // 
            this.MALSP.DataPropertyName = "MALSP";
            this.MALSP.HeaderText = "Mã loại sản phẩm";
            this.MALSP.MinimumWidth = 6;
            this.MALSP.Name = "MALSP";
            this.MALSP.ReadOnly = true;
            // 
            // TENLSP
            // 
            this.TENLSP.DataPropertyName = "TENLSP";
            this.TENLSP.HeaderText = "Tên loại sản phẩm";
            this.TENLSP.MinimumWidth = 6;
            this.TENLSP.Name = "TENLSP";
            this.TENLSP.ReadOnly = true;
            // 
            // frmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLoaiSP";
            this.Text = "frmLoaiSP";
            this.Load += new System.EventHandler(this.frmLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_HienThiLoaiSP)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.grbMa.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grbTen.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgrv_HienThiLoaiSP;
        private Guna.UI2.WinForms.Guna2CircleButton btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaLSP;
        private System.Windows.Forms.GroupBox grbMa;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenLSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox grbTen;
        private Guna.UI2.WinForms.Guna2CircleButton btnXoa;
        private Guna.UI2.WinForms.Guna2CircleButton btnSua;
        private Guna.UI2.WinForms.Guna2CircleButton btnLuu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLSP;
    }
}