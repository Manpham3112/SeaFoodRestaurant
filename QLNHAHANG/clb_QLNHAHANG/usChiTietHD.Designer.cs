
namespace clb_QLNHAHANG
{
    partial class usChiTietHD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usChiTietHD));
            this.lbTongTien = new Guna.UI.WinForms.GunaLabel();
            this.btnHuy = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnTangGiam = new Guna.UI.WinForms.GunaNumeric();
            this.lbGia = new Guna.UI.WinForms.GunaLabel();
            this.lbTen = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbTongTien.Location = new System.Drawing.Point(264, 35);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(77, 28);
            this.lbTongTien.TabIndex = 13;
            this.lbTongTien.Text = "28,000";
            // 
            // btnHuy
            // 
            this.btnHuy.AnimationHoverSpeed = 0.07F;
            this.btnHuy.AnimationSpeed = 0.03F;
            this.btnHuy.BaseColor = System.Drawing.Color.Empty;
            this.btnHuy.BorderColor = System.Drawing.Color.Empty;
            this.btnHuy.CheckedBaseColor = System.Drawing.Color.Empty;
            this.btnHuy.CheckedBorderColor = System.Drawing.Color.Empty;
            this.btnHuy.CheckedForeColor = System.Drawing.Color.Empty;
            this.btnHuy.CheckedImage = null;
            this.btnHuy.CheckedLineColor = System.Drawing.Color.Empty;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuy.LineColor = System.Drawing.Color.Empty;
            this.btnHuy.Location = new System.Drawing.Point(355, 16);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.Empty;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnHoverLineColor = System.Drawing.Color.Empty;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(57, 60);
            this.btnHuy.TabIndex = 14;
            // 
            // btnTangGiam
            // 
            this.btnTangGiam.BackColor = System.Drawing.Color.Transparent;
            this.btnTangGiam.BaseColor = System.Drawing.Color.White;
            this.btnTangGiam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnTangGiam.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnTangGiam.ButtonForeColor = System.Drawing.SystemColors.Window;
            this.btnTangGiam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTangGiam.ForeColor = System.Drawing.Color.Black;
            this.btnTangGiam.Location = new System.Drawing.Point(175, 28);
            this.btnTangGiam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTangGiam.Maximum = ((long)(9999999));
            this.btnTangGiam.Minimum = ((long)(1));
            this.btnTangGiam.Name = "btnTangGiam";
            this.btnTangGiam.Radius = 3;
            this.btnTangGiam.Size = new System.Drawing.Size(71, 30);
            this.btnTangGiam.TabIndex = 12;
            this.btnTangGiam.Value = ((long)(1));
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbGia.Location = new System.Drawing.Point(12, 58);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(66, 25);
            this.lbGia.TabIndex = 11;
            this.lbGia.Text = "28,000";
            // 
            // lbTen
            // 
            this.lbTen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(6, 16);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(151, 42);
            this.lbTen.TabIndex = 10;
            this.lbTen.Text = "Sandwich Heo";
            // 
            // usChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTangGiam);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbTen);
            this.Name = "usChiTietHD";
            this.Size = new System.Drawing.Size(418, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaLabel lbTongTien;
        public Guna.UI.WinForms.GunaAdvenceTileButton btnHuy;
        public Guna.UI.WinForms.GunaNumeric btnTangGiam;
        private Guna.UI.WinForms.GunaLabel lbGia;
        private Guna.UI.WinForms.GunaLabel lbTen;
    }
}
