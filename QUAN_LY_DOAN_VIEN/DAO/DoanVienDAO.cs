using QUAN_LY_DOAN_VIEN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DAO
{

    public class DoanVienDAO
    {
        private static DoanVienDAO instance;

        public static DoanVienDAO Instance
        {
            get { if (instance == null) instance = new DoanVienDAO(); return instance; }
            private set { instance = value; }
        }

        private DoanVienDAO() { }
        //phuong thuc lay danh sach doan vien
        public List<DoanVien> GetListMaDoanVien()
        {
            List<DoanVien> list = new List<DoanVien>();

            string query = "select * from DoanVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DoanVien dv = new DoanVien(item);
                list.Add(dv);
            }

            return list;
        }
        
        public DataTable GetListDoanVien()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT madv as N'Mã đoàn viên', tendv as N'Tên đoàn viên', convert(varchar, ns, 105) as N'Ngày sinh', que as N'Quê quán',gioitinh as N'Giới tính', convert(varchar, ngayvd, 105) as N'Ngày vào đoàn', dt as N'Dân tộc', macd as N'Mã chi đoàn' FROM DoanVien");
        }

        public bool CheckDoanVien(string madv)
        {
            DataTable da = DataProvider.Instance.ExecuteQuery("Select * FROM DoanVien where madv = '" + madv + "'");
            return da.Rows.Count >= 1;
        }

        public DataTable SearchById(string key)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT madv as N'Mã đoàn viên', tendv as N'Tên đoàn viên', convert(varchar, ns, 105) as N'Ngày sinh', que as N'Quê quán',gioitinh as N'Giới tính', convert(varchar, ngayvd, 105) as N'Ngày vào đoàn', dt as N'Dân tộc', macd as N'Mã chi đoàn' FROM DoanVien" +
                " WHERE madv LIKE '%" + key + "%' " +
                "or tendv LIKE N'%" + key + "%' " +
                "or que LIKE N'%" + key + "%' " +
                "or gioitinh LIKE N'%" + key + "%' " +
                "or macd LIKE '%" + key + "%' ");
        }

        public bool InsertDoanVien(string madv, string tendv, DateTime ns, string que, string gioitinh, DateTime ngayvd, string dt, string macd)
        {
            string query = "INSERT INTO DoanVien( madv, tendv, ns, que, gioitinh, ngayvd, dt, macd) VALUES (N'" + madv + "', N'" + tendv + "','" + ns + "', N'" + que + "', N'" + gioitinh + "', '" + ngayvd + "', N'" + dt + "', N'" + macd + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        internal bool UpdateDoanVien(string tendv, DateTime ns, string que, string gioitinh, DateTime ngayvd, string dt, string macd, string madv)
        {
            string query = "UPDATE DoanVien SET tendv = N'" + tendv + "', ns = '" + ns.ToString("yyyy-MM-dd") + "', que = N'" + que + "', gioitinh = N'" + gioitinh + "', ngayvd = '" + ngayvd.ToString("yyyy-MM-dd") + "', dt = N'" + dt + "', macd = N'" + macd + "' WHERE madv = N'" + madv + "' ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        internal bool DeleteDoanVien(string madv)
        {
            string query = string.Format("Delete DoanVien where madv = N'{0}'", madv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
