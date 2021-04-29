using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_DOAN_VIEN.DAO
{
    class DiemDanhDAO
    {
        private static DiemDanhDAO instance;

        public static DiemDanhDAO Instance
        {
            get { if (instance == null) instance = new DiemDanhDAO(); return instance; }
            private set { instance = value; }
        }

        private DiemDanhDAO() { }

        public DataTable GetListDiemDanh()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT id as N'ID', madv as N'Mã đoàn viên', mahd as N'Mã hoạt động', ghichu as N'Ghi chú' FROM dbo.DiemDanh");
        }

        public bool InsertDiemDanh(int id, string madv, int mahd, string ghichu)
        {
            string query = string.Format("INSERT INTO DoanVien( id, madv, mahd, ghichu) VALUES ({0}, {1}, {2}, {3}, {4}", id, madv, mahd, ghichu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        internal bool UpdateDiemDanh(int id, string madv, int mahd, string ghichu)
        {
            throw new NotImplementedException();
        }

        internal bool DeleteDiemDanh(object madv)
        {
            throw new NotImplementedException();
        }
    }
}
