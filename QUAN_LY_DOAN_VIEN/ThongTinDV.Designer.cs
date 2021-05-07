
namespace QUAN_LY_DOAN_VIEN
{
    partial class ThongTinDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDV));
            this.dataGridViewThongtinDV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongtinDV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewThongtinDV
            // 
            this.dataGridViewThongtinDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongtinDV.Location = new System.Drawing.Point(-9, 147);
            this.dataGridViewThongtinDV.Name = "dataGridViewThongtinDV";
            this.dataGridViewThongtinDV.RowHeadersWidth = 51;
            this.dataGridViewThongtinDV.RowTemplate.Height = 24;
            this.dataGridViewThongtinDV.Size = new System.Drawing.Size(1165, 408);
            this.dataGridViewThongtinDV.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DVToolStripMenuItem,
            this.CDToolStripMenuItem,
            this.DDToolStripMenuItem,
            this.HDToolStripMenuItem,
            this.XLToolStripMenuItem,
            this.KTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DVToolStripMenuItem
            // 
            this.DVToolStripMenuItem.Name = "DVToolStripMenuItem";
            this.DVToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.DVToolStripMenuItem.Text = "Đoàn viên";
            // 
            // CDToolStripMenuItem
            // 
            this.CDToolStripMenuItem.Name = "CDToolStripMenuItem";
            this.CDToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.CDToolStripMenuItem.Text = "Chi đoàn";
            this.CDToolStripMenuItem.Click += new System.EventHandler(this.CDToolStripMenuItem_Click);
            // 
            // DDToolStripMenuItem
            // 
            this.DDToolStripMenuItem.Name = "DDToolStripMenuItem";
            this.DDToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.DDToolStripMenuItem.Text = "Điểm danh";
            this.DDToolStripMenuItem.Click += new System.EventHandler(this.DDToolStripMenuItem_Click);
            // 
            // HDToolStripMenuItem
            // 
            this.HDToolStripMenuItem.Name = "HDToolStripMenuItem";
            this.HDToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.HDToolStripMenuItem.Text = "Hoạt động";
            // 
            // XLToolStripMenuItem
            // 
            this.XLToolStripMenuItem.Name = "XLToolStripMenuItem";
            this.XLToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.XLToolStripMenuItem.Text = "Xếp loại";
            // 
            // KTToolStripMenuItem
            // 
            this.KTToolStripMenuItem.Name = "KTToolStripMenuItem";
            this.KTToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.KTToolStripMenuItem.Text = "Khen thưởng";
            // 
            // ThongTinDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 545);
            this.Controls.Add(this.dataGridViewThongtinDV);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1400, 1200);
            this.MinimumSize = new System.Drawing.Size(1000, 47);
            this.Name = "ThongTinDV";
            this.Text = "Thông Tin Đoàn Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongtinDV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewThongtinDV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KTToolStripMenuItem;
    }
}