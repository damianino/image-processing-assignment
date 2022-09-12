using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Binarization : Form
    {
        Main parent;
        public Binarization()
        {
            InitializeComponent();
        }

        public Binarization(Main p)
        {
            InitializeComponent();
            parent = p;
        }

        private void Binarization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = colorDialog2.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newImg = IPM.binareImage(parent.LastImage, (int)numericUpDown1.Value, colorDialog1.Color, colorDialog2.Color);
            parent.updateLastImage(newImg);
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
