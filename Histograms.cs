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
    public partial class Histograms : Form
    {
        Main parent;

        int fmax, fmin; //максимальное и минимальное значение яркости изображения

        Bitmap loadedImage;
        public int[,] MatrBright;
        public int[] HistogrammBr, HistogrammR, HistogrammG, HistogrammB;

        private void Histograms_Load(object sender, EventArgs e)
        {

        }

        public Histograms()
        {
            InitializeComponent();
        }

        public Histograms(Main f)
        {
            InitializeComponent();
            parent = f;
            fmin = 1000;
            fmax = -100;
            //createHistogram();
            loadedImage = parent.LastImage;
            this.GetParamImage(loadedImage);
            this.fillHistogramms();
        }

        void GetParamImage(Bitmap tmpImage)
        {
            int i, j;
            int R, G, B;
            MatrBright = new int[loadedImage.Width, loadedImage.Height];
            HistogrammBr = new int[256];
            HistogrammR = new int[256];
            HistogrammG = new int[256];
            HistogrammB = new int[256];
            for (i = 0; i < tmpImage.Width; i++)
            {
                for (j = 0; j < tmpImage.Height; j++)
                {
                    //Получаем значение насыщенности каналов R, G, B
                    R = tmpImage.GetPixel(i, j).R;
                    G = tmpImage.GetPixel(i, j).G;
                    B = tmpImage.GetPixel(i, j).B;
                    //Заполняем таблицу яркостей значениями яркости пикселей
                    MatrBright[i, j] = (int)(0.3 * R + 0.59 * G + 0.11 * B);

                    if (MatrBright[i, j] > fmax)
                        fmax = MatrBright[i, j];
                    if (MatrBright[i, j] < fmin)
                        fmin = (MatrBright[i, j]);

                    //Находим количество пикселей каждого уровня яркости
                    HistogrammBr[MatrBright[i, j]]++;
                    //Находим количество пикселей каждого уровня насыщенности для R, G, B
                    HistogrammR[R]++;
                    HistogrammG[G]++;
                    HistogrammB[B]++;
                }
            }
        }

        void fillHistogramms()
        {
            label1.Text = "Максимальная яркость\n" + Convert.ToString(fmax); //Максимальная яркость
            label2.Text = "Минимальная яркость\n" + Convert.ToString(fmin); //Минимальная яркость

            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series[0].Points.Clear();
            chart2.Series[0].IsVisibleInLegend = false;
            chart2.Series[0].Points.Clear();
            chart3.Series[0].IsVisibleInLegend = false;
            chart3.Series[0].Points.Clear();
            chart4.Series[0].IsVisibleInLegend = false;
            chart4.Series[0].Points.Clear();

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart4.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 0; i < 256; i++)
            {
                chart1.Series[0].Points.AddXY(i, HistogrammBr[i]);
                chart2.Series[0].Points.AddXY(i, HistogrammR[i]);
                chart3.Series[0].Points.AddXY(i, HistogrammG[i]);
                chart4.Series[0].Points.AddXY(i, HistogrammB[i]);
            }
        }
    }
}
