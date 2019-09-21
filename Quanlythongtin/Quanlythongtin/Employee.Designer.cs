namespace Quanlythongtin
{
    partial class Employee
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
            this.btnExit = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.std = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literacy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.married = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.birthDay,
            this.gender,
            this.workingTime,
            this.address,
            this.std,
            this.literacy,
            this.workOn,
            this.workOff,
            this.nation,
            this.religion,
            this.department,
            this.role,
            this.email,
            this.married,
            this.workStatus,
            this.imgpath});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(953, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(891, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Mã nhân viên";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Họ tên";
            this.name.Name = "name";
            // 
            // birthDay
            // 
            this.birthDay.HeaderText = "Năm sinh";
            this.birthDay.Name = "birthDay";
            // 
            // gender
            // 
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            // 
            // workingTime
            // 
            this.workingTime.HeaderText = "Giờ làm";
            this.workingTime.Name = "workingTime";
            // 
            // address
            // 
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            // 
            // std
            // 
            this.std.HeaderText = "Số điện thoại";
            this.std.Name = "std";
            // 
            // literacy
            // 
            this.literacy.HeaderText = "Trình độ học vấn";
            this.literacy.Name = "literacy";
            // 
            // workOn
            // 
            this.workOn.HeaderText = "Ngày vào làm việc";
            this.workOn.Name = "workOn";
            // 
            // workOff
            // 
            this.workOff.HeaderText = "Ngày thôi việc";
            this.workOff.Name = "workOff";
            // 
            // nation
            // 
            this.nation.HeaderText = "Dân tộc";
            this.nation.Name = "nation";
            // 
            // religion
            // 
            this.religion.HeaderText = "Tôn giáo";
            this.religion.Name = "religion";
            // 
            // department
            // 
            this.department.HeaderText = "Bộ phận";
            this.department.Name = "department";
            // 
            // role
            // 
            this.role.HeaderText = "Chức vụ";
            this.role.Name = "role";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // married
            // 
            this.married.HeaderText = "Tình trạng hôn nhân";
            this.married.Name = "married";
            // 
            // workStatus
            // 
            this.workStatus.HeaderText = "Tình trạng nhân viên";
            this.workStatus.Name = "workStatus";
            // 
            // imgpath
            // 
            this.imgpath.HeaderText = "Đường dẫn file ảnh";
            this.imgpath.Name = "imgpath";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 304);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn std;
        private System.Windows.Forms.DataGridViewTextBoxColumn literacy;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn nation;
        private System.Windows.Forms.DataGridViewTextBoxColumn religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn married;
        private System.Windows.Forms.DataGridViewTextBoxColumn workStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgpath;
    }
}