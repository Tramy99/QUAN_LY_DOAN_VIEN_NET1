using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DTO
{
    public class DiemDanh
    {
        public DiemDanh(int Id, string madv, int mahd, string ghichu)
        {        
            this.Id = id;
            this.Madv = madv;
            this.Mahd = mahd;
            this.Ghichu = ghichu;
        }

        public DiemDanh(DataRow row)
        {
            this.Id= (int)row["Id"];
            this.Madv = row["madv"].ToString();
            this.Mahd = (int)row["mahd"];
            this.Ghichu = row["ghichu"].ToString();
        }
        private int id;
        private string madv;
        private int mahd;
        private string ghichu;

        public int Id { get => id; set => id = value; }
        public string Madv { get => madv; set => madv = value; }
        public int Mahd { get => mahd; set => mahd = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}

