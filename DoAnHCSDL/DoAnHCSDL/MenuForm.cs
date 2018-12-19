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
using System.Globalization;
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
        public void LoadLaiDGV(object sender, EventArgs e)
        {
            
            SQLAction laydulieu = new SQLAction();
            DataSet tb = laydulieu.GetDataTable();
            dgv_HienThi.DataSource = tb.Tables[0];
            int tong = 0;
            for (int q = 0; q < dgv_HienThi.Rows.Count - 1; q++)
            {

                tong += int.Parse(dgv_HienThi.Rows[q].Cells["ThanhTien"].Value.ToString());
            }
            
        }
   
        private void load()
        {
            
            SQLAction laydulieu = new SQLAction();
            DataSet tb = laydulieu.GetDataTable();
            dgv_HienThi.DataSource = tb.Tables[0];
            SQLAction laydanhmuc = new SQLAction();
            if (dgv_HienThi.Rows.Count != 0)
            {
                int tong = 0;
                for (int q = 0; q < dgv_HienThi.Rows.Count - 1; q++)
                {

                    tong += int.Parse(dgv_HienThi.Rows[q].Cells["ThanhTien"].Value.ToString());
                }
                txt_Tong.Text = tong.ToString();
            }
            else
            {
                txt_Tong.Text = "0";
            }
            DataSet table = laydanhmuc.GetCategory();
            
            
            if (table.Tables[0].Rows.Count >0 && table.Tables.Count >0)
            {
               
                for(int i =0;i<table.Tables[0].Rows.Count;i++)
                {

                    Button button = new Button();
                    button.Size = new Size(80, 50);
                    button.Text = table.Tables[0].Rows[i][0].ToString();
                    pl_Chon.Controls.Add(button);

                    button.Click += (sender, args) =>
                    {
                        pl_Menu.Controls.Clear();
                        if(dgv_HienThi.Rows.Count != 0)
                        {
                            
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
                                choose.MAMONAN = result.Tables[0].Rows[k][0].ToString();
                                choose.TENMON = result.Tables[0].Rows[k][1].ToString();
                                choose.GIATIEN = int.Parse(result.Tables[0].Rows[k][3].ToString());
                                for(int t =0;t <dgv_HienThi.Rows.Count -1;t++)
                                {
                                if (dgv_HienThi.Rows[t].Cells["MaMonAn"].Value.ToString() == result.Tables[0].Rows[k][0].ToString())
                                    {
                                        choose.SOLUONG = int.Parse((dgv_HienThi.Rows[t].Cells["SoLuong"].Value.ToString())) ;
                                        break;
                                    }
                                else
                                    {
                                        choose.SOLUONG = 0;
                                    }
                                }

                                System.Byte[] arr = (result.Tables[0].Rows[k][4]) as System.Byte[];
                                choose.HINHANH = arr;
                                pl.Controls.Add(choose);
                                foreach (Control p in choose.Controls)
                                {
                                    PictureBox test = new PictureBox();
                                    if (p is PictureBox && p.Name == "pCong" || p is PictureBox && p.Name == "pTru")
                                    {
                                        p.Click += new EventHandler(LoadLaiDGV);
                                    }

                                }
                            }
                            pl_Menu.Controls.Add(pl);
                        }
                            
                        else
                        {
                            
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
                                choose.MAMONAN = result.Tables[0].Rows[k][0].ToString();
                                choose.TENMON = result.Tables[0].Rows[k][1].ToString();
                                choose.GIATIEN = int.Parse(result.Tables[0].Rows[k][3].ToString());
                                choose.SOLUONG = 0;
                                System.Byte[] arr = (result.Tables[0].Rows[k][4]) as System.Byte[];
                                choose.HINHANH = arr;
                                pl.Controls.Add(choose);
                                foreach (Control p in choose.Controls)
                                {
                                    PictureBox test = new PictureBox();
                                    if (p is PictureBox && p.Name == "pCong" || p is PictureBox && p.Name == "pTru")
                                    {
                                        p.Click += new EventHandler(LoadLaiDGV);
                                    }

                                }
                            }
                            pl_Menu.Controls.Add(pl);
                        }
                    };       
                }
            }
            pl_Menu.AutoScroll = false;
            pl_Menu.HorizontalScroll.Enabled = false;
            pl_Menu.HorizontalScroll.Visible = false;
            pl_Menu.HorizontalScroll.Maximum = 0;
            pl_Menu.AutoScroll = true;
        }

        private void txt_Tong_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txt_Tong.Text, System.Globalization.NumberStyles.AllowThousands);
            txt_Tong.Text = String.Format(culture, "{0:N0}", value);
            txt_Tong.Select(txt_Tong.Text.Length, 0);
        }

        private void btn_ThemMon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFood add = new AddFood();
            add.USERNAME = username;
            add.ShowDialog();
            this.Close();
            
        }
    }
}
