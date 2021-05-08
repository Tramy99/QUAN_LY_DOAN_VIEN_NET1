using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DAO
{
    public class KhenThuongDAO
    {
        private static KhenThuongDAO instance;

        public static KhenThuongDAO Instance
        {
            get { if (instance == null) instance = new KhenThuongDAO(); return instance; }
            private set { instance = value; }
        }

        private KhenThuongDAO() { }

        public DataTable GetListKhenThuong()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT makt as N'Má khen thưởng', madv as N'Mã đoàn viên', namhoc as N'Năm học', tenkt as N'Tên Khen Thưởng', thanhtich as N'Thành Tích' , namhoc as N'Năm Học' FROM KhenThuong");
        }

        public bool InsertKhenThuong(int Makt, string Madv, string Tenkt, string Thanhtich, int Namhoc)
        {
            string query = "INSERT INTO KhenThuong (makt, madv, tenkt, thanhtich, namhoc) VALUES ( '" + Makt + "', N'" + Madv + "', N'" + Tenkt + "', N'" + Thanhtich + "', '" + Namhoc + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        internal bool UpdateKhenThuong(int Makt, string Madv, string Tenkt, string Thanhtich, int Namhoc)
        {
            string query = "UPDATE KhenThuong SET madv = N'" + Madv + "', tenkt = N'" + Tenkt + "', thanhtich = N'" + Thanhtich + "', namhoc = '" + Namhoc + "' WHERE makt = '" + Makt + "' ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        internal bool DeleteKhenThuong(int Makt)
        {
            string query = string.Format("Delete KhenThuong where makt = '{0}'", Makt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable SearchKhenThuong(string key)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM KhenThuong WHERE madv LIKE '%" + key + "%' ");
        }
    }
}
