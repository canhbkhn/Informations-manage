using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace StudentManage
{
    public partial class main : Form
    {
        // Image file path
        private string imgPath;
        public main()
        {
            InitializeComponent();
            this.FormClosing += main_FormClosing;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {
            if(this.cbTinhtrang.Text == "Đang học")
            {
                this.cbLydothoihoc.Enabled = false;
                this.tbNgaythoihoc.Enabled = false;
            }
        }

        // img path
        public void SetImgPath(string _imgPath)
        {
            imgPath = _imgPath;
        }

        public string GetImgPath()
        {
            return imgPath;
        }


        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) Application.Exit(); 
            if (e.CloseReason == CloseReason.UserClosing) Application.Exit();    
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            // TODO: xem toan bo thong tin hoac thong tin tim kiem
            Tim_kiem tk = new Tim_kiem("../../../data/hocsinh.json");
            tk.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            main _main = new main();

            // tim kiem xem da co file nhanvien.json chua? 
            // neu co thi mo append, chua thi tao moi
            StreamWriter wt;
            if (!File.Exists("../../../data/hocsinh.json"))
            {
                wt = new StreamWriter("../../../data/hocsinh.json");
                wt.Close();
            }

            // 
            if(this.tbToan.Text.ToString() == ""
                ||this.tbVatly.Text.ToString() == "" 
                || this.tbNguvan.Text.ToString() == ""
                || this.tbTienganh.Text.ToString() == ""
                || this.tbSinhhoc.Text.ToString() == ""
                || this.tbHoahoc.Text.ToString() == ""
                )
            {
                MessageBox.Show("Hãy nhập điểm cho học sinh (nhập số nguyên)");
                return;
            }

            // compute diem trung binh
            int diemTb = (Convert.ToInt32(this.tbToan.Text.ToString()) +
                Convert.ToInt32(this.tbVatly.Text.ToString()) +
                Convert.ToInt32(this.tbNguvan.Text.ToString()) +
                Convert.ToInt32(this.tbTienganh.Text.ToString()) +
                Convert.ToInt32(this.tbSinhhoc.Text.ToString()) +
                Convert.ToInt32(this.tbHoahoc.Text.ToString())
                ) / 6;

            // create json object hoc sinh to save
            JObject nvOb = new JObject(
                new JProperty("ho_ten", this.tbName.Text.ToString()),
                new JProperty("shhs", this.tbMshs.Text.ToString()),
                new JProperty("cmnd", this.tbCmnd.Text.ToString()),
                new JProperty("nam_sinh", this.tbNamsinh.Text.ToString()),
                new JProperty("gioi_tinh", this.cbGioitinh.Text.ToString()),
                new JProperty("lop", this.cbLop.Text.ToString()),
                new JProperty("dia_chi", this.tbDiachi.Text.ToString()),
                new JProperty("so_dt", this.tbSodienthoai.Text.ToString()),
                new JProperty("dan_toc", this.tbDantoc.Text.ToString()),
                new JProperty("ton_giao", this.tbTongiao.Text.ToString()),
                new JProperty("chuc_vu", this.cbChucvu.Text.ToString()),
                new JProperty("email", this.tbEmail.Text.ToString()),
                new JProperty("tinh_trang_hs", this.cbTinhtrang.Text.ToString()),
                new JProperty("ngay_vao_hoc", this.tbNgayvaohoc.Text.ToString()),
                new JProperty("ngay_thoi_hoc", this.tbNgaythoihoc.Text.ToString()),
                new JProperty("ly_do_thoi_hoc", this.cbLydothoihoc.Text.ToString()),
                new JProperty("diem_tb", diemTb.ToString()),
                new JProperty("hoc_ky", this.cbHocky.Text.ToString()),
                new JProperty("nam_hoc", this.tbNamhoc.Text.ToString()),
                new JProperty("file_anh", GetImgPath())
                );

            JArray array;
            string fileContent = File.ReadAllText("../../../data/hocsinh.json").ToString();
            if (fileContent.Length == 0)
            {
                array = new JArray();
            }
            else
            {
                array = JArray.Parse(File.ReadAllText("../../../data/hocsinh.json"));
            }

            array.Add(nvOb);

            File.WriteAllText("../../../data/hocsinh.json", array.ToString());

            Console.WriteLine("hoc sinh -> " + array);

            Console.WriteLine("Done!");

            MessageBox.Show("Lưu thông tin học sinh thành công");
        }

        private void btnInsertImg_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "jpg files (*.jpg)|*.jpg|png file (*.png)|*.png|All files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
            }

            Console.WriteLine("img path -> " + filePath);
            SetImgPath(filePath);

            // display image to picture box
            pictureBox1.Image = new Bitmap(filePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
