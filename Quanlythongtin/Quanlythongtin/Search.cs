﻿using System;
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
        /// <summary>
        /// default constructor
        /// </summary>
        public Search()
        {
            
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="path"></param>
        public Search(string path)
        {
            InitializeComponent();
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
            employ.Show();
        }
    }
}
