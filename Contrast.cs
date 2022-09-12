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
    public partial class Contrast : Form
    {
        Main parent;
        public Contrast(Main p)
        {
            InitializeComponent();
            parent = p;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.updateLastImage(IPM.ChangeImage(parent.LastImage, trackBar1.Value, 0.0f));
        }
    }
}
