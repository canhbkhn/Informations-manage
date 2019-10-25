namespace StudentManage
{
    partial class Student
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtranghocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvaohoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythoihoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lydothoihoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtrungbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.shhs,
            this.cmnd,
            this.namsinh,
            this.gioitinh,
            this.lop,
            this.diachi,
            this.Sodienthoai,
            this.dantoc,
            this.tongiao,
            this.chucvu,
            this.email,
            this.tinhtranghocsinh,
            this.ngayvaohoc,
            this.ngaythoihoc,
            this.lydothoihoc,
            this.diemtrungbinh,
            this.hocky,
            this.namhoc,
            this.imgpath,
            this.img});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1207, 452);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Họ tên";
            this.name.Name = "name";
            // 
            // shhs
            // 
            this.shhs.HeaderText = "Số hiệu học sinh";
            this.shhs.Name = "shhs";
            // 
            // cmnd
            // 
            this.cmnd.HeaderText = "Số cmnd";
            this.cmnd.Name = "cmnd";
            // 
            // namsinh
            // 
            this.namsinh.HeaderText = "Năm sinh";
            this.namsinh.Name = "namsinh";
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // lop
            // 
            this.lop.HeaderText = "Lớp";
            this.lop.Name = "lop";
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.HeaderText = "Số điện thoại";
            this.Sodienthoai.Name = "Sodienthoai";
            // 
            // dantoc
            // 
            this.dantoc.HeaderText = "Dân tộc";
            this.dantoc.Name = "dantoc";
            // 
            // tongiao
            // 
            this.tongiao.HeaderText = "Tôn giáo";
            this.tongiao.Name = "tongiao";
            // 
            // chucvu
            // 
            this.chucvu.HeaderText = "Chức vụ";
            this.chucvu.Name = "chucvu";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // tinhtranghocsinh
            // 
            this.tinhtranghocsinh.HeaderText = "Tình trạng học sinh";
            this.tinhtranghocsinh.Name = "tinhtranghocsinh";
            // 
            // ngayvaohoc
            // 
            this.ngayvaohoc.HeaderText = "Ngày vào học";
            this.ngayvaohoc.Name = "ngayvaohoc";
            // 
            // ngaythoihoc
            // 
            this.ngaythoihoc.HeaderText = "Ngày thôi học";
            this.ngaythoihoc.Name = "ngaythoihoc";
            // 
            // lydothoihoc
            // 
            this.lydothoihoc.HeaderText = "Lý do thôi học";
            this.lydothoihoc.Name = "lydothoihoc";
            // 
            // diemtrungbinh
            // 
            this.diemtrungbinh.HeaderText = "Điểm trung bình";
            this.diemtrungbinh.Name = "diemtrungbinh";
            // 
            // hocky
            // 
            this.hocky.HeaderText = "Học kỳ";
            this.hocky.Name = "hocky";
            // 
            // namhoc
            // 
            this.namhoc.HeaderText = "Năm học";
            this.namhoc.Name = "namhoc";
            // 
            // imgpath
            // 
            this.imgpath.HeaderText = "Đường dẫn file ảnh";
            this.imgpath.Name = "imgpath";
            // 
            // img
            // 
            this.img.HeaderText = "Hình ảnh";
            this.img.Name = "img";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1144, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 505);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn shhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtranghocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayvaohoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythoihoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn lydothoihoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtrungbinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn img;
    }
}