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
    public partial class doanphiform : Form
    {
        public doanphiform()
        {
            InitializeComponent();
        }

        private void btn_Thoatchidoan_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                this.Close();
            else
            {
            }
        }

        private void btn_Themchidoan_Click(object sender, EventArgs e)
        {

        }

        private void btn_Suachidoan_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoachidoan_Click(object sender, EventArgs e)
        {

        }
    }
}
