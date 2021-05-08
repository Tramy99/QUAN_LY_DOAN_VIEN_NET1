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
    public partial class xeploaiform : Form
    {
        BindingSource xl = new BindingSource();

        public xeploaiform()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            dataGridViewXEPLOAI.DataSource = xl;

            LoadXepLoai();
            LoadCboDoanVien(cbox_Mdv);
            LoadCboHoatDong(cbox_MHD);
        }

        private void LoadXepLoai()
        {
            xl.DataSource = XepLoaiDAO.Instance.GetListXepLoai();
        }

        private void btnThoatXL_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                this.Close();
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

        private void btnThemXL_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIDXL.Text);
                int namhoc = Convert.ToInt32(txtNamHocXL.Text);
                string nhanxet = txtNhanXetXL.Text;
                string xeploai = comboBox_Xeploai.SelectedItem.ToString();
                string madv = (cbox_Mdv.SelectedItem as DoanVien).Madv;
                int mahd = (int)(cbox_MHD.SelectedItem as HoatDong).Mahd;

                if (XepLoaiDAO.Instance.InsertXepLoai(id, madv, namhoc, nhanxet, xeploai, mahd))
                {
                    MessageBox.Show("Thêm mới thành công!");
                    LoadXepLoai();
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
            txtIDXL.Clear();
            txtNamHocXL.Clear();
            txtNhanXetXL.Clear();
        }

        private void btnSuaXL_Click(object sender, EventArgs e)
        {
            try
            {
                int maxl = Convert.ToInt32(txtIDXL.Text);
                int namhoc = Convert.ToInt32(txtNamHocXL.Text);
                string nhanxet = txtNhanXetXL.Text;
                string xeploai = comboBox_Xeploai.SelectedItem.ToString();
                string madv = (cbox_Mdv.SelectedItem as DoanVien).Madv;
                int mahd = (int)(cbox_MHD.SelectedItem as HoatDong).Mahd;

                if (XepLoaiDAO.Instance.UpdateXepLoai(maxl, madv, namhoc, nhanxet, xeploai, mahd))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadXepLoai();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            catch { }
        }

        private void btnXoaXL_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIDXL.Text);

                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (XepLoaiDAO.Instance.DeleteXepLoai(id))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadXepLoai();
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

        private void dataGridViewXEPLOAI_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewXEPLOAI.Rows[e.RowIndex];
                txtIDXL.Text = row.Cells[0].Value.ToString();
                txtNhanXetXL.Text = row.Cells[3].Value.ToString();
                txtNamHocXL.Text = row.Cells[2].Value.ToString();
                cbox_Mdv.Text = row.Cells[1].Value.ToString();
                comboBox_Xeploai.Text = row.Cells[4].Value.ToString();
                cbox_MHD.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
