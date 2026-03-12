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
            pnl_QLSV.BringToFront();
        }

        private void btn_QLSinhvien_Click(object sender, EventArgs e)
        {
            pnl_QLSV.BringToFront();
        }

        private void btn_QLLop_Click(object sender, EventArgs e)
        {
            pnl_Lop.BringToFront();
        }

    }
}
