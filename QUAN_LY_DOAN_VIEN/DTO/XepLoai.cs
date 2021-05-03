using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DTO
{
    public class XepLoai
    {
        public XepLoai(int id, string madv, int namhoc, string nhanxet, string xeploai, int mahd)
        {
            this.ID1 = id;
            this.Madv = madv;
            this.Namhoc = namhoc;
            this.Nhanxet = nhanxet;
            this.Xeploai = xeploai;
            this.Mahd = mahd;
        }

        public XepLoai(DataRow row)
        {
            this.ID1 = (int)row["ID"];
            this.Madv = row["madv"].ToString();
            this.Namhoc = (int)row["namhoc"];
            this.Nhanxet = row["nhanxet"].ToString();
            this.Xeploai = row["xeploai"].ToString();
            this.Mahd = (int)row["mahd"];
        }

        private int ID;
        private string madv;
        private int namhoc;
        private string nhanxet;
        private string xeploai;
        private int mahd;

        public string Madv { get => madv; set => madv = value; }
        public int Namhoc { get => namhoc; set => namhoc = value; }
        public string Nhanxet { get => nhanxet; set => nhanxet = value; }
        public string Xeploai { get => xeploai; set => xeploai = value; }
        public int Mahd { get => mahd; set => mahd = value; }
        public int ID1 { get => ID; set => ID = value; }
    }
}
