using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    static class IPM
    {
        public static Bitmap negativeImage(this Bitmap srcImg)
        {
            Bitmap img = new Bitmap(srcImg);
            int i, j;
            int Red, Green, Blue;
            for (i = 0; i < img.Width; i++)
            {
                for (j = 0; j < img.Height; j++)
                {
                    Red = img.GetPixel(i, j).R;
                    Red = 255 - Red;
                    Green = img.GetPixel(i, j).G;
                    Green = 255 - Green;
                    Blue = img.GetPixel(i, j).B;
                    Blue = 255 - Blue;
                    img.SetPixel(i, j, Color.FromArgb(Red, Green, Blue));
                }
            }
            return img;
        }

        public static Bitmap grayImage(this Bitmap srcImg)
        {
            Bitmap img = new Bitmap(srcImg);

            int i, j;
            int Gray;
            for (i = 0; i < img.Width; i++)
            {
                for (j = 0; j < img.Height; j++)
                {
                    Gray = (int)(0.3 * img.GetPixel(i, j).R + 0.59 * img.GetPixel(i, j).G + 0.11 * img.GetPixel(i, j).B);
                    img.SetPixel(i, j, Color.FromArgb(Gray, Gray, Gray));
                }
            }
            return img;
        }

        public static Bitmap applyNoise(this Bitmap srcImg, int chanse, bool toGray)
        {
            Bitmap img = new Bitmap(srcImg);
            var rnd = new Random();
            int i, j;
            int n;
            for (i = 0; i < img.Width; i++)
            {
                for (j = 0; j < img.Height; j++)
                {
                    n = rnd.Next(0, 101);
                    if (n <= chanse)
                    {
                        img.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        if (toGray)
                        {
                            int Gray = (int)(0.3 * img.GetPixel(i, j).R + 0.59 * img.GetPixel(i, j).G + 0.11 * img.GetPixel(i, j).B);
                            img.SetPixel(i, j, Color.FromArgb(Gray, Gray, Gray));
                        }
                    }
                    n = rnd.Next(0, 101);
                    if (n <= chanse)
                    {
                        img.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        if (toGray)
                        {
                            int Gray = (int)(0.3 * img.GetPixel(i, j).R + 0.59 * img.GetPixel(i, j).G + 0.11 * img.GetPixel(i, j).B);
                            img.SetPixel(i, j, Color.FromArgb(Gray, Gray, Gray));
                        }
                    }
                }
            }
            return img;
        }

        public static Bitmap binareImage(this Bitmap srcImg, int value, Color color1, Color color2)
        {
            //value - значение уровня бинаризации 
            //Бианризация переход к чёрно-белому изображению 
            Bitmap img = new Bitmap(srcImg);
            double Bright;
            int i, j;
            for (i = 0; i < img.Width; i++)
            {
                for (j = 0; j < img.Height; j++)
                {
                    //Получаем уровень яркости для преобразуемого пикселя
                    Bright = 0.3 * img.GetPixel(i, j).R + 0.59 * img.GetPixel(i, j).G + 0.11 * img.GetPixel(i, j).B;
                    if ((int)Bright > value)
                    {
                        //Если яркость пикселя больше порогового значения
                        //Заполняем его белым цветом и сохраняем значение логической матрицы
                        img.SetPixel(i, j, color1);
                    }
                    else
                    {
                        //Если яркость пикселя меньше порогового значения
                        //Заполняем его черным цветом и сохраняем значение логической матрицы
                        img.SetPixel(i, j, color2);
                    }
                }
            }
            return img;
        }

        public static Bitmap setPixels(this Bitmap srcImg)
        {
            Bitmap img = new Bitmap(srcImg);

            Filter.pixel = new UInt32[img.Height, img.Width];
            for (int y = 0; y < img.Height; y++)
                for (int x = 0; x < img.Width; x++)
                    Filter.pixel[y, x] = (UInt32)(img.GetPixel(x, y).ToArgb());
            return img;
        }
        public static Bitmap FromPixelToBitmap(this Bitmap srcImg)
        {
            Bitmap img = new Bitmap(srcImg);

            for (int y = 0; y < img.Height; y++)
                for (int x = 0; x < img.Width; x++)
                    img.SetPixel(x, y, Color.FromArgb((int)Filter.pixel[y, x]));
            return img;
        }

        public static Bitmap ChangeImage(this Bitmap srcImg, float contrast, float brightness)
        {
            Bitmap img = new Bitmap(srcImg);

            float C = contrast / 100; //контрастность (норма = 1)
            float B = brightness / 100; //яркость (от -1 до 1, норма = 0)

            float[][] matrix = {
                new float[] { C, 0, 0, 0, 0 } , //R
                new float[] { 0, C, 0, 0, 0 } , //G
                new float[] { 0, 0, C, 0, 0 } , //B
                new float[] { 0, 0, 0, 1, 0 } , //A
                new float[] { B, B, B, 0, 1 } //W
                };

            ImageAttributes attr = new ImageAttributes();
            attr.SetColorMatrix(new ColorMatrix(matrix));

            using (Graphics g = Graphics.FromImage(img))
            {
                Rectangle rect = new Rectangle(0, 0, img.Width, img.Height);
                g.DrawImage(img, rect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attr);
            }

            return img;
        }

        public static Bitmap Contrast(this Bitmap sourceBitmap, int threshold)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                        sourceBitmap.Width, sourceBitmap.Height),
                                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);


            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];


            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);


            sourceBitmap.UnlockBits(sourceData);


            double contrastLevel = Math.Pow((100.0 + threshold) / 100.0, 2);


            double blue = 0;
            double green = 0;
            double red = 0;


            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                blue = ((((pixelBuffer[k] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0;


                green = ((((pixelBuffer[k + 1] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0;


                red = ((((pixelBuffer[k + 2] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0;


                if (blue > 255)
                { blue = 255; }
                else if (blue < 0)
                { blue = 0; }


                if (green > 255)
                { green = 255; }
                else if (green < 0)
                { green = 0; }


                if (red > 255)
                { red = 255; }
                else if (red < 0)
                { red = 0; }


                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }


            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);


            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);


            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);


            return resultBitmap;
        }
        public static Bitmap Brightness(Bitmap Image, int Value)
        {

            Bitmap TempBitmap = Image;

            Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);

            Graphics NewGraphics = Graphics.FromImage(NewBitmap);

            float FinalValue = (float)Value / 255.0f;

            float[][] FloatColorMatrix ={

                    new float[] {1, 0, 0, 0, 0},

                    new float[] {0, 1, 0, 0, 0},

                    new float[] {0, 0, 1, 0, 0},

                    new float[] {0, 0, 0, 1, 0},

                    new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                };

            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);

            ImageAttributes Attributes = new ImageAttributes();

            Attributes.SetColorMatrix(NewColorMatrix);

            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);

            Attributes.Dispose();

            NewGraphics.Dispose();

            return NewBitmap;
        }
    }
    }
