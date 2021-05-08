using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DAO
{
    public class XepLoaiDAO
    {
        private static XepLoaiDAO instance;

        public static XepLoaiDAO Instance
        {
            get { if (instance == null) instance = new XepLoaiDAO(); return instance; }
            private set { instance = value; }
        }

        private XepLoaiDAO() { }

        public DataTable GetListXepLoai()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT id as N'Mã xếp loại', madv as N'Mã đoàn viên', namhoc as N' Năm học', nhanxet as N' Nhận xét', xeploai as N'Xếp loại', mahd as N'Mã hoạt động' FROM XepLoai");
        }

        public DataTable SearchXepLoai(string key)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM XepLoai WHERE xeploai LIKE '%" + key + "%' or madv LIKE '%" + key + "%' ");
        }

        public bool InsertXepLoai(int id, string madv, int namhoc, string nhanxet, string xeploai, int mahd)
        {
            string query = "INSERT INTO XepLoai (id, madv, namhoc, nhanxet, xeploai, mahd) VALUES ( '" + id + "', N'" + madv + "', '" + namhoc + "', N'" + nhanxet + "', N'" + xeploai + "', '" + mahd + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query); 

            return result > 0;
        }

        internal bool UpdateXepLoai(int id, string madv, int namhoc, string nhanxet, string xeploai, int mahd)
        {
            string query = "UPDATE XepLoai SET madv = N'" + madv + "', namhoc = '" + namhoc + "', nhanxet = N'" + nhanxet + "', xeploai = N'" + xeploai + "', mahd = '" + mahd + "' WHERE ID = '" + id + "' ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        internal bool DeleteXepLoai(int id)
        {
            string query = string.Format("Delete XepLoai where ID = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

