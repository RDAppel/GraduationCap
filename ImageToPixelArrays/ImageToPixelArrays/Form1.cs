
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ImageToPixelArrays
{
    public partial class Form1 : Form
    {
        private delegate void display(Bitmap image);

        private Bitmap image = null;
        private Dictionary<string, display> formats = new Dictionary<string, display>();

        public Form1()
        {
            InitializeComponent();

            formats.Add("Linear", displayLinearArray);
            formats.Add("Pixel Data", displayPixelArray);
            formats.Add("Grid", displayGridArray);

            foreach(string s in formats.Keys) cboOutputFormat.Items.Add(s);

            cboOutputFormat.SelectedIndex = 0;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateDisplay()
        {
            if (image != null)
            {
                // display image
                float scale = 20;

                int width = (int)(scale * image.Size.Width);
                int height = (int)(scale * image.Size.Height);
                Bitmap scaled = new Bitmap(width, height);
                Graphics graphics = Graphics.FromImage(scaled);
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.DrawImage(image, 0, 0, width, height);
                pbxImage.Image = scaled;


                // update text
                formats[cboOutputFormat.SelectedItem.ToString()](image);
               
            }
        }

        private void displayLinearArray(Bitmap image)
        {
            Size size = image.Size;
            int pixelCount = size.Height * size.Width;
            string data = "byte pixels[] = {";

            int index = 0;
            for (int y = 0; y < size.Height; y++)
            {
                for (int x = 0; x < size.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    index++;
                    data += pixel.R + ", " + pixel.G + ", " + pixel.B;
                    if (index < pixelCount) data += ", ";
                }
            }

            data += " };";
            txtImageData.Text = data;
        }

        private void displayPixelArray(Bitmap image)
        {
            Size size = image.Size;
            int pixelCount = size.Height * size.Width;
            string data = "byte pixels[][3] = { ";

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

        private void rdoDisplay_CheckedChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }
        
        private void displayGridArray(Bitmap image)
        {
            Size size = image.Size;
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

        private void mnuFileOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap Image|*.bmp";

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dlgOpen.FileName);
                Size size = image.Size;
                staSize.Text = size.ToString();

                updateDisplay();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtImageData.Text != null && txtImageData.Text != "")
            {
                Clipboard.SetText(txtImageData.Text);
                MessageBox.Show("Data coppied!");
            }
            else MessageBox.Show("No text to copy.");
        }
    }
}
