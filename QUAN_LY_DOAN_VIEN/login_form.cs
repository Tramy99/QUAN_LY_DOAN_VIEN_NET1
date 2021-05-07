using QUAN_LY_DOAN_VIEN.DAO;
using QUAN_LY_DOAN_VIEN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_DOAN_VIEN
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void button_dangki_Click(object sender, EventArgs e)
        {
            //dang_ky formDangKy = new dang_ky();
            //formDangKy.Show();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            string userName = txt_username.Text;
            string passWord = txt_password.Text;

            if (Login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                manchinhform fMain = new manchinhform(loginAccount);
                this.Hide();
                fMain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
    }
}
