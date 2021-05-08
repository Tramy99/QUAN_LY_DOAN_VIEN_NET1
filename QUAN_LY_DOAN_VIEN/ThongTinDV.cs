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

        public ThongTinDV()
        {
            InitializeComponent();

            dataGridViewThongtinDV.DataSource = data;
        }

        private void DDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.DataSource = DiemDanhDAO.Instance.GetListDiemDanh();
        }

        private void CDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.DataSource = ChiDoanDAO.Instance.GetListChiDoan();
        }

        private void DVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.DataSource = DoanVienDAO.Instance.GetListDoanVien();
        }

        private void HDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.DataSource = HoatDongDAO.Instance.GetListHoatDong();
        }

        private void XLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.DataSource = XepLoaiDAO.Instance.GetListXepLoai();
        }

        private void KTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.DataSource = KhenThuongDAO.Instance.GetListKhenThuong();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            switch (type_search.SelectedIndex)
            {
                case 0:
                    data.DataSource = ChiDoanDAO.Instance.SearchChiDoan(key);
                    break;

                case 1:
                    data.DataSource = DoanVienDAO.Instance.SearchById(key);
                    break;

                case 2:
                    data.DataSource = HoatDongDAO.Instance.Search(key);
                    break;

                case 3:
                    data.DataSource = KhenThuongDAO.Instance.SearchKhenThuong(key);
                    break;

                case 4:
                    data.DataSource = XepLoaiDAO.Instance.SearchXepLoai(key);
                    break;

                default:
                    data.DataSource = DoanVienDAO.Instance.SearchById(key);
                    break;
            }
        }
    }
}
