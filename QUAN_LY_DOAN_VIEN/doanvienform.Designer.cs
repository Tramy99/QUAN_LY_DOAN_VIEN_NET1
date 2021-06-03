
namespace QUAN_LY_DOAN_VIEN
{
    partial class doanvienform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doanvienform));
            this.dgv_doanvien = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tdv = new System.Windows.Forms.TextBox();
            this.txt_gt = new System.Windows.Forms.TextBox();
            this.txt_mdv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtx_dc = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerNvd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNs = new System.Windows.Forms.DateTimePicker();
            this.cbo_mcd = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_doanvien
            // 
            this.dgv_doanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_doanvien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_doanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanvien.Location = new System.Drawing.Point(1, 339);
            this.dgv_doanvien.Name = "dgv_doanvien";
            this.dgv_doanvien.RowHeadersWidth = 51;
            this.dgv_doanvien.RowTemplate.Height = 24;
            this.dgv_doanvien.Size = new System.Drawing.Size(1140, 352);
            this.dgv_doanvien.TabIndex = 23;
            this.dgv_doanvien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_doanvien_CellMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(339, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(469, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "DANH MỤC QUẢN LÝ ĐOÀN VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã Chi Đoàn:";
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonThoat.Location = new System.Drawing.Point(854, 704);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 37);
            this.buttonThoat.TabIndex = 24;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonXoa.Location = new System.Drawing.Point(630, 704);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 37);
            this.buttonXoa.TabIndex = 25;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click_1);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSua.Location = new System.Drawing.Point(406, 704);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 37);
            this.buttonSua.TabIndex = 26;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonThem.Location = new System.Drawing.Point(161, 704);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 37);
            this.buttonThem.TabIndex = 27;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Họ Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Giới Tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Quê Quán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(585, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ngày Vào Đoàn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(579, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Mã Đoàn Viên:";
            // 
            // txt_tdv
            // 
            this.txt_tdv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tdv.Location = new System.Drawing.Point(267, 155);
            this.txt_tdv.Name = "txt_tdv";
            this.txt_tdv.Size = new System.Drawing.Size(266, 30);
            this.txt_tdv.TabIndex = 22;
            // 
            // txt_gt
            // 
            this.txt_gt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gt.Location = new System.Drawing.Point(267, 209);
            this.txt_gt.Name = "txt_gt";
            this.txt_gt.Size = new System.Drawing.Size(266, 30);
            this.txt_gt.TabIndex = 22;
            // 
            // txt_mdv
            // 
            this.txt_mdv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mdv.Location = new System.Drawing.Point(751, 102);
            this.txt_mdv.Name = "txt_mdv";
            this.txt_mdv.Size = new System.Drawing.Size(252, 30);
            this.txt_mdv.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ngày  sinh:";
            // 
            // txt_dt
            // 
            this.txt_dt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dt.Location = new System.Drawing.Point(751, 206);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(252, 30);
            this.txt_dt.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(585, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Dân Tộc:";
            // 
            // rtx_dc
            // 
            this.rtx_dc.Location = new System.Drawing.Point(267, 255);
            this.rtx_dc.Name = "rtx_dc";
            this.rtx_dc.Size = new System.Drawing.Size(266, 62);
            this.rtx_dc.TabIndex = 30;
            this.rtx_dc.Text = "";
            // 
            // dateTimePickerNvd
            // 
            this.dateTimePickerNvd.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerNvd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNvd.Location = new System.Drawing.Point(751, 260);
            this.dateTimePickerNvd.Name = "dateTimePickerNvd";
            this.dateTimePickerNvd.Size = new System.Drawing.Size(252, 22);
            this.dateTimePickerNvd.TabIndex = 31;
            // 
            // dateTimePickerNs
            // 
            this.dateTimePickerNs.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerNs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNs.Location = new System.Drawing.Point(751, 156);
            this.dateTimePickerNs.Name = "dateTimePickerNs";
            this.dateTimePickerNs.Size = new System.Drawing.Size(252, 22);
            this.dateTimePickerNs.TabIndex = 32;
            // 
            // cbo_mcd
            // 
            this.cbo_mcd.FormattingEnabled = true;
            this.cbo_mcd.Location = new System.Drawing.Point(267, 106);
            this.cbo_mcd.Name = "cbo_mcd";
            this.cbo_mcd.Size = new System.Drawing.Size(266, 24);
            this.cbo_mcd.TabIndex = 33;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(406, 61);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(366, 22);
            this.txt_search.TabIndex = 34;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(307, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 22);
            this.label10.TabIndex = 35;
            this.label10.Text = "Tìm kiếm";
            // 
            // doanvienform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 753);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cbo_mcd);
            this.Controls.Add(this.dateTimePickerNs);
            this.Controls.Add(this.dateTimePickerNvd);
            this.Controls.Add(this.rtx_dc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_dt);
            this.Controls.Add(this.dgv_doanvien);
            this.Controls.Add(this.txt_gt);
            this.Controls.Add(this.txt_tdv);
            this.Controls.Add(this.txt_mdv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "doanvienform";
            this.Text = "Phần mềm quản lý đoàn viên - Quản lý Đoàn Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_doanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tdv;
        private System.Windows.Forms.TextBox txt_gt;
        private System.Windows.Forms.TextBox txt_mdv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtx_dc;
        private System.Windows.Forms.DateTimePicker dateTimePickerNvd;
        private System.Windows.Forms.DateTimePicker dateTimePickerNs;
        private System.Windows.Forms.ComboBox cbo_mcd;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label10;
    }
}