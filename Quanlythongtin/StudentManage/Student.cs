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
using System.IO;

namespace StudentManage
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        public Student(string filePath, main _main)
        {
            // init components
            InitializeComponent();
            //
            // get information from json file then compare with 
            // information get from input form
            JArray jStudent = JArray.Parse(File.ReadAllText(filePath));

            int objectLength = jStudent.Count;

            // tim kiem xem da co file nhanvien.json chua? 
            // neu co thi mo append, chua thi tao moi
            StreamWriter wt;
            if (!File.Exists("../../../data/hocsinh.json"))
            {
                wt = new StreamWriter("../../../data/hocsinh.json");
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
                new JProperty("workstatus", nv.getWorkStatus()),
                new JProperty("imagefilepath", nv.getPathImg())
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

            array.Add(hsObj);

            File.WriteAllText("../../../data/hocsinh.json", array.ToString());

            Console.WriteLine("hoc sinh -> " + array);

            Console.WriteLine("Done!");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            return;
        }
    }
}
