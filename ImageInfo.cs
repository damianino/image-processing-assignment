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
    public partial class ImageInfo : Form
    {
        Main parent;
        public ImageInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        internal ImageInfo(Main f)
        {
            InitializeComponent();
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            parent = f;
            addImageInfo();
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void addImageInfo()
        {
            this.dataGridView1.Rows.Add("Ширина", parent.OriginalImage.Width);
            this.dataGridView1.Rows.Add("Высота", parent.OriginalImage.Height);
            this.dataGridView1.Rows.Add("Горизонтальное разрешение", parent.OriginalImage.HorizontalResolution);
            this.dataGridView1.Rows.Add("Вертикальное разрешение", parent.OriginalImage.VerticalResolution);
            this.dataGridView1.Rows.Add("Формат пикселей", parent.OriginalImage.PixelFormat.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
