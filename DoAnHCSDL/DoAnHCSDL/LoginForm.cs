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
using DoAnHCSDL.DO;

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
            AccountDO account = new AccountDO();
            account.UserName =  txtUserName.Text;
            account.Password = txtPassword.Text;
            SQLAction action = new SQLAction();
            DataSet result = action.Login(account);
            if(result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Mã tài khoản là " + result.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
