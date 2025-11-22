using DoAn_QuanLyQuanCaPhe.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyQuanCaPhe.DataAccess.DAO
{
    internal class SanPhamDAO
    {
        private static SanPhamDAO instance;
        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SanPhamDAO();
                }
                return SanPhamDAO.instance;
            }
            private set { SanPhamDAO.instance = value; }
            
        }
        private SanPhamDAO() { }
        public List<SanPham> GetFooddByCategoryID(int maDanhMuc)
        {
            List<SanPham> list = new List<SanPham>();
            string query = "select *from SanPham where MaDanhMuc ="+maDanhMuc;
            DataTable data=DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows) 
            {
                SanPham sanPham = new SanPham(item);
                list.Add(sanPham);

            }
            return list;

        }
        public List<SanPham> GetListSanPham()
        {
            List<SanPham> list = new List<SanPham>();
            string query = "select *from SanPham ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPham sanPham = new SanPham(item);
                list.Add(sanPham);

            }
            return list;
        }
    }
}
