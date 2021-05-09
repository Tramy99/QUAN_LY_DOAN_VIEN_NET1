using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DAO
{
    public class DiemDanhDAO
    {
        private static DiemDanhDAO instance;

        public static DiemDanhDAO Instance
        {
            get { if (instance == null) instance = new DiemDanhDAO(); return DiemDanhDAO.instance; }
            private set { DiemDanhDAO.instance = value; }
        }

        private DiemDanhDAO() { }

        public DataTable GetListDiemDanh()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT DiemDanh.id as N'Mã diểm danh', HoatDong.tenhd as N'Tên Hoạt Động', madv as N'Mã đoàn viên', DiemDanh.ghichu as N'Ghi chú' FROM DiemDanh join HoatDong on DiemDanh.mahd=HoatDong.mahd");
        }

        public bool InsertDiemDanh(int id, string madv, int mahd, string ghichu)
        {
            string query = "INSERT INTO DiemDanh (id, madv, mahd, ghichu) VALUES ( '" + id + "', N'" + madv + "', '" + mahd + "', N'" + ghichu + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        internal bool UpdateDiemDanh(int id, string madv, int mahd, string ghichu)
        {
            string query = "UPDATE DiemDanh SET madv = N'" + madv + "', mahd = '" + mahd + "', ghichu = N'" + ghichu + "' WHERE id ='" + id + "' ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        internal bool DeleteDiemDanh(int id)
        {
            string query = string.Format("Delete DiemDanh where Id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable SearchDiemDanh(string key)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT DiemDanh.id as N'Mã diểm danh', HoatDong.tenhd as N'Tên Hoạt Động', madv as N'Mã đoàn viên', DiemDanh.ghichu as N'Ghi chú' FROM DiemDanh join HoatDong on DiemDanh.mahd=HoatDong.mahd" +
                " WHERE DiemDanh.madv LIKE '%" + key + "%'" +
                " or HoatDong.tenhd LIKE N'%" + key + "%'" +
                " or DiemDanh.ghichu LIKE N'%" + key + "%'");
        }
    }
}
