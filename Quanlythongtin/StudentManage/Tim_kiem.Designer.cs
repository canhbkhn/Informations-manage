namespace StudentManage
{
    partial class Tim_kiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbHoten = new System.Windows.Forms.Label();
            this.lbMshs = new System.Windows.Forms.Label();
            this.btnXemtatca = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbHoten);
            this.groupBox1.Controls.Add(this.lbMshs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(30, 119);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(54, 13);
            this.lbHoten.TabIndex = 1;
            this.lbHoten.Text = "Họ và tên";
            // 
            // lbMshs
            // 
            this.lbMshs.AutoSize = true;
            this.lbMshs.Location = new System.Drawing.Point(30, 44);
            this.lbMshs.Name = "lbMshs";
            this.lbMshs.Size = new System.Drawing.Size(86, 13);
            this.lbMshs.TabIndex = 0;
            this.lbMshs.Text = "Số hiệu học sinh";
            // 
            // btnXemtatca
            // 
            this.btnXemtatca.Location = new System.Drawing.Point(13, 181);
            this.btnXemtatca.Name = "btnXemtatca";
            this.btnXemtatca.Size = new System.Drawing.Size(75, 23);
            this.btnXemtatca.TabIndex = 1;
            this.btnXemtatca.Text = "Xem toàn bộ";
            this.btnXemtatca.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(109, 181);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.Location = new System.Drawing.Point(212, 181);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnNhaplai.TabIndex = 3;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = true;
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click);
            // 
            // btnHuybo
            // 
            this.btnHuybo.Location = new System.Drawing.Point(312, 181);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(75, 23);
            this.btnHuybo.TabIndex = 4;
            this.btnHuybo.Text = "Hủy bỏ";
            this.btnHuybo.UseVisualStyleBackColor = true;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // Tim_kiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 216);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.btnNhaplai);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXemtatca);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tim_kiem";
            this.Text = "Tim_kiem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.Label lbMshs;
        private System.Windows.Forms.Button btnXemtatca;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnNhaplai;
        private System.Windows.Forms.Button btnHuybo;
    }
}