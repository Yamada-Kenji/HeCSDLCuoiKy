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
            this.lb_TenMon = new System.Windows.Forms.Label();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.pHinh = new System.Windows.Forms.PictureBox();
            this.pCong = new System.Windows.Forms.PictureBox();
            this.pTru = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pHinh.TabIndex = 3;
            this.pHinh.TabStop = false;
            // 
            // pCong
            // 
            this.pCong.Location = new System.Drawing.Point(284, 79);
            this.pCong.Name = "pCong";
            this.pCong.Size = new System.Drawing.Size(29, 29);
            this.pCong.TabIndex = 4;
            this.pCong.TabStop = false;
            // 
            // pTru
            // 
            this.pTru.Location = new System.Drawing.Point(212, 79);
            this.pTru.Name = "pTru";
            this.pTru.Size = new System.Drawing.Size(29, 29);
            this.pTru.TabIndex = 5;
            this.pTru.TabStop = false;
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
            // ChooseFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pTru);
            this.Controls.Add(this.pCong);
            this.Controls.Add(this.pHinh);
            this.Controls.Add(this.lb_Gia);
            this.Controls.Add(this.lb_TenMon);
            this.Name = "ChooseFood";
            this.Size = new System.Drawing.Size(327, 125);
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
    }
}
