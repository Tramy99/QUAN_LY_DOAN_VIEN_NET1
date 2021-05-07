using QUAN_LY_DOAN_VIEN.DAO;
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
    public partial class ThongTinDV : Form
    {
        BindingSource data = new BindingSource();

        //private Account loginAccount;

        //public Account LoginAccount
        //{
        //    get { return loginAccount; }
        //    set
        //    {
        //        loginAccount = value;
        //    }
        //}

        public ThongTinDV()
        {
            InitializeComponent();
            dataGridViewThongtinDV.DataSource = data;

        }

        private void DDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        string madv = "";
        private void CDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.DataSource = ChiDoanDAO.Instance.GetListChiDoanByAccount(madv);
        }
    }
}
