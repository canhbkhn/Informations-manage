using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace StudentManage
{
    public partial class StudentInfo : Form
    {
        private string hoten;
        private string shhs;
        private string lop;
        private string diachi;
        private string email;
        private string dienthoai;
        private string diemtrungbinh;

        /// <summary>
        /// set,get ho ten hoc sinh
        /// </summary>
        /// <param name="_hoten"></param>
        public void setHoten(string _hoten)
        {
            hoten = _hoten;
        }

        public string getHoten()
        {
            return hoten;
        }

        /// <summary>
        /// set, get so hieu hoc sinh
        /// </summary>
        /// <param name="_shhs"></param>
        public void setShhs(string _shhs)
        {
            shhs = _shhs;
        }

        public string getShhs()
        {
            return shhs;
        }

        /// <summary>
        /// get, set lop cho hoc sinh
        /// </summary>
        /// <param name="_lop"></param>
        public void setLop(string _lop)
        {
            lop = _lop;
        }

        public string getLop()
        {
            return lop;
        }

        /// <summary>
        /// set, get dia chi hoc sinh
        /// </summary>
        /// <param name="_diachi"></param>
        public void setDiachi(string _diachi)
        {
            diachi = _diachi;
        }

        public string getDiachi()
        {
            return diachi;
        }

        /// <summary>
        /// set, get email hoc sinh
        /// </summary>
        /// <param name="_email"></param>
        public void setEmail(string _email)
        {
            email = _email;
        }

        public string getEmail()
        {
            return email;
        }

        /// <summary>
        /// set, get so dien thoai hoc sinh
        /// </summary>
        /// <param name="_dienthoai"></param>
        public void setDienthoai(string _dienthoai)
        {
            dienthoai = _dienthoai;
        }

        public string getDienthoai()
        {
            return dienthoai;
        }

        /// <summary>
        /// set, get diem trung binh hoc sinh
        /// </summary>
        /// <param name="_diemtrungbinh"></param>
        public void setDiemtrungbinh(string _diemtrungbinh)
        {
            diemtrungbinh = _diemtrungbinh;
        }

        public string getDiemtrungbinh()
        {
            return diemtrungbinh;
        }

        public StudentInfo(JObject jStudent)
        {
            InitializeComponent();

            // display result
            this.lbHoten.Text = (string)jStudent["ho_ten"];
            this.lbShhs.Text = (string)jStudent["shhs"];
            this.lbLop.Text = (string)jStudent["lop"];
            this.lbDiachi.Text = (string)jStudent["dia_chi"];
            this.lbEmail.Text = (string)jStudent["email"];
            this.lbDienthoai.Text = (string)jStudent["so_dt"];
            this.lbDiemtrungbinh.Text = (string)jStudent["diem_tb"];
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            return;
        }
    }
}
