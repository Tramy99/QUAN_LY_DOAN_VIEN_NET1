using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DTO
{
    public class ChiDoan
    {
        public ChiDoan(string macd, string tencd)
        {
            this.Macd = macd;
            this.Tencd = tencd;
        }

        public ChiDoan(DataRow row)
        {
            this.Macd = row["macd"].ToString();
            this.Tencd = row["tencd"].ToString();
        }


        private string macd;
        private string tencd;

        public string Macd { get => macd; set => macd = value; }
        public string Tencd { get => tencd; set => tencd = value; }
    }
}
