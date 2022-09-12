using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Main : Form
    {
       
        public Bitmap OriginalImage;
        public Bitmap LastImage;
        public ObservableCollection<Bitmap> EditedList = new ObservableCollection<Bitmap>();
        public int editsNumber = 0;

        public Main()
        {
            InitializeComponent();
            EditedList.CollectionChanged += EditedList_CollectionChanged;
        }

        private void EditedList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("on edit event:" + EditedList.Count);
            //list changed - an item was added.
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                //Do what ever you want to do when an item is added here...
                //the new items are available in e.NewItems
            }
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                if (EditedList.Count == 0)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox2.Image.Dispose();
                    LastImage.Dispose();
                    return;
                }
            }
            LastImage = EditedList[EditedList.Count - 1];
            pictureBox2.Image = LastImage;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Select Image";
            opf.Filter = "Image files |*.jpg; *.jpeg; *.bmp; *.png";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                OriginalImage = new Bitmap(opf.FileName);
                LastImage = new Bitmap(OriginalImage);
                EditedList.Add(OriginalImage);

                pictureBox1.Image = new Bitmap(OriginalImage);
                pictureBox2.Image = new Bitmap(EditedList[EditedList.Count - 1]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfp = new SaveFileDialog();

            sfp.Title = "Save Image";
            sfp.Filter = "Image files |*.jpg; *.jpeg; *.bmp; *.png";
            sfp.DefaultExt = "jpg";
            sfp.AddExtension = true;
            if (sfp.ShowDialog() == DialogResult.OK)
            {
                EditedList[EditedList.Count - 1].Save(sfp.FileName);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (EditedList.Count <= 0)
            {
                MessageBox.Show("Невозможно отменить действие.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditedList.RemoveAt(EditedList.Count - 1);
            return;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("Картинка не была выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImageInfo WindowImageInfo = new ImageInfo(this);
            WindowImageInfo.Show();
        }

        public void updateLastImage(Bitmap img)
        {
            EditedList.Add(img);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (LastImage == null)
            {
                MessageBox.Show("Картинка не была выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Histograms WindowHistogram = new Histograms(this);
            WindowHistogram.Show();
        }
        private void БинаризацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("Картинка не была выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Binarization WindowBinare = new Binarization(this);
                //WindowBinare.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void негативToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newImg = IPM.negativeImage(LastImage);
            updateLastImage(newImg);
        }

        private void оттенкиСерогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newImg = IPM.grayImage(LastImage);
            updateLastImage(newImg);
        }

        private void бинаризацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("Картинка не была выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Binarization WindowBinarization = new Binarization(this);
            WindowBinarization.Show();
        }

        private void шумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("Картинка не была выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Noise WindowNoise = new Noise(this);
            WindowNoise.Show();
        }

        private void повышениеРезкостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("Картинка не была выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bitmap img = IPM.setPixels(LastImage);
                Filter.pixel = Filter.matrix_filtration(img.Width, img.Height, Filter.pixel, Filter.N1, Filter.sharpness);
                img = IPM.FromPixelToBitmap(img);
                updateLastImage(img);
            }
        }

        private void размытиеИзображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("Картинка не была выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bitmap img = IPM.setPixels(LastImage);
                Filter.pixel = Filter.matrix_filtration(img.Width, img.Height, Filter.pixel, Filter.N2, Filter.blur);
                img = IPM.FromPixelToBitmap(img);
                updateLastImage(img);
            }
        }

        private void методЛToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("Картинка не была выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bitmap img = Convolution.KirschFilter(LastImage);
                updateLastImage(img);
            }
        }

        private void методЛапласаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("Картинка не была выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bitmap img = Convolution.Laplacian3x3Filter(LastImage);
                updateLastImage(img);
            }
        }

        private void методРобертсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("Картинка не была выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bitmap img = Convolution.RobertsFilter(LastImage);
                updateLastImage(img);
            }
        }

        private void методСопелаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("Картинка не была выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bitmap img = Convolution.Sobel3x3Filter(LastImage);
                updateLastImage(img);
            }
        }

        private void Main_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

            Console.WriteLine(EditedList.Count);
        }

        private void яркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brightness b = new Brightness(this);
            b.Show();
        }

        private void контрастностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contrast c = new Contrast(this);
            c.Show();
        }
    }
}
