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
using System.Drawing.Imaging;
using System.IO;
namespace DoAnHCSDL
{
    public partial class AddFood : Form
    {
        public AddFood()
        {
            InitializeComponent();
        }
        string file;
        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                file = open.FileName;
                if(string.IsNullOrEmpty(file))
                {
                    return;
                }
                Image img = Image.FromFile(file);
                pHinh.Image = img;
            }
        }
        public void load()
        {
            lb_TenMon.ForeColor = Color.Black;
            lb_GiaTien.ForeColor = Color.Black;
            lb_MoTa.ForeColor = Color.Black;
            lb_DanhMuc.ForeColor = Color.Black;
            txtTenMon.ResetText();
            txtMoTa.ResetText();
            txtGiaTien.ResetText();
            SQLAction LayDanhMuc = new SQLAction();
            DataSet table = LayDanhMuc.GetCategory();
            for (int i = 0; i < table.Tables[0].Rows.Count; i++)
            {
                cbb_DanhMuc.Items.Add(table.Tables[0].Rows[0][i].ToString());
            }
            

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaMon.Text))
            {
                lb_MaMon.ForeColor = Color.Red;
            }
            else
            {
                lb_MaMon.ForeColor = Color.Black;
            }
            if(string.IsNullOrEmpty(txtTenMon.Text))
            {
                lb_TenMon.ForeColor = Color.Red;
            }
            else
            {
                lb_TenMon.ForeColor = Color.Black;
            }
            if(string.IsNullOrEmpty(txtMoTa.Text))
            {
                lb_MoTa.ForeColor = Color.Red;
            }
            else
            {
                lb_MoTa.ForeColor = Color.Black;
            }
            if(string.IsNullOrEmpty(txtGiaTien.Text))
            {
                lb_GiaTien.ForeColor = Color.Red;
            }
            else
            {
                lb_GiaTien.ForeColor = Color.Black;
            }
            if(string.IsNullOrEmpty(cbb_DanhMuc.Text))
            {
                lb_DanhMuc.ForeColor = Color.Red;
            }
            else
            {
                lb_DanhMuc.ForeColor = Color.Black;
            }
            if (lb_MaMon.ForeColor == Color.Black && lb_DanhMuc.ForeColor == Color.Black && lb_MoTa.ForeColor == Color.Black && lb_GiaTien.ForeColor == Color.Black && lb_TenMon.ForeColor == Color.Black)
            {
                DTO_Food addfood = new DTO_Food();
                addfood.MaMon = txtMaMon.Text;
                addfood.TenMon = txtTenMon.Text;
                addfood.DanhMuc = cbb_DanhMuc.Text;
                addfood.MoTa = txtMoTa.Text;
                addfood.GiaTien = (int)double.Parse(txtGiaTien.Text);
                //xử lí hình ảnh
                Image img = Image.FromFile(file);
                MemoryStream stream = new MemoryStream();
                img.Save(stream, ImageFormat.Jpeg);
                stream.Seek(0, SeekOrigin.Begin);
                byte[] imgByte = System.IO.File.ReadAllBytes(file);
                int sizeImg = imgByte.Length;
                stream.Read(imgByte, 0, sizeImg);
                addfood.HinhAnh = imgByte;
                SQLAction add = new SQLAction();
                if (add.AddFood(addfood) != -1)
                {
                    MessageBox.Show("Thêm món thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất Bại, vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Điền thiếu thông tin, vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            if(txtGiaTien.Text == "")
            {

            }
            else
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txtGiaTien.Text, System.Globalization.NumberStyles.AllowThousands);
                txtGiaTien.Text = String.Format(culture, "{0:N0}", value);
                txtGiaTien.Select(txtGiaTien.Text.Length, 0);
            }
            
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
