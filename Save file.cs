using System;
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
    public partial class Save_file : Form
    {
        public Save_file()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_new_category c = new Add_new_category();
            c.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_file f = new Add_file();
            f.Show();
            this.Hide();
        }
    }
}
