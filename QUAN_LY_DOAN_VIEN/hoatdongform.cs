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
    public partial class hoatdongform : Form
    {
        public hoatdongform()
        {
            InitializeComponent();
        }

        private void btnThoatHD_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát khỏi chương trình này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Application.Exit();
            else
            {
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {

        }
    }
}
