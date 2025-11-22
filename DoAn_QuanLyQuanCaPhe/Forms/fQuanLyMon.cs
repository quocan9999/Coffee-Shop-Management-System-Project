using DoAn_QuanLyQuanCaPhe.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyQuanCaPhe.Forms
{
    public partial class fQuanLyMon : Form
    {
        public fQuanLyMon()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListSanPham();          
        }
                
        private void Sửa_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)       
        {

        }

        private void btnThem_Click(object sender, EventArgs e)  
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
        void LoadListSanPham()
        {


            grvMon.DataSource = SanPhamDAO.Instance.GetListSanPham();
            if (grvMon.Columns["TrangThai"] != null)
            {
                foreach (DataGridViewRow row in grvMon.Rows)
                {
                    if (row.Cells["TrangThai"].Value != null && row.Cells["TrangThai"].Value != DBNull.Value)
                    {
                        bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
                        row.Cells["TrangThai"].Value = trangThai ? "Còn hàng" : "Hết hàng";
                    }
                }
            }
        }
    }
}
