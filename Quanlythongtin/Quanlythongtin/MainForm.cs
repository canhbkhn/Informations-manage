using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythongtin
{
    public partial class MainForm : Form
    {
        private string name;                            // họ tên
        private string id;                              // id nhân viên
        private string birthDay;                        // năm sinh
        private string IdentifyNumber;                  // số cmnd
        private string gender;                          // giới tính
        private string workingTime;                     // giờ làm việc: hành chính | thời vụ | partime
        private string address;                         // địa chỉ
        private string phoneNum;                        // số điện thoại
        private string literacy;                        // trình độ học vấn
        private string workOn;                          // ngày vào làm việc
        private string workOff;                         // ngày thôi việc
        private string nation;                          // dân tộc
        private string religion;                        // tôn giáo
        private string department;                      // bộ phận
        private string role;                            // chức vụ
        private string email;                           // địa chỉ email
        private string married;                         // tình trạng hôn nhân
        private string statusOfWork;                    // trạng thái nhân viên: làm việc | đã nghỉ

        private string pathImg;                         // đường dẫn lưu ảnh nhân viên

        // method
        public void setName(string _name)
        {
            name = _name;
        }

        public string getName()
        {
            return name;
        }

        public void setId(string _id)
        {
            id = _id;
        }

        public string getId()
        {
            return id;
        }

        public void setBirthDay(string BirthDay)
        {
            birthDay = BirthDay;
        }

        public string getBirthDay()
        {
            return birthDay;
        }

        public void setGender(string Gender)
        {
            gender = Gender;
        }

        public string getGender()
        {
            return gender;
        }

        public void setWorkingTime(string WorkingTime)
        {
            workingTime = WorkingTime;
        }

        public void setAddress(string Address)
        {
            address = Address;
        }

        public string getAddress()
        {
            return address;
        }

        public void setPhoneNumber(string PhoneNumber)
        {
            phoneNum = PhoneNumber;
        }

        public string getPhoneNumber()
        {
            return phoneNum;
        }

        public void setLiteracy(string Literacy)
        {
            literacy = Literacy;
        }

        public string getLiteracy()
        {
            return literacy;
        }

        public void setWorkOn(string WorkOn)
        {
            workOn = WorkOn;
        }

        public string getWorkOn()
        {
            return workOn;
        }

        public void setWorkOff(string WorkOff)
        {
            workOff = WorkOff;
        }

        public string getWorkOff()
        {
            return workOff;
        }

        public void setNation(string Nation)
        {
            nation = Nation;
        }

        public string getNation()
        {
            return nation;
        }

        public void setReligion(string Religion)
        {
            religion = Religion;
        }

        public string getReligion()
        {
            return religion;
        }

        public void setDepartment(string Department)
        {
            department = Department;
        }

        public string getDepartment()
        {
            return department;
        }

        public void setRole(string Role)
        {
            role = Role;
        }

        public string getRole()
        {
            return role;
        }

        public void setEmail(string Email)
        {
            email = Email;
        }

        public string getEmail()
        {
            return email;
        }

        public void setMarryStatus(string MarryStatus)
        {
            married = MarryStatus;
        }

        public string getMarryStatus()
        {
            return married;
        }

        public void setStatusOfWork(string WorkStatus)
        {
            statusOfWork = WorkStatus;
        }

        public string getWorkStatus()
        {
            return statusOfWork;
        }

        public void setPathImg(string PathImg)
        {
            pathImg = PathImg;
        }

        public string getPathImg()
        {
            return pathImg;
        }



        /// <summary>
        /// default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTTNV_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnSaveDataNv_Click(object sender, EventArgs e)
        {

        }
    }
}
