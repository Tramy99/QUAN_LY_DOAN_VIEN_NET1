using QUAN_LY_DOAN_VIEN.DTO;
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

        public List<HoatDong> GetListMaHoatDong()
        {
            List<HoatDong> list = new List<HoatDong>();

            string query = "select * from HoatDong";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HoatDong hd = new HoatDong(item);
                list.Add(hd);
            }

            return list;
        }


        public DataTable GetListHoatDong()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT mahd as N'Mã hoạt động', tenhd as N'Tên hoạt động', thoigiantc as N' Thời gian tổ chức', ghichu as N' Ghi chú' FROM HoatDong");
        }

        public DataTable Search(string key)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM HoatDong WHERE mahd LIKE '%" + key + "%' or tenhd LIKE '%" + key + "%' ");
        }

        public bool InsertHoatDong(int mahd, string tenhd, DateTime thoigiantc, string ghichu)
        {
            string query = "INSERT INTO HoatDong (mahd, tenhd, thoigiantc, ghichu) VALUES ( '" + mahd + "', N'" + tenhd + "', '" + thoigiantc + "', N'" + ghichu + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        internal bool UpdateHoatDong(int mahd, string tenhd, DateTime thoigiantc, string ghichu)
        {
            string query = "UPDATE HoatDong SET tenhd = N'" + tenhd + "', thoigiantc = '" + thoigiantc + "', ghichu = N'" + ghichu + "' WHERE mahd ='" + mahd + "' ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        internal bool DeleteHoatDong(int mahd)
        {
            string query = string.Format("Delete HoatDong where mahd = {0}", mahd);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
