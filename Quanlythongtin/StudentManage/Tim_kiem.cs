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
    public partial class Tim_kiem : Form
    {
        private string path;
        public void SetPath(string _path)
        {
            path = _path;
        }

        public string GetPath()
        {
            return path;
        }
        public Tim_kiem()
        {
            InitializeComponent();
        }

        public Tim_kiem(string _path)
        {
            InitializeComponent();
            SetPath(_path);
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            return;
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            this.tbShhs.Text = string.Empty;
            this.tbName.Text = string.Empty;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            JArray listFromFile = JArray.Parse(File.ReadAllText(GetPath()));
            JArray savingList = new JArray();

            // get searching pattern
            string searchPattern = "";
            if (this.tbShhs.Text.ToString() != string.Empty)
            {
                searchPattern = this.tbShhs.Text.ToString();

            }
            else if (this.tbShhs.Text.ToString() == string.Empty && this.tbName.Text.ToString() != string.Empty)
            {
                searchPattern = this.tbName.Text.ToString();
            }
            else if (this.tbShhs.Text.ToString() == string.Empty && this.tbName.Text.ToString() == string.Empty)
                MessageBox.Show("Xin hãy nhập vào thông tin để tìm kiếm");

            foreach (JObject ob in listFromFile)
            {
                if (searchPattern == (string)ob["ho_ten"] || searchPattern == (string)ob["id"])
                {
                    savingList.Add(ob);
                }
            }

            // search information of employee mapping search pattern
            // then display data for user
            student.search(savingList);
            student.Show();
        }

        private void btnXemtatca_Click(object sender, EventArgs e)
        {
            // view all employee through constructor
            main _m = new main();
            Student student = new Student(GetPath(), _m);
            student.Show();
        }
    }
}
