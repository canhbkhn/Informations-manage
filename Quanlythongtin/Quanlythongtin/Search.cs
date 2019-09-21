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
            //Search s = new Search();
            NhanVien nv = new NhanVien();
            Employee employ = new Employee(getPath(), nv);
            employ.Show();
        }
    }
}
