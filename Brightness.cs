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
    public partial class Brightness : Form
    {
        Main parent;
        public Brightness(Main p)
        {
            InitializeComponent();
            parent = p;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.updateLastImage(IPM.ChangeImage(parent.LastImage,100.0f,(float)trackBar1.Value));
            this.Close();
        }
    }
}
