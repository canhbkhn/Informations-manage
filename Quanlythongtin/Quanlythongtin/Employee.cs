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
                string[] row = new string[] {
                    (string)jNv[i]["id"],
                    (string)jNv[i]["name"],
                    (string)jNv[i]["birthday"],
                    (string)jNv[i]["gender"],
                    (string)jNv[i]["workingtime"],
                    (string)jNv[i]["address"],
                    (string)jNv[i]["phonenumber"],
                    (string)jNv[i]["literacy"],
                    (string)jNv[i]["workon"],
                    (string)jNv[i]["workoff"],
                    (string)jNv[i]["nation"],
                    (string)jNv[i]["religion"],
                    (string)jNv[i]["department"],
                    (string)jNv[i]["role"],
                    (string)jNv[i]["email"],
                    (string)jNv[i]["marrystatus"],
                    (string)jNv[i]["workstatus"],
                };

                dataGridView1.Rows.Add(row);
            }

            Console.WriteLine("so object -> " + objectLength.ToString());
            Console.WriteLine("employee -> " + jNv);
        }

        public void search(JArray listObj)
        {
            // log
            Console.WriteLine("So nhan vien tim thay -> " + listObj.Count);

            for(int i = 0; i < listObj.Count; i++)
            {
                string[] row = new string[] {
                    (string)listObj[i]["id"],
                    (string)listObj[i]["name"],
                    (string)listObj[i]["birthday"],
                    (string)listObj[i]["gender"],
                    (string)listObj[i]["workingtime"],
                    (string)listObj[i]["address"],
                    (string)listObj[i]["phonenumber"],
                    (string)listObj[i]["literacy"],
                    (string)listObj[i]["workon"],
                    (string)listObj[i]["workoff"],
                    (string)listObj[i]["nation"],
                    (string)listObj[i]["religion"],
                    (string)listObj[i]["department"],
                    (string)listObj[i]["role"],
                    (string)listObj[i]["email"],
                    (string)listObj[i]["marrystatus"],
                    (string)listObj[i]["workstatus"],
                };

                dataGridView1.Rows.Add(row);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            return;
        }
    }
}
