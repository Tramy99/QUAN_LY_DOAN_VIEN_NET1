﻿using QUAN_LY_DOAN_VIEN.DAO;
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
    public partial class themtaikhoanform : Form
    {
        public themtaikhoanform()
        {
            InitializeComponent();
        }

        private void btn_saveTHE_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = textBox_TenTK.Text;
                string passWord = textBox_Matkhau.Text;
                int type = (comboBox1.SelectedIndex);

                if (AccountDAO.Instance.InsertAccount(userName, passWord, type))
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại!");
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Có phải bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                this.Close();
            else
            {
            }
        }
    }
}