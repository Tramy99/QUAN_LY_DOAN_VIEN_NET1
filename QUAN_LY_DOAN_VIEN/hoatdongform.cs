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
    public partial class hoatdongform : Form
    {
        BindingSource hd = new BindingSource();

        public hoatdongform()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            dataGridViewQLHDONG.DataSource = hd;

            LoadHoatDong();
        }
        void Clear()
        {
            txtMaHD.Clear();
            txtTenHD.Clear();
            txtGhiChu.Clear();
        }

        private void LoadHoatDong()
        {
            hd.DataSource = HoatDongDAO.Instance.GetListHoatDong();
        }

        private void btnThoatHD_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                this.Close();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime thoigiantc = Convert.ToDateTime(dateTimePicker1.Text);
                int mahd = Convert.ToInt32(txtMaHD.Text);
                string tenhd = txtTenHD.Text;
                string ghichu = txtGhiChu.Text;

                if (HoatDongDAO.Instance.InsertHoatDong(mahd, tenhd, thoigiantc, ghichu))
                {
                    MessageBox.Show("Thêm mới thành công!");
                    LoadHoatDong();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
            }
            catch { }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime thoigiantc = Convert.ToDateTime(dateTimePicker1.Text);
                int mahd = Convert.ToInt32(txtMaHD.Text);
                string tanhd = txtTenHD.Text;
                string ghichu = txtGhiChu.Text;

                if (HoatDongDAO.Instance.UpdateHoatDong(mahd, tanhd, thoigiantc, ghichu))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadHoatDong();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            catch { }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                int mahd = Convert.ToInt32(txtMaHD.Text);

                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (HoatDongDAO.Instance.DeleteHoatDong(mahd))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadHoatDong();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa vì còn tồn tại liên kết!");
            }
        }

        private void dataGridViewQLHDONG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewQLHDONG.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                txtTenHD.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                txtGhiChu.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
