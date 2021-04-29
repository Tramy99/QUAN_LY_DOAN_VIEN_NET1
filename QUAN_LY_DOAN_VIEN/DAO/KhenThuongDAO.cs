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
            return DataProvider.Instance.ExecuteQuery("SELECT id as N'ID', madv as N'Mã đoàn viên', namhoc as N' Năm học', nhanxet as N' Nhận xét',xeploai as N'Xếp loại',mahd as N'Mã hoạt động' FROM dbo.XepLoai");
        }

        public bool InsertKhenThuong(int id, string madv, int namhoc, string nhanxet, string xeploai, int mahd)
        {
            string query = string.Format("INSERT INTO XepLoai( id, madv, namhoc, nhanxet,xeploai,mahd) VALUES ({0}, {1}, {2}, {3}, {4},{5},{6}", id, madv, namhoc, nhanxet, xeploai, mahd);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        internal bool UpdateKhenThuong(int id, string madv, int namhoc, string nhanxet, string xeploai, int mahd)
        {
            throw new NotImplementedException();
        }


        internal bool DeleteKhenThuong(object madv)
        {
            throw new NotImplementedException();
        }
    }
}
