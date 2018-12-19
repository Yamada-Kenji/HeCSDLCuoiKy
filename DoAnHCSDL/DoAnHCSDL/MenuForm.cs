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
            
            
            if (table.Tables[0].Rows.Count >0 && table.Tables.Count >0)
            {
                for(int i =0;i<table.Tables[0].Rows.Count;i++)
                {

                    Button button = new Button();
                    button.Size = new Size(80, 50);
                    button.Text = table.Tables[0].Rows[i][0].ToString();
                    pl_Chon.Controls.Add(button);
                    string DM = table.Tables[0].Rows[i][0].ToString();

                    button.Click += (sender, args) =>
                    {
                        pl_Menu.Controls.Clear();
                        FlowLayoutPanel pl = new FlowLayoutPanel();
                        pl.Size = new Size(400, 430);
                        
                        DTO_Food food = new DTO_Food();
                        food.DanhMuc = button.Text;
                        SQLAction getfood = new SQLAction();
                        DataSet result = new DataSet();
                        result = getfood.GetFoodInfo(food);
                        for (int k = 0; k < result.Tables[0].Rows.Count; k++)
                        {
                            ChooseFood choose = new ChooseFood();
                            choose.TENMON = result.Tables[0].Rows[k][1].ToString();
                            choose.GIATIEN = int.Parse(result.Tables[0].Rows[k][3].ToString());
                            System.Byte[] arr = (result.Tables[0].Rows[k][4]) as System.Byte[];
                            choose.HINHANH = arr;
                            pl.Controls.Add(choose);
                            
                        }
                        pl_Menu.Controls.Add(pl);
                    };       
                }
            }
        }
    }
}
