using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Graphs
{
    public partial class Main : Form
    {        
        public Main()
        {
            InitializeComponent();
        }

        private void btn_selectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\users\\eliza\\Desktop";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pctrbx_SelectedImage.ImageLocation = openFileDialog.FileName;

                    var graphics = pctrbx_SelectedImage.CreateGraphics();

                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

                    graphics.Save();
                }
            }
        }

        private void btn_buildGraph_Click(object sender, EventArgs e)
        {
            var segmentation = new Segmentation(new Bitmap(pctrbx_SelectedImage.Image));

            segmentation.isDebugLogEndabled = true;
        }

        private void btn_calculateMaxFlow_Click(object sender, EventArgs e)
        {
            var segmentation = new Segmentation(new Bitmap(pctrbx_SelectedImage.Image));

            segmentation.isDebugLogEndabled = true;

            MessageBox.Show(segmentation.GetMaxFlow().ToString());
        }

        private void btn_printGraph_Click(object sender, EventArgs e)
        {
            var segmentation = new Segmentation(new Bitmap(pctrbx_SelectedImage.Image));

            Console.WriteLine(segmentation.GetStringifiedGraph());
        }

        private void btn_segment_Click(object sender, EventArgs e)
        {
            var segmentation = new Segmentation(new Bitmap(pctrbx_SelectedImage.Image));

            //segmentation.isDebugLogEndabled = true;

            var bitmap = segmentation.Cut();

            pctrbx_backgroundImage.Image = bitmap;
        }
    }
}
