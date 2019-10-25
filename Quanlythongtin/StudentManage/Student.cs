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

            for(int i = 0; i< objectLength; i++)
            {
                Object[] row = new Object[]{
                    (string)jStudent[i]["ho_ten"],
                    (string)jStudent[i]["shhs"],
                    (string)jStudent[i]["cmnd"],
                    (string)jStudent[i]["nam_sinh"],
                    (string)jStudent[i]["gioi_tinh"],
                    (string)jStudent[i]["lop"],
                                   (string)jStudent[i]["dia_chi"],
                                      (string)jStudent[i]["so_dt"],
                                         (string)jStudent[i]["dan_toc"],
                                            (string)jStudent[i]["ton_giao"],
                                               (string)jStudent[i]["chuc_vu"],
                                                  (string)jStudent[i]["email"],
                                                     (string)jStudent[i]["tinh_trang_hs"],
                                                        (string)jStudent[i]["ngay_vao_hoc"],
                                                           (string)jStudent[i]["ngay_thoi_hoc"],
                                                              (string)jStudent[i]["ly_do_thoi_hoc"],
                                                                 (string)jStudent[i]["diem_tb"],
                                                                    (string)jStudent[i]["hoc_ky"],
                                                                    (string)jStudent[i]["nam_hoc"],
                                                                    (string)jStudent[i]["file_anh"],
                                                                   (new Bitmap( (string)jStudent[i]["file_anh"]))


                };

                Console.WriteLine("image path -> " + (string)jStudent[i]["file_anh"]);

                dataGridView1.Rows.Add(row);
               // dataGridView1.Rows.Add(bm);
            }


        }

        public void search(JArray listStudent)
        {
            // log
            Console.WriteLine("So hoc sinh tim thay -> " + listStudent.Count);

            for (int i = 0; i < listStudent.Count; i++)
            {
                string[] row = new string[] {
                    (string)listStudent[i]["ho_ten"],
                    (string)listStudent[i]["shhs"],
                    (string)listStudent[i]["cmnd"],
                    (string)listStudent[i]["nam_sinh"],
                    (string)listStudent[i]["gioi_tinh"],
                    (string)listStudent[i]["lop"],
                    (string)listStudent[i]["dia_chi"],
                    (string)listStudent[i]["so_dt"],
                    (string)listStudent[i]["dan_toc"],
                    (string)listStudent[i]["ton_giao"],
                    (string)listStudent[i]["chuc_vu"],
                    (string)listStudent[i]["email"],
                    (string)listStudent[i]["tinh_trang_hs"],
                    (string)listStudent[i]["ngay_vao_hoc"],
                    (string)listStudent[i]["ngay_thoi_hoc"],
                    (string)listStudent[i]["ly_do_thoi_hoc"],
                    (string)listStudent[i]["diem_tb"],
                    (string)listStudent[i]["hoc_ky"],
                    (string)listStudent[i]["nam_hoc"],
                    (string)listStudent[i]["file_anh"]
                };

                dataGridView1.Rows.Add(row, Bitmap.FromFile((string)listStudent[i]["file_anh"]));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
            {
                // compare value of cell click to search
                // read from data file
                JArray jStudent = JArray.Parse(File.ReadAllText("../../../data/hocsinh.json"));

                foreach (JObject ob in jStudent)
                {
                    if (dataGridView1.CurrentCell.Value.ToString() == (string)ob["ho_ten"] )
                    {
                        StudentInfo info = new StudentInfo(ob);
                        info.Show();
                    }
                }
                //StudentInfo info = new StudentInfo();
                //info.Show();
            }
                //MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());     
        }
    }
}
