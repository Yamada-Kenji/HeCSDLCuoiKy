namespace DoAnHCSDL
{
    partial class ChooseFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFood));
            this.lb_TenMon = new System.Windows.Forms.Label();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.pHinh = new System.Windows.Forms.PictureBox();
            this.pCong = new System.Windows.Forms.PictureBox();
            this.pTru = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTru)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TenMon
            // 
            this.lb_TenMon.AutoSize = true;
            this.lb_TenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_TenMon.Location = new System.Drawing.Point(3, 12);
            this.lb_TenMon.Name = "lb_TenMon";
            this.lb_TenMon.Size = new System.Drawing.Size(62, 18);
            this.lb_TenMon.TabIndex = 1;
            this.lb_TenMon.Text = "tên món";
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Gia.Location = new System.Drawing.Point(254, 12);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(27, 18);
            this.lb_Gia.TabIndex = 2;
            this.lb_Gia.Text = "giá";
            // 
            // pHinh
            // 
            this.pHinh.Location = new System.Drawing.Point(6, 45);
            this.pHinh.Name = "pHinh";
            this.pHinh.Size = new System.Drawing.Size(78, 77);
            this.pHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHinh.TabIndex = 3;
            this.pHinh.TabStop = false;
            // 
            // pCong
            // 
            this.pCong.Image = ((System.Drawing.Image)(resources.GetObject("pCong.Image")));
            this.pCong.Location = new System.Drawing.Point(284, 79);
            this.pCong.Name = "pCong";
            this.pCong.Size = new System.Drawing.Size(29, 29);
            this.pCong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pCong.TabIndex = 4;
            this.pCong.TabStop = false;
            this.pCong.Click += new System.EventHandler(this.pCong_Click);
            // 
            // pTru
            // 
            this.pTru.Image = ((System.Drawing.Image)(resources.GetObject("pTru.Image")));
            this.pTru.Location = new System.Drawing.Point(212, 79);
            this.pTru.Name = "pTru";
            this.pTru.Size = new System.Drawing.Size(29, 29);
            this.pTru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pTru.TabIndex = 5;
            this.pTru.TabStop = false;
            this.pTru.Click += new System.EventHandler(this.pTru_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSoluong.Location = new System.Drawing.Point(247, 79);
            this.txtSoluong.Multiline = true;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.ReadOnly = true;
            this.txtSoluong.Size = new System.Drawing.Size(31, 29);
            this.txtSoluong.TabIndex = 7;
            this.txtSoluong.Text = "0";
            this.txtSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChooseFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pTru);
            this.Controls.Add(this.pCong);
            this.Controls.Add(this.pHinh);
            this.Controls.Add(this.lb_Gia);
            this.Controls.Add(this.lb_TenMon);
            this.Name = "ChooseFood";
            this.Size = new System.Drawing.Size(327, 125);
            this.Load += new System.EventHandler(this.ChooseFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TenMon;
        private System.Windows.Forms.Label lb_Gia;
        private System.Windows.Forms.PictureBox pHinh;
        private System.Windows.Forms.PictureBox pCong;
        private System.Windows.Forms.PictureBox pTru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoluong;
    }
}
