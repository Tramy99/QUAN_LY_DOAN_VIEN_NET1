using QUAN_LY_DOAN_VIEN.DAO;
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
    public partial class ThongTinDV : Form
    {
        BindingSource dv = new BindingSource();

        BindingSource mcd = new BindingSource();

        public ThongTinDV()
        {
            InitializeComponent();
        }

        private void chiĐoànToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đoànViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dv.DataSource = DoanVienDAO.Instance.GetListDoanVien();
        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xếpLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
