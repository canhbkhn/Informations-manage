using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace StudentManage
{
    public partial class authen : Form
    {
        public authen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // authen name and authen password get form authen form
            string authenName = this.tbUserName.Text.ToString();
            string authenPassword = this.tbPassword.Text.ToString();
            //this.tbPassword.UseSystemPasswordChar = true;

            if(authenName == string.Empty || authenPassword == string.Empty)
            {
                MessageBox.Show("Xin hãy nhập vào thông tin đăng nhập");
                return;
            }

            // authen information get from database
            JArray listAuthenInformation = JArray.Parse(File.ReadAllText("../../../members_manage/members.json"));
            Console.WriteLine("authen -> " + listAuthenInformation.ToString());

            // checking authentication
            foreach(JObject authenObj in listAuthenInformation)
            {
                if(authenName == (string)authenObj["name"] && authenPassword == (string)authenObj["password"])
                {
                    this.Hide();
                    main input = new main();
                    input.Show();
                }
                
                if(authenName == (string)authenObj["name"] && authenPassword != (string)authenObj["password"])
                {
                    MessageBox.Show("Tài khoản không đúng");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Application.Exit();
        }
    }
}
