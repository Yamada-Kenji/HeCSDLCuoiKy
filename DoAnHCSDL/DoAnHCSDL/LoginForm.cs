using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DoAnHCSDL.BO;
using DoAnHCSDL.DTO;

namespace DoAnHCSDL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            DTO_Login account = new DTO_Login();
            account.UserName =  txtUserName.Text;
            account.PassWord = txtPassword.Text;
            SQLAction action = new SQLAction();
            DataSet result = action.Login(account);
            if(result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MenuForm menu = new MenuForm();
                this.Hide();
                menu.USERNAME = result.Tables[0].Rows[0][0].ToString();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                load();

            }
        }
        private void load()
        {
            txtPassword.ResetText();
            txtUserName.ResetText();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
