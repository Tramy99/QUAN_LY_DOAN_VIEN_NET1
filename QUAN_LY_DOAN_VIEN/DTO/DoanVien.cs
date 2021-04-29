using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DTO
{
    public class DoanVien
    {
        public DoanVien(string madv, string tendv, DateTime ns, string que, string gioitinh, DateTime ngayvd, string dt, string macd)
        {
            this.Madv = madv;
            this.Tendv = tendv;
            this.Ns = ns;
            this.Que = que;
            this.Ngayvd = ngayvd;
            this.Gioitinh = gioitinh;
            this.Dt = dt;
            this.Macd = macd;
        }

        public DoanVien(DataRow row)
        {
            this.Madv = row["madv"].ToString();
            this.Tendv = row["tendv"].ToString();
            this.Ns = (DateTime)Convert.ToDateTime(row["ns"].ToString());
            this.Que = row["que"].ToString();
            this.Gioitinh = row["gioitinh"].ToString();
            this.Ngayvd = (DateTime)Convert.ToDateTime(row["ngayvd"].ToString());
            this.Dt = row["dt"].ToString();
            this.Macd = row["macd"].ToString();
        }

        private string madv;
        private string tendv;
        private DateTime ns;
        private string que;
        private string gioitinh;
        private DateTime ngayvd;
        private string dt;
        private string macd;

        public string Madv { get => madv; set => madv = value; }
        public string Tendv { get => tendv; set => tendv = value; }
        public DateTime Ns { get => ns; set => ns = value; }
        public string Que { get => que; set => que = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngayvd { get => ngayvd; set => ngayvd = value; }
        public string Dt { get => dt; set => dt = value; }
        public string Macd { get => macd; set => macd = value; }
    }
}
