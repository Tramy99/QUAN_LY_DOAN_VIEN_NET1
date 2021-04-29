using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DTO
{
    public class HoatDong
    {
        public HoatDong(int mahd, string tenhd, DateTime thoigiantc, string ghichu)
        {
            this.Mahd = mahd;
            this.Tenhd = tenhd;
            this.Thoigiantc = thoigiantc;
            this.Ghichu = ghichu;
        }

        public HoatDong(DataRow row)
        {
            this.Mahd = (int)row["mahd"];
            this.Tenhd = row["tenhd"].ToString();
            this.Thoigiantc = (DateTime)Convert.ToDateTime(row["thoigiantc"].ToString());
            this.Ghichu = row["ghichu"].ToString();
        }

        private int mahd;
        private string tenhd;
        private DateTime thoigiantc;
        private string ghichu;
        public int Mahd { get => mahd; set => mahd = value; }
        public string Tenhd { get => tenhd; set => tenhd = value; }
        public DateTime Thoigiantc { get => thoigiantc; set => thoigiantc = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
