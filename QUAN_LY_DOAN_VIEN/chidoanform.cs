using QUAN_LY_DOAN_VIEN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_DOAN_VIEN
{
    public partial class chidoanform : Form
    {
        BindingSource cd = new BindingSource();

        public chidoanform()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            dgv_cd.DataSource = cd;

            LoadChiDoan();
        }

        void Clear()
        {
            txtmachidoan.Clear();
            txttenchidoan.Clear();
        }

        private void LoadChiDoan()
        {
            cd.DataSource = ChiDoanDAO.Instance.GetListChiDoan();
        }

        private void btn_Thoatcd_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                this.Close();
        }

        private void btn_Themchidoan_Click(object sender, EventArgs e)
        {
            try
            {
                string macd = txtmachidoan.Text;
                string tencd = txttenchidoan.Text;

                if (ChiDoanDAO.Instance.InsertChiDoan(macd, tencd))
                {
                    MessageBox.Show("Thêm mới thành công!");
                    LoadChiDoan();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại! ");
                }
            }
            catch { }
        }

        private void btn_Suachidoan_Click(object sender, EventArgs e)
        {
            string macd = txtmachidoan.Text;
            string tencd = txttenchidoan.Text;

            if (ChiDoanDAO.Instance.UpdateChiDoan(macd, tencd))
            {
                MessageBox.Show("Sửa thành công!");
                LoadChiDoan();
                Clear();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btn_Xoachidoan_Click(object sender, EventArgs e)
        {
            try
            {
                string macd = txtmachidoan.Text;

                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (ChiDoanDAO.Instance.DeleteChiDoan(macd))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadChiDoan();
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
               
        private void dgv_cd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_cd.Rows[e.RowIndex];
                txtmachidoan.Text = row.Cells[0].Value.ToString();
                txttenchidoan.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
