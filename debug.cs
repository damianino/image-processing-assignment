using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class debug : Form
    {
        Main parent;
        public debug(Main p)
        {
            InitializeComponent();
            parent = p;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void debug_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = parent.EditedList.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = parent.EditedList[(int)numericUpDown1.Value];
        }
    }
}
