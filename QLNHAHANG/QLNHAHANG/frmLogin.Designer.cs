
namespace QLNHAHANG
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.grbTenDangNhap = new System.Windows.Forms.GroupBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbMatKhau = new System.Windows.Forms.GroupBox();
            this.btnShowPass = new Guna.UI.WinForms.GunaButton();
            this.btnHidePass = new Guna.UI.WinForms.GunaButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnLogIn = new Guna.UI.WinForms.GunaGradientButton();
            this.grbTenDangNhap.SuspendLayout();
            this.grbMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTenDangNhap
            // 
            this.grbTenDangNhap.Controls.Add(this.txtUsername);
            this.grbTenDangNhap.Location = new System.Drawing.Point(53, 177);
            this.grbTenDangNhap.Margin = new System.Windows.Forms.Padding(6, 4, 6, 6);
            this.grbTenDangNhap.Name = "grbTenDangNhap";
            this.grbTenDangNhap.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTenDangNhap.Size = new System.Drawing.Size(309, 70);
            this.grbTenDangNhap.TabIndex = 13;
            this.grbTenDangNhap.TabStop = false;
            this.grbTenDangNhap.Text = "Tên đăng nhập";
            this.grbTenDangNhap.Enter += new System.EventHandler(this.grbTenDangNhap_Enter);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.SystemColors.Control;
            this.txtUsername.BorderRadius = 3;
            this.txtUsername.BorderThickness = 0;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(-9, 28);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Tên đăng nhập";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(294, 34);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(350, 13);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(51, 36);
            this.guna2ControlBox1.TabIndex = 12;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "hidden.png");
            this.imgList.Images.SetKeyName(1, "eye.png");
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderRadius = 3;
            this.txtPassword.BorderThickness = 0;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(-8, 28);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(230, 34);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // grbMatKhau
            // 
            this.grbMatKhau.Controls.Add(this.btnShowPass);
            this.grbMatKhau.Controls.Add(this.btnHidePass);
            this.grbMatKhau.Controls.Add(this.txtPassword);
            this.grbMatKhau.Location = new System.Drawing.Point(54, 269);
            this.grbMatKhau.Margin = new System.Windows.Forms.Padding(6, 4, 6, 6);
            this.grbMatKhau.Name = "grbMatKhau";
            this.grbMatKhau.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMatKhau.Size = new System.Drawing.Size(308, 70);
            this.grbMatKhau.TabIndex = 14;
            this.grbMatKhau.TabStop = false;
            this.grbMatKhau.Text = "Mật khẩu";
            this.grbMatKhau.Enter += new System.EventHandler(this.grbMatKhau_Enter);
            // 
            // btnShowPass
            // 
            this.btnShowPass.AnimationHoverSpeed = 0.07F;
            this.btnShowPass.AnimationSpeed = 0.03F;
            this.btnShowPass.BaseColor = System.Drawing.Color.Transparent;
            this.btnShowPass.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowPass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowPass.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPass.ForeColor = System.Drawing.Color.White;
            this.btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            this.btnShowPass.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShowPass.Location = new System.Drawing.Point(258, 24);
            this.btnShowPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnShowPass.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShowPass.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowPass.OnHoverImage = null;
            this.btnShowPass.OnPressedColor = System.Drawing.Color.Black;
            this.btnShowPass.Size = new System.Drawing.Size(44, 38);
            this.btnShowPass.TabIndex = 3;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnHidePass
            // 
            this.btnHidePass.AnimationHoverSpeed = 0.07F;
            this.btnHidePass.AnimationSpeed = 0.03F;
            this.btnHidePass.BaseColor = System.Drawing.Color.Transparent;
            this.btnHidePass.BorderColor = System.Drawing.Color.Transparent;
            this.btnHidePass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHidePass.FocusedColor = System.Drawing.Color.Empty;
            this.btnHidePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHidePass.ForeColor = System.Drawing.Color.White;
            this.btnHidePass.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePass.Image")));
            this.btnHidePass.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHidePass.Location = new System.Drawing.Point(257, 24);
            this.btnHidePass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnHidePass.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHidePass.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHidePass.OnHoverImage = null;
            this.btnHidePass.OnPressedColor = System.Drawing.Color.Black;
            this.btnHidePass.Size = new System.Drawing.Size(44, 38);
            this.btnHidePass.TabIndex = 2;
            this.btnHidePass.Visible = false;
            this.btnHidePass.Click += new System.EventHandler(this.btnHidePass_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(156, 29);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 15;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            this.gunaCirclePictureBox1.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.AnimationHoverSpeed = 0.07F;
            this.btnLogIn.AnimationSpeed = 0.03F;
            this.btnLogIn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(197)))), ((int)(((byte)(203)))));
            this.btnLogIn.BaseColor2 = System.Drawing.Color.MediumTurquoise;
            this.btnLogIn.BorderColor = System.Drawing.Color.Black;
            this.btnLogIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Image = ((System.Drawing.Image)(resources.GetObject("btnLogIn.Image")));
            this.btnLogIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogIn.Location = new System.Drawing.Point(54, 389);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLogIn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLogIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogIn.OnHoverImage = null;
            this.btnLogIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogIn.Size = new System.Drawing.Size(308, 58);
            this.btnLogIn.TabIndex = 12;
            this.btnLogIn.Text = "Đăng nhập";
            this.btnLogIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 498);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.grbTenDangNhap);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.grbMatKhau);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.grbTenDangNhap.ResumeLayout(false);
            this.grbMatKhau.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbTenDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.ImageList imgList;
        private Guna.UI.WinForms.GunaGradientButton btnLogIn;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI.WinForms.GunaButton btnHidePass;
        private System.Windows.Forms.GroupBox grbMatKhau;
        private Guna.UI.WinForms.GunaButton btnShowPass;
    }
}