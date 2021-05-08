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
    public partial class khenthuongform : Form
    {
        BindingSource kt = new BindingSource();

        public khenthuongform()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            dataGridViewKhenThuong.DataSource = kt;

            LoadKhenThuong();
            LoadCboDoanVien(cbox_madv);
        }

        private void LoadCboDoanVien(ComboBox cb)
        {
            cb.DataSource = DoanVienDAO.Instance.GetListMaDoanVien();
            cb.DisplayMember = "madv";
        }

        private void LoadKhenThuong()
        {
            kt.DataSource = KhenThuongDAO.Instance.GetListKhenThuong();
        }

        private void btnThoatKT_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                this.Close();
        }

        private void btnThemKT_Click(object sender, EventArgs e)
        {
            try
            {
                int makt = Convert.ToInt32(txtMaKTKT.Text);
                string madv = (cbox_madv.SelectedItem as DoanVien).Madv;
                string tenkt = txtTenKTKT.Text;
                string thanhtich = txtThanhTichKT.Text;
                int namhoc = Convert.ToInt32(txtNamHocKT.Text);

                if (KhenThuongDAO.Instance.InsertKhenThuong(makt, madv, tenkt, thanhtich, namhoc))
                {
                    MessageBox.Show("Thêm mới thành công!");
                    LoadKhenThuong();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
            }
            catch { }
        }

        private void Clear()
        {
            txtMaKTKT.Clear();
            txtTenKTKT.Clear();
            txtThanhTichKT.Clear();
            txtNamHocKT.Clear();
        }

        private void btnSuaKT_Click(object sender, EventArgs e)
        {
            try
            {
                int makt = Convert.ToInt32(txtMaKTKT.Text);
                string madv = (cbox_madv.SelectedItem as DoanVien).Madv;
                string tenkt = txtTenKTKT.Text;
                string thanhtich = txtThanhTichKT.Text;
                int namhoc = Convert.ToInt32(txtNamHocKT.Text);

                if (KhenThuongDAO.Instance.UpdateKhenThuong(makt, madv, tenkt, thanhtich, namhoc))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadKhenThuong();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            catch { }
        }

        private void btnXoaKT_Click(object sender, EventArgs e)
        {
            try
            {
                int makt = Convert.ToInt32(txtMaKTKT.Text);
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (KhenThuongDAO.Instance.DeleteKhenThuong(makt))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadKhenThuong();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            catch { }
        }

        private void dataGridViewKhenThuong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewKhenThuong.Rows[e.RowIndex];
                txtMaKTKT.Text = row.Cells[0].Value.ToString();
                cbox_madv.Text = row.Cells[1].Value.ToString();
                txtTenKTKT.Text = row.Cells[3].Value.ToString();
                txtThanhTichKT.Text = row.Cells[4].Value.ToString();
                txtNamHocKT.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
