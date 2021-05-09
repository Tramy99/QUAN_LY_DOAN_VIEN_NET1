using QUAN_LY_DOAN_VIEN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DAO
{
    public class ChiDoanDAO
    {
        private static ChiDoanDAO instance;

        public static ChiDoanDAO Instance
        {
            get { if (instance == null) instance = new ChiDoanDAO(); return ChiDoanDAO.instance; }
            private set { ChiDoanDAO.instance = value; }
        }

        private ChiDoanDAO() { }

        public List<ChiDoan> GetListMaChiDoan()
        {
            List<ChiDoan> list = new List<ChiDoan>();

            string query = "select * from ChiDoan";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChiDoan cd = new ChiDoan(item);
                list.Add(cd);
            }

            return list;
        }

        public DataTable GetListChiDoan()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT macd as N'Mã chi đoàn', tencd as N'Tên chi đoàn' FROM ChiDoan");
        }

        public bool InsertChiDoan(string macd, string tencd)
        {
            string query = "INSERT INTO ChiDoan (macd, tencd) VALUES ( N'" + macd + "', N'" + tencd + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateChiDoan(string macd, string tencd)
        {
            string query = "UPDATE ChiDoan SET tencd = N'" + tencd + "' WHERE macd = '" + macd + "' ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteChiDoan(string macd)
        {
            string query = string.Format("Delete ChiDoan where macd = N'{0}'", macd);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable SearchChiDoan(string key)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM ChiDoan WHERE macd LIKE '%" + key + "%' or tencd LIKE '%" + key + "%'");
        }
    }
}
