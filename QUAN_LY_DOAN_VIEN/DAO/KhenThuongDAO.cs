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
            return DataProvider.Instance.ExecuteQuery("SELECT makt as N'ID', madv as N'Mã đoàn viên', namhoc as N' Năm học', tenkt as N'Tên Khen Thưởng', thanhtich as N'Thành Tích' , namhoc as N'Năm Học' FROM dbo.KhenThuong");
        }

        public bool InsertKhenThuong(int Makt, string Madv, string Tenkt, string Thanhtich, int Namhoc)
        {
            string query = "INSERT INTO KhenThuong (makt, madv, tenkt, thanhtich, namhoc) VALUES ( '" + Makt + "','" + Madv + "','" + Tenkt + "','" + Thanhtich + "','" + Namhoc + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        internal bool UpdateKhenThuong(int Makt, string Madv, string Tenkt, string Thanhtich, int Namhoc)
        {
            string query = "UPDATE KhenThuong SET madv = '" + Madv + "', tenkt = '" + Tenkt + "', thanhtich = '" + Thanhtich + "', namhoc = '" + Namhoc + "' WHERE makt = '" + Makt + "' ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        internal bool DeleteKhenThuong(int Makt)
        {
            string query = string.Format("Delete KhenThuong where makt = '{0}'", Makt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
