﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Add_category : Form
    {
        public Add_category()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Home hp = new Home();
            hp.Show();
            this.Hide();

        }
    }
}
