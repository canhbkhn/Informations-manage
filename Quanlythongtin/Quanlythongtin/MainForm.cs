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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Quanlythongtin
{
    public partial class NhanVien : Form
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

        public void setIdentifyNumber(string identifyNumber)
        {
            IdentifyNumber = identifyNumber;
        }

        public string getIdentifyNumber()
        {
            return IdentifyNumber;
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

        public string getWorkingTime()
        {
            return workingTime;
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
        public NhanVien()
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

        // set information from input form
        public void setNhanvienInfor(NhanVien nhanvien)
        {
            //NhanVien nhanvien = new NhanVien();

            nhanvien.setName(this.tbName.Text.ToString());
            nhanvien.setId(this.tbId.Text.ToString());
            nhanvien.setBirthDay(this.tbNamsinh.Text.ToString());
            nhanvien.setGender(this.cbGioiTinh.Text.ToString());
            nhanvien.setWorkingTime(this.cbWorkingTime.Text.ToString());
            //
            nhanvien.setAddress(this.tbDiachi.Text.ToString());
            nhanvien.setPhoneNumber(this.tbSdt.Text.ToString());
            nhanvien.setLiteracy(this.cbHocvan.Text.ToString());
            nhanvien.setWorkOn(this.tbNgayvao.Text.ToString());
            nhanvien.setWorkOff(this.tbNgayra.Text.ToString());
            nhanvien.setNation(this.tbDantoc.Text.ToString());
            nhanvien.setReligion(this.tbTongiao.Text.ToString());
            nhanvien.setDepartment(this.cbBophan.Text.ToString());
            nhanvien.setRole(this.cbChucvu.Text.ToString());
            nhanvien.setEmail(this.tbEmail.Text.ToString());
            nhanvien.setMarryStatus(this.cbKethon.Text.ToString());
            nhanvien.setStatusOfWork(this.cbTinhTrangNv.Text.ToString());
        }

        // get information from input form
        

        private void btnSaveDataNv_Click(object sender, EventArgs e)
        {
            // get employee information from input form
            // new nhan vien
            NhanVien nv = new NhanVien();

            setNhanvienInfor(nv);
            //Console.WriteLine(nv.getName());
            MessageBox.Show(nv.getName());
            // tim kiem xem da co file nhanvien.json chua? 
            // neu co thi mo append, chua thi tao moi
            StreamWriter wt;
            if(!File.Exists("../../../data/nhanvien.json"))
            {
                wt = new StreamWriter("../../../data/nhanvien.json");
                wt.Close();
            }
           

            // create json object nhan vien to save
            JObject nvOb = new JObject(
                new JProperty("name", nv.getName()),
                new JProperty("id", nv.getId()),
                new JProperty("birthday", nv.getBirthDay()),
                new JProperty("gender", nv.getGender()),
                new JProperty("workingtime", nv.getWorkingTime()),
                new JProperty("address", nv.getAddress()),
                new JProperty("phonenumber", nv.getPhoneNumber()),
                new JProperty("literacy", nv.getLiteracy()),
                new JProperty("workon", nv.getWorkOn()),
                new JProperty("workoff", nv.getWorkOff()),
                new JProperty("nation", nv.getNation()),
                new JProperty("religion", nv.getReligion()),
                new JProperty("department", nv.getDepartment()),
                new JProperty("role", nv.getRole()),
                new JProperty("email", nv.getEmail()),
                new JProperty("marrystatus", nv.getMarryStatus()),
                new JProperty("workstatus", nv.getWorkStatus())
                );

            JArray array;
            string fileContent = File.ReadAllText("../../../data/nhanvien.json").ToString();
            if(fileContent.Length == 0 )
            {
                array = new JArray();
            }
            else
            {
                array = JArray.Parse(File.ReadAllText("../../../data/nhanvien.json"));
                
            }

            array.Add(nvOb);

            File.WriteAllText("../../../data/nhanvien.json", array.ToString());

            Console.WriteLine("nhan vien -> " + array);

            Console.WriteLine("Done!");
            
        }

        private void btnReInput_Click(object sender, EventArgs e)
        {
            this.tbName.Text = string.Empty;
            this.tbId.Text = string.Empty;
            this.tbNamsinh.Text = string.Empty;
            this.cbGioiTinh.Text = string.Empty;
            this.cbWorkingTime.Text = string.Empty;
            this.tbDiachi.Text = string.Empty;
            this.tbSdt.Text = string.Empty;
            this.cbHocvan.Text = string.Empty;
            this.tbNgayvao.Text = string.Empty;
            this.tbNgayra.Text = string.Empty;
            this.tbDantoc.Text = string.Empty;
            this.tbTongiao.Text = string.Empty;
            this.cbBophan.Text = string.Empty;
            this.cbChucvu.Text = string.Empty;
            this.tbEmail.Text = string.Empty;
            this.cbKethon.Text = string.Empty;
            this.cbTinhTrangNv.Text = string.Empty;
        }
    }
}
