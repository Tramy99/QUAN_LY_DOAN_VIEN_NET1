using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable GetListDoanVien()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT madv as N'Mã đoàn viên', tendv as N'Tên đoàn viên', ns as N'Ngày sinh', que as N'Quê quán',gioitinh as N'Giới tính', ngayvd as N'Ngày vào đoàn', dt as N'Dân tộc', macd as N'Mã chi đoàn' FROM DoanVien");
        }

        public DataTable SearchById(string madv)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM DoanVien WHERE madv LIKE '%" + madv + "%' ");
        }

        public bool InsertDoanVien(string madv, string tendv, DateTime ns, string que, string gioitinh, DateTime ngayvd, string dt, string macd)
        {
            string query = "INSERT INTO DoanVien( madv, tendv, ns, que, gioitinh, ngayvd, dt, macd) VALUES ('" + madv + "','" + tendv + "','" + ns + "','" + que + "','" + gioitinh + "','" + ngayvd + "','" + dt + "','" + macd + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        internal bool UpdateDoanVien(string tendv, DateTime ns, string que, string gioitinh, DateTime ngayvd, string dt, string macd, string madv)
        {
            string query = "UPDATE DoanVien SET tendv = '" + tendv + "', ns = '" + ns.ToString("yyyy-MM-dd") + "', que = '" + que + "', gioitinh = '" + gioitinh + "', ngayvd = '" + ngayvd.ToString("yyyy-MM-dd") + "', dt = '" + dt + "', macd = '" + macd + "' WHERE madv = '" + madv + "' ";
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
