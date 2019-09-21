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
    
    public partial class Employee : Form
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public Employee()
        {
            InitializeComponent();
        }

        public Employee(string filePath, NhanVien nv)
        {
            InitializeComponent();
            // get information from json file then compare with 
            // information get from input form
            JArray jNv = JArray.Parse(File.ReadAllText(filePath));

            int objectLength = jNv.Count;

            for(int i = 0; i < objectLength; i++)
            {
                dataGridView1.Rows[i].Cells["Họ tên"].Value = //
            }

            Console.WriteLine("so object -> " + objectLength.ToString());
            Console.WriteLine("employee -> " + jNv);
        }

        public void search(string searchPattern)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            return;
        }
    }
}
