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
                //ChangeAccount(loginAccount.Type); 
            }
        }

        public manchinhform(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            //LoadTable();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát khỏi chương trình này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Application.Exit();
            else
            {
            }
        }    
        private void QLCDtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            chidoanform cd = new chidoanform();
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

        private void quảnLýĐoànPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanphiform dp = new doanphiform();
            dp.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DiemdanhtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            diemdanhform dd = new diemdanhform();
            dd.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát khỏi chương trình này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Application.Exit();
            else
            {
            }
        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }
    }
}
