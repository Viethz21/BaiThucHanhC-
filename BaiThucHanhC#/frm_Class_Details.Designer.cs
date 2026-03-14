namespace BaiThucHanhC_
{
    partial class frm_Class_Detals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.lb_Siso = new System.Windows.Forms.Label();
            this.lb_Number_Siso = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_Ten_Lop = new System.Windows.Forms.Label();
            this.lb_TenLop = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_details
            // 
            this.dgv_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_details.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_MaSV,
            this.txt_Hoten,
            this.txt_Gioitinh,
            this.txt_Ngaysinh,
            this.txt_Diem});
            this.dgv_details.Location = new System.Drawing.Point(18, 199);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.RowHeadersWidth = 51;
            this.dgv_details.RowTemplate.Height = 24;
            this.dgv_details.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_details.Size = new System.Drawing.Size(636, 239);
            this.dgv_details.TabIndex = 0;
            // 
            // lb_Siso
            // 
            this.lb_Siso.AutoSize = true;
            this.lb_Siso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Siso.Location = new System.Drawing.Point(12, 73);
            this.lb_Siso.Name = "lb_Siso";
            this.lb_Siso.Size = new System.Drawing.Size(99, 32);
            this.lb_Siso.TabIndex = 1;
            this.lb_Siso.Text = "Sĩ số: ";
            this.lb_Siso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Number_Siso
            // 
            this.lb_Number_Siso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Number_Siso.Location = new System.Drawing.Point(107, 73);
            this.lb_Number_Siso.Name = "lb_Number_Siso";
            this.lb_Number_Siso.Size = new System.Drawing.Size(63, 32);
            this.lb_Number_Siso.TabIndex = 2;
            this.lb_Number_Siso.Text = "8";
            this.lb_Number_Siso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Number_Siso.Click += new System.EventHandler(this.lb_Number_Click);
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.HeaderText = "Mã SV";
            this.txt_MaSV.MinimumWidth = 6;
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.ReadOnly = true;
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.HeaderText = "Họ tên";
            this.txt_Hoten.MinimumWidth = 6;
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.ReadOnly = true;
            // 
            // txt_Gioitinh
            // 
            this.txt_Gioitinh.HeaderText = "Giới tính";
            this.txt_Gioitinh.MinimumWidth = 6;
            this.txt_Gioitinh.Name = "txt_Gioitinh";
            this.txt_Gioitinh.ReadOnly = true;
            // 
            // txt_Ngaysinh
            // 
            this.txt_Ngaysinh.HeaderText = "Ngày Sinh";
            this.txt_Ngaysinh.MinimumWidth = 6;
            this.txt_Ngaysinh.Name = "txt_Ngaysinh";
            // 
            // txt_Diem
            // 
            this.txt_Diem.HeaderText = "Điểm số";
            this.txt_Diem.MinimumWidth = 6;
            this.txt_Diem.Name = "txt_Diem";
            this.txt_Diem.ReadOnly = true;
            // 
            // lb_Ten_Lop
            // 
            this.lb_Ten_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ten_Lop.Location = new System.Drawing.Point(143, 27);
            this.lb_Ten_Lop.Name = "lb_Ten_Lop";
            this.lb_Ten_Lop.Size = new System.Drawing.Size(478, 32);
            this.lb_Ten_Lop.TabIndex = 4;
            this.lb_Ten_Lop.Text = "C# WinForm";
            this.lb_Ten_Lop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_TenLop
            // 
            this.lb_TenLop.AutoSize = true;
            this.lb_TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenLop.Location = new System.Drawing.Point(12, 27);
            this.lb_TenLop.Name = "lb_TenLop";
            this.lb_TenLop.Size = new System.Drawing.Size(125, 32);
            this.lb_TenLop.TabIndex = 3;
            this.lb_TenLop.Text = "Tên lớp:";
            this.lb_TenLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(305, 160);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(236, 22);
            this.txt_TimKiem.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm theo Mã SV,Tên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Silver;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(557, 129);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(80, 53);
            this.btn_TimKiem.TabIndex = 7;
            this.btn_TimKiem.Text = "Tìm ";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // frm_Class_Detals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.lb_Ten_Lop);
            this.Controls.Add(this.lb_TenLop);
            this.Controls.Add(this.lb_Number_Siso);
            this.Controls.Add(this.lb_Siso);
            this.Controls.Add(this.dgv_details);
            this.Name = "frm_Class_Detals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết lớp học";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.Label lb_Siso;
        private System.Windows.Forms.Label lb_Number_Siso;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Diem;
        private System.Windows.Forms.Label lb_Ten_Lop;
        private System.Windows.Forms.Label lb_TenLop;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}