namespace DoAnHCSDL
{
    partial class AddFood
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
            this.lb_TenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lb_GiaTien = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lb_MoTa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pHinh = new System.Windows.Forms.PictureBox();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lb_DanhMuc = new System.Windows.Forms.Label();
            this.cbb_DanhMuc = new System.Windows.Forms.ComboBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lb_MaMon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TenMon
            // 
            this.lb_TenMon.AutoSize = true;
            this.lb_TenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_TenMon.Location = new System.Drawing.Point(42, 95);
            this.lb_TenMon.Name = "lb_TenMon";
            this.lb_TenMon.Size = new System.Drawing.Size(83, 20);
            this.lb_TenMon.TabIndex = 0;
            this.lb_TenMon.Text = "Tên món:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTenMon.Location = new System.Drawing.Point(136, 92);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(283, 26);
            this.txtTenMon.TabIndex = 1;
            // 
            // lb_GiaTien
            // 
            this.lb_GiaTien.AutoSize = true;
            this.lb_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_GiaTien.Location = new System.Drawing.Point(42, 135);
            this.lb_GiaTien.Name = "lb_GiaTien";
            this.lb_GiaTien.Size = new System.Drawing.Size(77, 20);
            this.lb_GiaTien.TabIndex = 2;
            this.lb_GiaTien.Text = "Giá tiền:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMoTa.Location = new System.Drawing.Point(136, 226);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(283, 118);
            this.txtMoTa.TabIndex = 4;
            // 
            // lb_MoTa
            // 
            this.lb_MoTa.AutoSize = true;
            this.lb_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_MoTa.Location = new System.Drawing.Point(42, 226);
            this.lb_MoTa.Name = "lb_MoTa";
            this.lb_MoTa.Size = new System.Drawing.Size(63, 20);
            this.lb_MoTa.TabIndex = 4;
            this.lb_MoTa.Text = "Mô Tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(470, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hình Ảnh";
            // 
            // pHinh
            // 
            this.pHinh.Location = new System.Drawing.Point(569, 50);
            this.pHinh.Name = "pHinh";
            this.pHinh.Size = new System.Drawing.Size(145, 174);
            this.pHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHinh.TabIndex = 7;
            this.pHinh.TabStop = false;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChonHinh.Location = new System.Drawing.Point(588, 230);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(102, 28);
            this.btnChonHinh.TabIndex = 5;
            this.btnChonHinh.Text = "Chọn Hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLuu.Location = new System.Drawing.Point(254, 378);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 28);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHuy.Location = new System.Drawing.Point(458, 378);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 28);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lb_DanhMuc
            // 
            this.lb_DanhMuc.AutoSize = true;
            this.lb_DanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_DanhMuc.Location = new System.Drawing.Point(42, 175);
            this.lb_DanhMuc.Name = "lb_DanhMuc";
            this.lb_DanhMuc.Size = new System.Drawing.Size(90, 20);
            this.lb_DanhMuc.TabIndex = 11;
            this.lb_DanhMuc.Text = "Danh Mục";
            // 
            // cbb_DanhMuc
            // 
            this.cbb_DanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbb_DanhMuc.FormattingEnabled = true;
            this.cbb_DanhMuc.Location = new System.Drawing.Point(136, 175);
            this.cbb_DanhMuc.Name = "cbb_DanhMuc";
            this.cbb_DanhMuc.Size = new System.Drawing.Size(199, 28);
            this.cbb_DanhMuc.TabIndex = 12;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGiaTien.Location = new System.Drawing.Point(136, 132);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(172, 26);
            this.txtGiaTien.TabIndex = 2;
            this.txtGiaTien.TextChanged += new System.EventHandler(this.txtGiaTien_TextChanged);
            this.txtGiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTien_KeyPress);
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMaMon.Location = new System.Drawing.Point(136, 50);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(142, 26);
            this.txtMaMon.TabIndex = 14;
            // 
            // lb_MaMon
            // 
            this.lb_MaMon.AutoSize = true;
            this.lb_MaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_MaMon.Location = new System.Drawing.Point(42, 53);
            this.lb_MaMon.Name = "lb_MaMon";
            this.lb_MaMon.Size = new System.Drawing.Size(77, 20);
            this.lb_MaMon.TabIndex = 13;
            this.lb_MaMon.Text = "Mã món:";
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.lb_MaMon);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.cbb_DanhMuc);
            this.Controls.Add(this.lb_DanhMuc);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.pHinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lb_MoTa);
            this.Controls.Add(this.lb_GiaTien);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.lb_TenMon);
            this.Name = "AddFood";
            this.Text = "AddFood";
            this.Load += new System.EventHandler(this.AddFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lb_GiaTien;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lb_MoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pHinh;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lb_DanhMuc;
        private System.Windows.Forms.ComboBox cbb_DanhMuc;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lb_MaMon;
    }
}