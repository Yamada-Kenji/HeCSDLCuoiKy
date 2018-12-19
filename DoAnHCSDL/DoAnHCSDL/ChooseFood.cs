using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DoAnHCSDL.BO;
using DoAnHCSDL.DTO;

namespace DoAnHCSDL
{
    public partial class ChooseFood : UserControl
    {
        public ChooseFood()
        {
            InitializeComponent();
        }
       
        public void pCong_Click(object sender, EventArgs e)
        {
            if (soluong == 99)
            {
                MessageBox.Show("Giỏ hàng đã đầy");
            }
            else
            {
                txtSoluong.Text = (soluong=soluong + 1).ToString();
                DTO_Food food = new DTO_Food();
                food.MaMon = mamonan;
                food.TenMon = tenmon;
                food.SoLuong = int.Parse(txtSoluong.Text);
                food.GiaTien = giatien * food.SoLuong;
                SQLAction sql = new SQLAction();
                if (sql.AddCart(food) != -1)   //lần đầu thêm sẽ ko bị lỗi 
                {
                   
                }
                else  //trùng mã khi thêm => đã tồn tại mặt hàng đó => xóa thêm lại số lượng 
                {
                    sql.DeleteCart(food);
                    sql.AddCart(food);
                }
            }
        }
        private int soluong;
        public int SOLUONG
        {
            set
            {
                soluong = value;
            }
        }
        private string mamonan;
        public string MAMONAN
        {
            set
            {
                mamonan = value;
            }
        }
        private string tenmon;
        public string TENMON
        {
            set
            {
                tenmon = value;
            }
        }
        private Byte[] hinhanh;
        public Byte [] HINHANH
        {
            set
            {
                hinhanh = value;
            }
        }
        private int giatien;
        public int GIATIEN
        {
            set
            {
                giatien = value;
            }
        }
        

        private void ChooseFood_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            txtSoluong.Text = soluong.ToString() ;
            lb_TenMon.Text = tenmon;
            lb_Gia.Text = giatien.ToString() ;
            MemoryStream stream = new MemoryStream(hinhanh);
            Image img = Image.FromStream(stream);
            pHinh.Image = img;
      

        }

        public void pTru_Click(object sender, EventArgs e)
        {
            if (soluong == 1)
            {
                txtSoluong.Text = (soluong = soluong - 1).ToString();
                DTO_Food food = new DTO_Food();
                food.MaMon = mamonan;
                SQLAction sql = new SQLAction();
                if (sql.DeleteCart(food) != -1)
                {

                }

            }
            else
            {
                if (soluong == 0)
                {

                    MessageBox.Show("Không còn gì để giảm");

                }
                else
                {
                    txtSoluong.Text = (soluong = soluong - 1).ToString();
                    DTO_Food food = new DTO_Food();
                    food.MaMon = mamonan;
                    food.TenMon = tenmon;
                    food.SoLuong = int.Parse(txtSoluong.Text);
                    food.GiaTien = giatien * food.SoLuong;
                    SQLAction sql = new SQLAction();
                    if (sql.AddCart(food) != -1)
                    {

                    }
                    else
                    {
                        sql.DeleteCart(food);
                        sql.AddCart(food);
                    }
                }
            }
        }
            
        }
    }
