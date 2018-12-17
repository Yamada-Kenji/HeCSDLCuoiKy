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
            this.SuspendLayout();
            // 
            // pl_Chon
            // 
            this.pl_Chon.Location = new System.Drawing.Point(321, 3);
            this.pl_Chon.Name = "pl_Chon";
            this.pl_Chon.Size = new System.Drawing.Size(96, 430);
            this.pl_Chon.TabIndex = 0;
            // 
            // pl_Menu
            // 
            this.pl_Menu.Location = new System.Drawing.Point(423, 3);
            this.pl_Menu.Name = "pl_Menu";
            this.pl_Menu.Size = new System.Drawing.Size(400, 430);
            this.pl_Menu.TabIndex = 1;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 432);
            this.Controls.Add(this.pl_Menu);
            this.Controls.Add(this.pl_Chon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pl_Chon;
        private System.Windows.Forms.FlowLayoutPanel pl_Menu;
    }
}