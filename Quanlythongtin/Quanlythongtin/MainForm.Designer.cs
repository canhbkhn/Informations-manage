namespace Quanlythongtin
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grBasicInfo = new System.Windows.Forms.GroupBox();
            this.lbIdentify = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInsertImg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grBasicInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 137);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grBasicInfo
            // 
            this.grBasicInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grBasicInfo.Controls.Add(this.comboBox2);
            this.grBasicInfo.Controls.Add(this.comboBox1);
            this.grBasicInfo.Controls.Add(this.textBox3);
            this.grBasicInfo.Controls.Add(this.textBox2);
            this.grBasicInfo.Controls.Add(this.textBox1);
            this.grBasicInfo.Controls.Add(this.label3);
            this.grBasicInfo.Controls.Add(this.label2);
            this.grBasicInfo.Controls.Add(this.label1);
            this.grBasicInfo.Controls.Add(this.lbIdentify);
            this.grBasicInfo.Controls.Add(this.lbName);
            this.grBasicInfo.Location = new System.Drawing.Point(139, 13);
            this.grBasicInfo.Name = "grBasicInfo";
            this.grBasicInfo.Size = new System.Drawing.Size(455, 173);
            this.grBasicInfo.TabIndex = 1;
            this.grBasicInfo.TabStop = false;
            this.grBasicInfo.Text = "Thông tin cơ bản";
            // 
            // lbIdentify
            // 
            this.lbIdentify.AutoSize = true;
            this.lbIdentify.Location = new System.Drawing.Point(10, 66);
            this.lbIdentify.Name = "lbIdentify";
            this.lbIdentify.Size = new System.Drawing.Size(18, 13);
            this.lbIdentify.TabIndex = 1;
            this.lbIdentify.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(10, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(39, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Ho ten";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 223);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 448);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin cơ bản";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin khác";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInsertImg
            // 
            this.btnInsertImg.Location = new System.Drawing.Point(47, 156);
            this.btnInsertImg.Name = "btnInsertImg";
            this.btnInsertImg.Size = new System.Drawing.Size(54, 21);
            this.btnInsertImg.TabIndex = 3;
            this.btnInsertImg.Text = "Chèn";
            this.btnInsertImg.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giờ làm việc";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(348, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(348, 20);
            this.textBox3.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(328, 140);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 750);
            this.Controls.Add(this.btnInsertImg);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grBasicInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grBasicInfo.ResumeLayout(false);
            this.grBasicInfo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grBasicInfo;
        private System.Windows.Forms.Label lbIdentify;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnInsertImg;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

