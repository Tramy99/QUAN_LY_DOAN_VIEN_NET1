using QUAN_LY_DOAN_VIEN.DTO;
using System;
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
    public partial class manchinhform : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; 
            }
        }
        public manchinhform(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            if (acc.Type.Equals(0))
            {
                mnuQuanLy.Visible = false;
            }
            else
            {
                thToolStripMenuItem.Visible = false;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát khỏi chương trình này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Application.Exit();
        }    
        private void QLCDtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            chidoanform cd = new chidoanform();
            cd.MdiParent = this;
            cd.Show();
        }

        private void QLDVtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanvienform dv = new doanvienform();
            dv.Show();
        }

        private void hoatĐongToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hoatdongform hd = new hoatdongform();
            hd.Show();
        }

        private void xepLoaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            xeploaiform xl = new xeploaiform();
            xl.Show();
        }

        private void khenThuongToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            khenthuongform kt = new khenthuongform();
            kt.Show();
        }

        private void DiemdanhtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            diemdanhform dd = new diemdanhform();
            dd.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát khỏi chương trình này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Application.Exit();
        }

        private void thayĐoiMatKhauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePass dk = new ChangePass();
            dk.Show();
        }

        private void ttdvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinDV tt = new ThongTinDV();
            tt.Show();
        }

        private void troGiupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trogiupform tg = new trogiupform();
            tg.Show();
        }

        private void mnuDX_Click(object sender, EventArgs e)
        {
            login_form logout = new login_form();
            //logout.Visible = true;
            this.Hide();
            logout.Show();
        }

        private void QLTKDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themtaikhoanform addAccount = new themtaikhoanform();
            addAccount.Show();
        }

        private void thToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinDV ttdv = new ThongTinDV();
            this.Hide();
            ttdv.ShowDialog();
        }

        private void manchinhform_Load(object sender, EventArgs e)
        {
            userName.Text = LogInfo.UserName;
        }
    }
}
