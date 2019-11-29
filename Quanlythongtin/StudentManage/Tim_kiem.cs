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

            Console.WriteLine("list->" + listFromFile);

            JArray savingList = new JArray();

            // get searching pattern
            string searchById = "";
            string searchByName = "";
            if (this.tbShhs.Text.ToString() != string.Empty)
            {
                searchById = this.tbShhs.Text.ToString();
            }

            if (this.tbName.Text.ToString() != string.Empty)
            {
                searchByName = this.tbName.Text.ToString();
            }

            if (this.tbShhs.Text.ToString() == string.Empty && this.tbName.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Xin hãy nhập vào thông tin để tìm kiếm");
                return;
            }

            //foreach (JObject ob in listFromFile)
            //{
            //    if (searchPattern == (string)ob["ho_ten"] || searchPattern == (string)ob["shhs"])
            //    {
            //        savingList.Add(ob);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không có học sinh này, hãy kiếm tra lại");
            //        return;
            //    }
            //}

            

            for (int i = 0; i < listFromFile.Count; i ++ )
            {
                //if ((searchPattern == (string)listFromFile[i]["ho_ten"]  && (string)listFromFile[i]["ho_ten"] != "")||
                //    (searchPattern == (string)listFromFile[i]["shhs"] && (string)listFromFile[i]["shhs"] != ""))
                //{
                //    savingList.Add(listFromFile[i]);             
                //}
                //else
                //{
                //    MessageBox.Show("Không có học sinh này, hãy kiếm tra lại");
                //    return;
                //}
                //if(searchById == listFromFile[i]["shhs"].ToString() ||
                //   searchByName == listFromFile[i]["ho_ten"].ToString()
                //   )
                //{
                //    savingList.Add(listFromFile[i]);
                //}

                if (searchById != string.Empty && searchByName == string.Empty)
                {
                    if(searchById == listFromFile[i]["shhs"].ToString())
                    {
                        savingList.Add(listFromFile[i]);
                    }
                }

                if(searchById == string.Empty && searchByName != string.Empty)
                {
                    if (searchByName == listFromFile[i]["ho_ten"].ToString())
                    {
                        savingList.Add(listFromFile[i]);
                    }
                }

                if(searchById != string.Empty && searchByName != string.Empty)
                {
                    if (searchById == listFromFile[i]["shhs"].ToString() && searchByName == listFromFile[i]["ho_ten"].ToString())
                    {
                        savingList.Add(listFromFile[i]);
                    }
                }


            }

            if(savingList.Count != 0)
            {
                // search information of employee mapping search pattern
                // then display data for user
                student.search(savingList);
                student.Show();
            }
            else
            {
                MessageBox.Show("Không có học sinh này, hãy kiếm tra lại");
                return;
            }
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
