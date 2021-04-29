using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DAO
{
    public class HoatDongDAO
    {
        private static HoatDongDAO instance;

        public static HoatDongDAO Instance
        {
            get { if (instance == null) instance = new HoatDongDAO(); return instance; }
            private set { instance = value; }
        }

        private HoatDongDAO() { }

        public DataTable GetListHoatDong()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT mahd as N'Mã hoạt động', tenhd as N'Tên hoạt động', thoigiantc as N' Thời gian tổ chức', ghichu as N' Ghi chú' FROM dbo.HoatDong");
        }

        public bool InsertHoatDong(int mahd, string tenhd, DateTime thoigiantc, string ghichu)
        {
            string query = string.Format("INSERT INTO HoatDong( mahd, tenhd, thoigiantc, ghichu) VALUES ({0}, {1}, {2}, {3}, {4}", mahd, tenhd, thoigiantc, ghichu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        internal bool UpdateHoatDong(int mahd, string tenhd, DateTime thoigiantc, string ghichu)
        {
            throw new NotImplementedException();
        }

        internal bool DeleteHoatDong(object madv)
        {
            throw new NotImplementedException();
        }
    }
}
