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
using Newtonsoft.Json;
using System.IO;

namespace Quanlythongtin
{
    public partial class Search : Form
    {

        private string path;

        public void setPath(string _path)
        {
            path = _path;
        }

        public string getPath()
        {
            return path;
        }
        /// <summary>
        /// default constructor
        /// </summary>
        public Search()
        {
            InitializeComponent();
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="path"></param>
        public Search(string path)
        {
            InitializeComponent();
            setPath(path);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Employee employ = new Employee();

            JArray listFromFile = JArray.Parse(File.ReadAllText(getPath()));
            JArray savingList = new JArray();

            // get searching pattern
            string searchPattern = "";
            if (this.tbIdTimkiem.Text.ToString() != string.Empty)
            {
                searchPattern = this.tbIdTimkiem.Text.ToString();

            }      
            else if (this.tbIdTimkiem.Text.ToString() == string.Empty && this.tbHotenTimkiem.Text.ToString() != string.Empty)
            {
                searchPattern = this.tbHotenTimkiem.Text.ToString();
            }  
            else if(this.tbIdTimkiem.Text.ToString() == string.Empty && this.tbHotenTimkiem.Text.ToString() == string.Empty)
                MessageBox.Show("Xin hãy nhập vào thông tin để tìm kiếm");

            foreach(JObject ob in listFromFile)
            {
                if(searchPattern == (string)ob["name"] || searchPattern == (string)ob["id"])
                {
                    savingList.Add(ob);
                }
            }

            // search information of employee mapping search pattern
            // then display data for user
            employ.search(savingList);
            employ.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            // view all employee through constructor
            NhanVien nv = new NhanVien();
            Employee employ = new Employee(getPath(), nv);
            employ.Show();
        }

        private void btnReinput_Click(object sender, EventArgs e)
        {
            this.tbIdTimkiem.Text = string.Empty;
            this.tbHotenTimkiem.Text = string.Empty;
        }
    }
}
