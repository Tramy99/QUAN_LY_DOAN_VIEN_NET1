using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DTO
{
    public class KhenThuong
    {
        public KhenThuong(int makt, string madv, string tenkt, string thanhtich, int namhoc)
        {
            this.Makt = makt;
            this.Madv = madv;
            this.Tenkt = tenkt;
            this.Thanhtich = thanhtich;
            this.Namhoc = namhoc;
        }

        public KhenThuong(DataRow row)
        {
            this.Makt = (int)row["makt"];
            this.Madv = row["madv"].ToString();
            this.Tenkt = row["tenkt"].ToString();
            this.Thanhtich = row["thanhtich"].ToString();
            this.Namhoc = (int)row["namhoc"];
        }
        private int makt;
        private string madv;
        private string tenkt;
        private string thanhtich;
        private int namhoc;

        public int Makt { get => makt; set => makt = value; }
        public string Madv { get => madv; set => madv = value; }
        public string Tenkt { get => tenkt; set => tenkt = value; }
        public string Thanhtich { get => thanhtich; set => thanhtich = value; }
        public int Namhoc { get => namhoc; set => namhoc = value; }
    }
}
