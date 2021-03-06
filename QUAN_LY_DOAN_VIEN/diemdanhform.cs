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
    public partial class diemdanhform : Form
    {
        BindingSource dd = new BindingSource();

        public diemdanhform()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            dataGridViewQLDIEMDANH.DataSource = dd;

            LoadDiemDanh();
            LoadCboDoanVien(cbo_mdv);
            LoadCboHoatDong(cbo_mhd);
        }

        private void LoadCboHoatDong(ComboBox cb)
        {
            cb.DataSource = HoatDongDAO.Instance.GetListMaHoatDong();
            cb.DisplayMember = "tenhd";
        }

        private void LoadCboDoanVien(ComboBox cb)
        {
            cb.DataSource = DoanVienDAO.Instance.GetListMaDoanVien();
            cb.DisplayMember = "madv";
        }

        private void LoadDiemDanh()
        {
            dd.DataSource = DiemDanhDAO.Instance.GetListDiemDanh();
        }

        private void btnThoatDD_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                this.Close();
        }

        private void btnThemDD_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string madv = (cbo_mdv.SelectedItem as DoanVien).Madv;
            int mahd = (int)(cbo_mhd.SelectedItem as HoatDong).Mahd;
            string ghichu = txtGhiChuDD.Text;
            if (DiemDanhDAO.Instance.InsertDiemDanh(id, madv, mahd, ghichu))
            {
                LoadDiemDanh();
                MessageBox.Show("Thêm mới thành công!");
                Clear();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        private void Clear()
        {
            txt_id.Clear();
            txtGhiChuDD.Clear();
        }

        private void btnSuaDD_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string madv = (cbo_mdv.SelectedItem as DoanVien).Madv;
            int mahd = (int)(cbo_mhd.SelectedItem as HoatDong).Mahd;
            string ghichu = txtGhiChuDD.Text;

            if (DiemDanhDAO.Instance.UpdateDiemDanh(id, madv, mahd, ghichu))
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }

            LoadDiemDanh();
            Clear();
        }

        private void btnXoaDD_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);

            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (DiemDanhDAO.Instance.DeleteDiemDanh(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    Clear();
                    LoadDiemDanh();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void dataGridViewQLDIEMDANH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewQLDIEMDANH.Rows[e.RowIndex];
                txt_id.Text = row.Cells[0].Value.ToString();
                cbo_mhd.Text = row.Cells[1].Value.ToString();
                cbo_mdv.Text = row.Cells[2].Value.ToString();
                txtGhiChuDD.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Search_DiemDanh_TextChanged(object sender, EventArgs e)
        {
            string key = Search_DiemDanh.Text;
            dataGridViewQLDIEMDANH.DataSource = DiemDanhDAO.Instance.SearchDiemDanh(key);
        }
    }
}
