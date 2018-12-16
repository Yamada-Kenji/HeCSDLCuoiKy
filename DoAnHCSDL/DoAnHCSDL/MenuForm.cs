using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnHCSDL.BO;
using DoAnHCSDL.DTO;
namespace DoAnHCSDL
{
    public partial class MenuForm : Form
    {
        private string username;
        public string USERNAME
        {
            set
            {
                username = value;
            }
        }
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            load();

        }
        private void load()
        {
            SQLAction laydanhmuc = new SQLAction();
            DataSet table = laydanhmuc.GetCategory();
            if(table.Tables[0].Rows.Count >0 && table.Tables.Count >0)
            {
                for(int i =0;i<table.Tables[0].Rows.Count;i++)
                {

                    Button button = new Button();
                    button.Size = new Size(80, 50);
                    button.Text = table.Tables[0].Rows[i][0].ToString();
                    pl_Chon.Controls.Add(button);
                    FlowLayoutPanel pl = new FlowLayoutPanel();
                    
                    button.Click += (sender, args) => 
                    {
                        
                        
                    };
                }
            }
        }
    }
}
