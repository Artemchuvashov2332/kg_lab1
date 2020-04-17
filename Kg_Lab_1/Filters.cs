using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

//Классы фильтров

namespace Kg_Lab_1
{
    abstract class Filters
    {
        protected abstract Color calculateNewPixelColor(Bitmap sourseImage, int x, int y);
        public Bitmap processImage(Bitmap sourceImage,BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }

            return resultImage;
        }

        public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
    }

    //далее точечные фильтры

    //инверсия
    class InvertFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            Color sourceColor = sourseImage.GetPixel(x, y);

            Color resultColor = Color.FromArgb(255 - sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);
            return resultColor;
        }
    }

    //оттенки серого
    class GrayScaleFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = Convert.ToInt32(sourceColor.R * 0.299 + sourceColor.G * 0.587 + sourceColor.B * 0.114);
            intensity = Clamp(intensity, 0, 255);
            Color resultColor = Color.FromArgb(intensity,
                                               intensity,
                                               intensity);
            return resultColor;
        }
    }

    //сепия
    class SepiaFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            Color sourceColor = sourseImage.GetPixel(x, y);

            double k = 60.0;
            double intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;

            Color resultColor = Color.FromArgb(Clamp((int)(intensity + 2.0 * k), 0, 255),
                                                  Clamp((int)(intensity + k * 0.5), 0, 255),
                                                    Clamp((int)(intensity - 1.0 * k), 0, 255));
            return resultColor;
        }
    }

    //увеличение яркости
    class IncreaseBrightness : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(Clamp(sourceColor.R + 10, 0, 255),
                                               Clamp(sourceColor.G + 10, 0, 255),
                                               Clamp(sourceColor.B + 10, 0, 255));
            return resultColor;
        }
    }

    //"Серый мир"
    class GrayWorldFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            Color sourceColor = sourseImage.GetPixel(x, y);

            Color resultColor = Color.FromArgb(255 - sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);
            return resultColor;
        }

        public Bitmap processImage(Bitmap sourseImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourseImage.Width, sourseImage.Height);

            double R = 0.0, G = 0.0, B = 0.0;
            double Avg = 0.0;

            Color temp;
            for (int i = 0; i < sourseImage.Width; i++)
                for (int j = 0; j < sourseImage.Height; j++)
                {
                    temp = sourseImage.GetPixel(i, j);
                    R += temp.R; G += temp.G; B += temp.B;
                }
            R = (double)R / (sourseImage.Width * sourseImage.Height);
            G = (double)G / (sourseImage.Width * sourseImage.Height);
            B = (double)B / (sourseImage.Width * sourseImage.Height);
            Avg = (R + G + B) / 3.0d;

            Color sourceColor, resultColor;

            for (int i = 0; i < sourseImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourseImage.Height; j++)
                {
                    sourceColor = sourseImage.GetPixel(i, j);
                    resultColor = Color.FromArgb(Clamp((int)(sourceColor.R * Avg / R), 0, 255),
                                                Clamp((int)(sourceColor.G * Avg / G), 0, 255),
                                                  Clamp((int)(sourceColor.B * Avg / B), 0, 255));

                    resultImage.SetPixel(i, j, resultColor);
                }
            }
            return resultImage;
        }
    }

    //линейное растяжение гистограммы
    class LinearStretchingHistogram : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return sourceImage.GetPixel(x, y);
        }
        public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap result = new Bitmap(sourceImage.Width, sourceImage.Height);
            int XminR = 0, XmaxR = 0, XmaxG = 0, XminG = 0, XmaxB = 0, XminB = 0;
            double progress = 0.0;

            for (int i = 0; i < sourceImage.Width; i++, progress += 0.5)
            {
                worker.ReportProgress((int)((float)progress / sourceImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color tmp = sourceImage.GetPixel(i, j);
                    if (XminR > tmp.R)
                        XminR = tmp.R;

                    if (XmaxR < tmp.R)
                        XmaxR = tmp.R;

                    if (XminG > tmp.G)
                        XminG = tmp.G;

                    if (XmaxG < tmp.G)
                        XmaxG = tmp.G;

                    if (XminB > tmp.B)
                        XminB = tmp.B;

                    if (XmaxB < tmp.B)
                        XmaxB = tmp.B;
                }
            }
            for (int i = 0; i < sourceImage.Width; i++, progress += 0.5)
            {
                worker.ReportProgress((int)((float)progress / sourceImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int R = sourceImage.GetPixel(i, j).R;
                    int G = sourceImage.GetPixel(i, j).G;
                    int B = sourceImage.GetPixel(i, j).B;
                    result.SetPixel(i, j, Color.FromArgb(Clamp(Clamp(((255 * (R - XminR)) / (XmaxR - XminR)), 0, 255) + R, 0, 255),
                                                         Clamp(Clamp(((255 * (G - XminR)) / (XmaxG - XminG)), 0, 255) + G, 0, 255),
                                                         Clamp(Clamp(((255 * (B - XminR)) / (XmaxB - XminB)), 0, 255) + B, 0, 255)));
                }
            }
            return result;
        }
    }

    //волны
    class WavesFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            int xx = (int)(x + 20 * Math.Sin(2.0 * Math.PI * y / 60.0));
            int yy = y;

            if ((xx < sourseImage.Width - 1) && (yy < sourseImage.Height - 1) && (xx > 0) && (yy > 0))
            {
                Color resultColor = sourseImage.GetPixel(xx, yy);
                return resultColor;
            }
            return Color.Transparent;
        }
    }

    //стекло
    class GlassFilter : Filters
    {
        private Random rand = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int k, l;
            k = Clamp((int)(x + (rand.NextDouble() - 0.5) * 10), 0, sourceImage.Width - 1);
            l = Clamp((int)(y + (rand.NextDouble() - 0.5) * 10), 0, sourceImage.Height - 1);
            Color sourceColor = sourceImage.GetPixel(k, l);
            Color resultColor = Color.FromArgb(sourceColor.R, sourceColor.G, sourceColor.B);

            return resultColor;
        }
    }


    //матричные фильтры
    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;

            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourseImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourseImage.Height - 1);
                    Color neighColor = sourseImage.GetPixel(idX, idY);
                    resultR += neighColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighColor.B * kernel[k + radiusX, l + radiusY];
                }
            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }

    }

    //эффект размытия
    class BlurFilter : MatrixFilter
    {
        public BlurFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                {
                    kernel[i, j] = 1.0f / (float)(sizeX * sizeY);
                }
        }
    }

    //фильтр Гаусса
    class GaussianFilter : MatrixFilter
    {
        public GaussianFilter()
        {
            createGaussianKernel(3, 2);
        }
        public void createGaussianKernel(int radius, float sigma)
        {
            //определение размера ядра
            int size = 2 * radius + 1;
            //создание ядра фильтра
            kernel = new float[size, size];
            //коэффициент нормировки ядра
            float norm = 0;
            //рассчитывание ядра линейного фильтра
            for (int i = -radius; i <= radius; i++)
                for (int j = -radius; j <= radius; j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (2 * sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            //нормирование ядра
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    kernel[i, j] /= norm;
        }
    }

    //резкость
    class SharpnessFilter : MatrixFilter
    {
        public SharpnessFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                {
                    if ((i == 1) && (j == 1))
                    {
                        kernel[i, j] = 9.0f;
                    }
                    else
                        kernel[i, j] = -1.0f;
                }
        }
    }



}

