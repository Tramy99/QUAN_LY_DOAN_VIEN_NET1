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
    public partial class doanvienform : Form
    {
        BindingSource dv = new BindingSource();

        public doanvienform()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgv_doanvien.DataSource = dv;

            LoadDoanVien();
            LoadComboBox(cbo_mcd);
        }

        void Clear()
        {
            txt_mdv.Clear();
            txt_tdv.Clear();
            rtx_dc.Clear();
            txt_gt.Clear();
            txt_dt.Clear();
        }

        private void LoadComboBox(ComboBox cb)
        {
            cb.DataSource = ChiDoanDAO.Instance.GetListMaChiDoan();
            cb.DisplayMember = "macd";
        }

        void LoadDoanVien()
        {
            dv.DataSource = DoanVienDAO.Instance.GetListDoanVien();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try 
            {
                //Lấy giá trị từ form
                DateTime ns = Convert.ToDateTime(dateTimePickerNs.Text);
                DateTime ngayvd = Convert.ToDateTime(dateTimePickerNvd.Text);
                string madv = txt_mdv.Text;
                string tendv = txt_tdv.Text;
                string que = rtx_dc.Text;
                string gioitinh = txt_gt.Text;
                string dt = txt_dt.Text;
                string macd = (cbo_mcd.SelectedItem as ChiDoan).Macd;

                //Thêm các giá trị vừa lấy được vào bảng đoàn viên
                if (DoanVienDAO.Instance.InsertDoanVien(madv, tendv, ns, que, gioitinh, ngayvd, dt, macd))
                {
                    MessageBox.Show("Thêm mới thành công!");
                    //Load lại Datagridview và xóa thông tin các input vừa thêm
                    LoadDoanVien();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
            }
            catch { }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                this.Close();
            else
            {
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ns = Convert.ToDateTime(dateTimePickerNs.Text);
                DateTime ngayvd = Convert.ToDateTime(dateTimePickerNvd.Text);
                string madv = txt_mdv.Text;
                string tendv = txt_tdv.Text;
                string que = rtx_dc.Text;
                string gioitinh = txt_gt.Text;
                string dt = txt_dt.Text;
                string macd = (cbo_mcd.SelectedItem as ChiDoan).Macd;

                if (DoanVienDAO.Instance.UpdateDoanVien(tendv, ns, que, gioitinh, ngayvd, dt, macd, madv))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadDoanVien();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            catch
            {
                throw new Exception("Lỗi!");
            }
        }
        //do dl ra dgv
        private void dgv_doanvien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_doanvien.Rows[e.RowIndex];
                txt_mdv.Text = row.Cells[0].Value.ToString();
                txt_tdv.Text = row.Cells[1].Value.ToString();
                txt_gt.Text = row.Cells[4].Value.ToString();
                txt_dt.Text = row.Cells[6].Value.ToString();
                dateTimePickerNs.Text = row.Cells[2].Value.ToString();
                dateTimePickerNvd.Text = row.Cells[5].Value.ToString();
                rtx_dc.Text = row.Cells[3].Value.ToString();
                cbo_mcd.Text = row.Cells[7].Value.ToString();
            }
        }

        private void buttonXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                string madv = txt_mdv.Text;
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (DoanVienDAO.Instance.DeleteDoanVien(madv))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadDoanVien();
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string key = txt_search.Text;

            dv.DataSource = DoanVienDAO.Instance.SearchById(key);
        }
    }
}
