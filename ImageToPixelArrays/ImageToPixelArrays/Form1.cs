using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToPixelArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void displayLinearArray(Bitmap image, Size size)
        {
            int pixelCount = size.Height * size.Width;
            string data = "byte pixels[][3] = {";

            int index = 0;
            for (int y = 0; y < size.Height; y++)
            {
                for (int x = 0; x < size.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    index++;
                    data += "\r\n\t{ " + pixel.R + ", " + pixel.G + ", " + pixel.B + " }";
                    if (index < pixelCount) data += ", ";
                }
            }

            data += "\r\n};";
            txtImageData.Text = data;
        }

        /*
        private void displayGridArray(Bitmap image, Size size)
        {
            string data = "byte pixels[" + size.Height + "][" + size.Width + "][3] = {";

            for (int y = 0; y < size.Height; y++)
            {
                data += "\r\n\t{";
                for (int x = 0; x < size.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    if (x == 0) data += " ";
                    data += "{ " + pixel.R + ", " + pixel.G + ", " + pixel.B + " }";
                    if (x < size.Width - 1) data += ", ";
                }
                data += " }";
                if (y < size.Height - 1) data += ",";
            }

            data += "\r\n};";
            txtImageData.Text = data;
        }
        */

        private void mnuFileOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap Image|*.bmp";
            
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(dlgOpen.FileName);
                Size size = image.Size;
                staSize.Text = size.ToString();
                pbxImage.Image = image;

                displayLinearArray(image, size);
                //displayGridArray(image, size);
            }
        }
    }
}
