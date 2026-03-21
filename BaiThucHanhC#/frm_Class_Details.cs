using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhC_
{
    public partial class frm_Class_Detals : Form
    {

        string maLop;
        public frm_Class_Detals(string maLop)
        {
            InitializeComponent();
            this.maLop = maLop;
        }

        private void lb_Number_Click(object sender, EventArgs e)
        {

        }

        private void frm_Class_Detals_Load(object sender, EventArgs e)
        {
            using (DataBaseDataContext db = new DataBaseDataContext())
            {
                var lop = db.tbl_Lops.FirstOrDefault(l => l.MaLop == maLop);
                if (lop != null)
                {
                    lb_Ten_Lop.Text = lop.TenLop;
                    //txt_Khoa.Text = lop.Khoa;
                }

                int siSo = db.tbl_SinhViens.Count(sv => sv.MaLop == maLop);
                lb_Number_Siso.Text = siSo.ToString();

                var ds = db.tbl_SinhViens
                           .Where(sv => sv.MaLop == maLop)
                           .Select(sv => new
                           {
                               sv.MSSV,
                               sv.HoTen,
                               sv.GioiTinh,
                               sv.NgaySinh,
                           });

                dgv_details.DataSource = ds.ToList();
            }
        }

        private void LoadData_SV(string keyword = "")
        {
            using (DataBaseDataContext db = new DataBaseDataContext())
            {
                var data = db.tbl_SinhViens
                             .Where(s => s.MaLop == maLop);

                if (!string.IsNullOrEmpty(keyword))
                {
                    data = data.Where(s =>
                        s.HoTen.Contains(keyword) ||
                        s.MSSV.Contains(keyword)
                    );
                }

                dgv_details.DataSource = data.Select(s => new
                {
                    s.MSSV,
                    s.HoTen,
                    s.GioiTinh,
                    s.NgaySinh
                }).ToList();
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData_SV(txt_TimKiem.Text);
        }
    }
}
