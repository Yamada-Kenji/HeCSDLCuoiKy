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

namespace DoAnHCSDL
{
    public partial class ChooseFood : UserControl
    {
        public ChooseFood()
        {
            InitializeComponent();
        }
        int soluong = 0;
        private void pCong_Click(object sender, EventArgs e)
        {
            if (soluong == 99)
            {

            }
            else
            {
                txtSoluong.Text = (soluong=soluong + 1).ToString(); 
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
            lb_TenMon.Text = tenmon;
            lb_Gia.Text = giatien.ToString() ;
            MemoryStream stream = new MemoryStream(hinhanh);
            Image img = Image.FromStream(stream);
            pHinh.Image = img;

        }

        private void pTru_Click(object sender, EventArgs e)
        {
            if (soluong == 0)
            {

            }
            else
            {
                txtSoluong.Text = (soluong=soluong - 1).ToString();
            }
            
        }
    }
}
