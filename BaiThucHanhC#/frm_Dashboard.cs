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
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            using (DataBaseDataContext db = new DataBaseDataContext()) 
            {
                //pnl_QLSV.BringToFront();

                var dsLop = db.tbl_Lops.ToList();
                cbb_MaLop.DataSource = dsLop;
                cbb_MaLop.DisplayMember = "MaLop";
                cbb_MaLop.ValueMember = "MaLop";
                FillForm(dgv_Lop, dsLop);

                LoadData_SV();
            }

        }

        private void btn_QLSinhvien_Click(object sender, EventArgs e)
        {
            pnl_QLSV.BringToFront();
        }

        private void btn_QLLop_Click(object sender, EventArgs e)
        {
            pnl_Lop.BringToFront();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //sự kiện double click vào 1 dòng trong datagridview để hiển thị thông tin chi tiết của sinh viên đó lên form
        private void dgv_SinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kiểm tra tránh click vào hàng tiêu đề
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgv_SinhVien.Rows[e.RowIndex];

                    // Hãy chắc chắn tên cột "MaSV" khớp với thiết kế Grid của bạn
                    if (row.Cells["MSSV"].Value == null) return;
                    string mssv = row.Cells["MSSV"].Value.ToString();

                    using (DataBaseDataContext db = new DataBaseDataContext())
                    {
                        // Tìm sinh viên có mã tương ứng
                        var sv = db.tbl_SinhViens.FirstOrDefault(s => s.MSSV == mssv);

                        if (sv != null)
                        {
                            // Đẩy dữ liệu lên Form - Dùng toán tử ?? "" để chống lỗi Null địa chỉ
                            txt_MSSV.Text = sv.MSSV ?? "";
                            txt_HoTen.Text = sv.HoTen ?? "";

                            // Lấy ĐỊA CHỈ từ DB 
                            txt_DiaChi.Text = sv.DiaChi ?? "";

                            // Lấy NGÀY SINH từ DB
                            dtp_NgaySinh.Value = sv.NgaySinh;

                            // Xử lý Giới tính (Dùng else if để logic chuẩn xác)
                            string gioitinh = sv.GioiTinh.Trim();
                            if (gioitinh == "Nam")
                                rdb_Nam.Checked = true;
                            else if (gioitinh == "Nữ")
                                rdb_Nu.Checked = true;
                            else
                                rdb_Khac.Checked = true;

                            // Xử lý ComboBox Lớp
                            if (sv.MaLop != null)
                            {
                                cbb_MaLop.SelectedValue = sv.MaLop;
                            }

                            txt_MSSV.ReadOnly = true;
                            txt_MSSV.BackColor = Color.LightGray;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy dữ liệu từ DB: " + ex.Message);
                }
            }
        }


        private void LoadData_SV()
        {
            try
            {
                using (DataBaseDataContext db = new DataBaseDataContext())
                {
                    var listSV = db.tbl_SinhViens.Select(s => new
                    {
                        s.MSSV,
                        s.HoTen,
                        s.NgaySinh,
                        s.GioiTinh,
                        s.MaLop,
                    }).ToList();
                    FillForm(dgv_SinhVien, listSV);

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadData_SV(string keyword = "")
        {
            using (DataBaseDataContext db = new DataBaseDataContext())
            {
                var data = db.tbl_SinhViens.AsQueryable();

                if (!string.IsNullOrEmpty(keyword))
                {
                    data = data.Where(s => s.HoTen.Contains(keyword) || s.MSSV.Contains(keyword));
                }

                dgv_SinhVien.DataSource = data.Select(s => new {
                    s.MSSV,
                    s.HoTen,
                    s.NgaySinh,
                    s.GioiTinh,
                    s.MaLop,
                }).ToList();
            }
        }

        private void ClearForm_SV()
        {
            txt_MSSV.Clear();
            txt_HoTen.Clear();
            txt_DiaChi.Clear();
            dtp_NgaySinh.Value = DateTime.Now;
            cbb_MaLop.SelectedIndex = 0;
            rdb_Nam.Checked = true;

            txt_MSSV.ReadOnly = false;
            txt_MSSV.BackColor = Color.White;

            LoadData_SV();
        }

        private void FillForm(DataGridView dgv, object data)
        {
            dgv.DataSource = data;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
        }

        private string LayGioiTinh()
        {
            if (rdb_Nam.Checked) return "Nam";
            if (rdb_Nu.Checked) return "Nữ";
            return "Khác";
        }

        //thêm sinh viên
        private void btn_Them_SV_Click(object sender, EventArgs e)
        {
            using (DataBaseDataContext db = new DataBaseDataContext())
            {
                tbl_SinhVien sv = new tbl_SinhVien
                {
                    MSSV = txt_MSSV.Text,
                    HoTen = txt_HoTen.Text,
                    NgaySinh = dtp_NgaySinh.Value,
                    GioiTinh = LayGioiTinh(),
                    MaLop = cbb_MaLop.SelectedValue.ToString(),
                    DiaChi = txt_DiaChi.Text
                };
                db.tbl_SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();
                MessageBox.Show("Thêm Sinh viên thành công");

                //Clear Form sai khi thêm sinh viên mới
                ClearForm_SV();
            }
        }

        //Sửa thông tin sinh viên
        private void btn_Sua_SV_Click(object sender, EventArgs e)
        {
            if (dgv_SinhVien.SelectedRows.Count > 0)
            {
                string mssv = dgv_SinhVien.SelectedRows[0].Cells["MSSV"].Value.ToString();
                using (DataBaseDataContext db = new DataBaseDataContext())
                {
                    var sv = db.tbl_SinhViens.FirstOrDefault(s => s.MSSV == mssv);
                    if (sv != null)
                    {
                        sv.HoTen = txt_HoTen.Text;
                        sv.NgaySinh = dtp_NgaySinh.Value;
                        sv.GioiTinh = LayGioiTinh();
                        sv.MaLop = cbb_MaLop.SelectedValue.ToString();
                        sv.DiaChi = txt_DiaChi.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thông tin Sinh viên thành công");
                        ClearForm_SV();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.");
            }
        }

        //xóa sinh viên
        private void btn_Xoa_SV_Click(object sender, EventArgs e)
        {
            if (dgv_SinhVien.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa sinh viên này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    string mssv = dgv_SinhVien.SelectedRows[0].Cells["MSSV"].Value.ToString();

                    using (DataBaseDataContext db = new DataBaseDataContext())
                    {
                        var sv = db.tbl_SinhViens.FirstOrDefault(s => s.MSSV == mssv);
                        if (sv != null)
                        {
                            db.tbl_SinhViens.DeleteOnSubmit(sv);
                            db.SubmitChanges();

                            MessageBox.Show("Xóa Sinh viên thành công");
                            ClearForm_SV();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
            }
        }

        //làm mới form
        private void btn_LamMoi_SV_Click(object sender, EventArgs e)
        {
            ClearForm_SV();
        }

        //tìm kiếm sinh viên theo tên, mã sinh viên hoặc lớp
        string dangQuanLy = "SinhVien"; // Biến toàn cục trong Form chính
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.Trim();

            switch (dangQuanLy)
            {
                case "SinhVien":
                    LoadData_SV(keyword);
                    break;
                case "Lop":
                    //LoadData_Lop(keyword);
                    break;
            }
        }

        //xem chi tiết lớp học
        private void btn_details_Click(object sender, EventArgs e)
        {
            frm_Class_Detals CDetails = new frm_Class_Detals();
            CDetails.ShowDialog();
        }
    }
}
