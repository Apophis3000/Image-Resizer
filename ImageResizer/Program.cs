using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ImageResizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Bild.jpg";
            Bitmap res = new Bitmap(path);

            Bitmap res = Rescale(path, 1200, 750);
            res.Save(@"C:\Projects\neu.jpg", ImageFormat.Jpeg);
        }

        static Bitmap Rescale(string path, int newWidth, int newHeight)
        {
            Bitmap bmp = new Bitmap(path, true);

            int oldWidth = bmp.Width;
            int oldHeight = bmp.Height;

            Bitmap result = new Bitmap(oldWidth, oldHeight);

            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.DrawImage(result, 0, 0);
            g.Dispose();
            return result;
        }

    }
}
