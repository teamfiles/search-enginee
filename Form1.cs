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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_file f = new Add_file();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display_file f2 = new Display_file();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_category f3 = new Add_category();
            f3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display_categories f4 = new Display_categories();
            f4.Show();
            this.Hide();
        }
    }
}
