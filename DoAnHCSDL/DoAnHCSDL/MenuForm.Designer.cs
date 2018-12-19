namespace DoAnHCSDL
{
    partial class MenuForm
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
            this.pl_Chon = new System.Windows.Forms.FlowLayoutPanel();
            this.pl_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_DongY = new System.Windows.Forms.Button();
            this.btn_ThemMon = new System.Windows.Forms.Button();
            this.btn_BaoCao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_HienThi = new System.Windows.Forms.DataGridView();
            this.txt_Tong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_Chon
            // 
            this.pl_Chon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_Chon.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pl_Chon.Location = new System.Drawing.Point(521, 3);
            this.pl_Chon.Name = "pl_Chon";
            this.pl_Chon.Size = new System.Drawing.Size(96, 430);
            this.pl_Chon.TabIndex = 0;
            // 
            // pl_Menu
            // 
            this.pl_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_Menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pl_Menu.Location = new System.Drawing.Point(623, 3);
            this.pl_Menu.Name = "pl_Menu";
            this.pl_Menu.Size = new System.Drawing.Size(376, 430);
            this.pl_Menu.TabIndex = 1;
            this.pl_Menu.WrapContents = false;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(2, 393);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(65, 40);
            this.btn_Huy.TabIndex = 3;
            this.btn_Huy.Text = "Hủy bỏ";
            this.btn_Huy.UseVisualStyleBackColor = true;
            // 
            // btn_DongY
            // 
            this.btn_DongY.Location = new System.Drawing.Point(2, 12);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(65, 40);
            this.btn_DongY.TabIndex = 4;
            this.btn_DongY.Text = "Đồng ý";
            this.btn_DongY.UseVisualStyleBackColor = true;
            // 
            // btn_ThemMon
            // 
            this.btn_ThemMon.Location = new System.Drawing.Point(5, 141);
            this.btn_ThemMon.Name = "btn_ThemMon";
            this.btn_ThemMon.Size = new System.Drawing.Size(65, 40);
            this.btn_ThemMon.TabIndex = 6;
            this.btn_ThemMon.Text = "Thêm món";
            this.btn_ThemMon.UseVisualStyleBackColor = true;
            this.btn_ThemMon.Click += new System.EventHandler(this.btn_ThemMon_Click);
            // 
            // btn_BaoCao
            // 
            this.btn_BaoCao.Location = new System.Drawing.Point(5, 95);
            this.btn_BaoCao.Name = "btn_BaoCao";
            this.btn_BaoCao.Size = new System.Drawing.Size(65, 40);
            this.btn_BaoCao.TabIndex = 5;
            this.btn_BaoCao.Text = "báo cáo";
            this.btn_BaoCao.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Tong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_HienThi);
            this.panel1.Location = new System.Drawing.Point(76, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 423);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(232, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng:";
            // 
            // dgv_HienThi
            // 
            this.dgv_HienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HienThi.Location = new System.Drawing.Point(2, 3);
            this.dgv_HienThi.Name = "dgv_HienThi";
            this.dgv_HienThi.Size = new System.Drawing.Size(435, 359);
            this.dgv_HienThi.TabIndex = 1;
            // 
            // txt_Tong
            // 
            this.txt_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Tong.Location = new System.Drawing.Point(292, 385);
            this.txt_Tong.Multiline = true;
            this.txt_Tong.Name = "txt_Tong";
            this.txt_Tong.ReadOnly = true;
            this.txt_Tong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Tong.Size = new System.Drawing.Size(134, 25);
            this.txt_Tong.TabIndex = 3;
            this.txt_Tong.TextChanged += new System.EventHandler(this.txt_Tong_TextChanged);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ThemMon);
            this.Controls.Add(this.btn_BaoCao);
            this.Controls.Add(this.btn_DongY);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.pl_Menu);
            this.Controls.Add(this.pl_Chon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HienThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pl_Chon;
        private System.Windows.Forms.FlowLayoutPanel pl_Menu;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_DongY;
        private System.Windows.Forms.Button btn_ThemMon;
        private System.Windows.Forms.Button btn_BaoCao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_HienThi;
        private System.Windows.Forms.TextBox txt_Tong;
    }
}