using System;
using QUAN_LY_DOAN_VIEN.DAO;
using QUAN_LY_DOAN_VIEN.DTO;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_DOAN_VIEN
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dangki_form_Load(object sender, EventArgs e)
        {

        }

        private void btnThoatTK_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Application.Exit();
            else
            {
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string userName = LogInfo.UserName;
            string oldPass = txt_mkc.Text;
            string newPass = txt_mkm.Text;
            string confirm = txt_Confirm.Text;
            Account ac = AccountDAO.Instance.GetAccountByUserName(userName);
            if(oldPass == ac.Password)
            {
                if(newPass == confirm)
                {
                    bool result = AccountDAO.Instance.UpdateAccount(userName, newPass);
                    if(result)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                this.Close();
            else
            {
            }
        }
    }
}
