using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Graphs
{
    public partial class Main : Form
    {
        // Types
        private enum BrushType
        {
            Background = 0,
            Object = 1,
        };

        // Cursor
        private readonly Queue<Point> cursorQueue;
        private int cursorSize = 10;
        private bool isDrawing;

        // Seeds drawing
        private BrushType activeBrushType;
        private Rectangle renderedImageBounds;
        private byte[,] backgroundSeedSelectionRegion;
        private byte[,] objectSeedSelectionRegion;

        // Drawing surface to image bitmap transformation
        private double zoom;

        public Main()
        {
            InitializeComponent();

            cursorQueue = new Queue<Point>();
            activeBrushType = BrushType.Background;

            inpt_backgroundBrushSize.Value = cursorSize;
            inpt_objectBrushSize.Value = cursorSize;
        }

        /** ### INITALIZATION ### **/

        /**
         * When image is loaded into PictureBox, initialize:
         * - bacgroundSeedSelectionRegion, objectSeedSelectionRegion - surface for drawing selection. It's important to initilize with the size equals to PictureBox size
         * - zoom - property for finding pixels positions in original bitmap
         * - renderedImageBounds - region for determining drawing surface bounds
         * **/
        private void pctrbx_selectedImage_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            backgroundSeedSelectionRegion = new byte[pctrbx_selectedImage.ClientSize.Width, pctrbx_selectedImage.ClientSize.Height];
            objectSeedSelectionRegion = new byte[pctrbx_selectedImage.ClientSize.Width, pctrbx_selectedImage.ClientSize.Height];
            zoom = (double)pctrbx_selectedImage.Image.Size.Width / pctrbx_selectedImage.ClientSize.Width;

            var ratio = (double)pctrbx_selectedImage.Image.Size.Width / pctrbx_selectedImage.Image.Size.Height;

            if (ratio >= 1)
            {
                int newHeight = (int)(pctrbx_selectedImage.ClientSize.Width / ratio);

                renderedImageBounds = new Rectangle(0, (pctrbx_selectedImage.ClientSize.Height - newHeight) / 2, pctrbx_selectedImage.ClientSize.Width, newHeight);
            }
            else
            {
                int newWitdh = (int)(pctrbx_selectedImage.ClientSize.Height * ratio);

                renderedImageBounds = new Rectangle((pctrbx_selectedImage.ClientSize.Width - newWitdh) / 2, 0, newWitdh, pctrbx_selectedImage.ClientSize.Height);
            }
        }

        /** ### CORE FUNCTIONALITY ###  **/

        /**
         * Select image from file system for segmentation
         * **/
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
                    pctrbx_selectedImage.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        /** 
         * Find and print background
         * **/
        private void btn_segmentBackground_Click(object sender, EventArgs e)
        {
            var segmentation = new Segmentation(new Bitmap(pctrbx_selectedImage.Image), Segmentation.Target.Background);
            var bitmap = segmentation.Cut();

            pctrbx_backgroundImage.Image = bitmap;
        }

        /** 
         * Find and print object
         * **/
        private void btn_segmentObject_Click(object sender, EventArgs e)
        {
            var segmentation = new Segmentation(new Bitmap(pctrbx_selectedImage.Image), Segmentation.Target.Object);
            var bitmap = segmentation.Cut();

            pctrbx_objectImage.Image = bitmap;
        }

        /** ### DRAWAING SEED SELECTION REGIONS AND BRUSH SETTINGS **/

        /** 
         * Get brush color for background seed or object seed
         * **/
        private Color GetBrushColor(BrushType type)
        {
            switch (type)
            {
                case BrushType.Background:
                    return Color.LightBlue;

                case BrushType.Object:
                default:
                    return Color.LightPink;
            }
        }

        /** 
         * Draw seed selection region
         * **/
        private void DrawSeedSelectionRegion(Graphics g, byte[,] region, BrushType type)
        {
            using (var brush = new SolidBrush(GetBrushColor(type)))
            {
                if (region != null)
                {
                    for (var i = 0; i < region.GetLength(0); i++)
                    {
                        for (var j = 0; j < region.GetLength(1); j++)
                        {
                            if (region[i, j] != 0)
                            {
                                g.FillRectangle(brush, i, j, 1, 1);
                            }
                        }
                    }
                }
            }
        }
        
        /** 
         * Drawing shapes onto PictureBox of selected image
         * **/
        private void pctrbx_selectedImage_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw cursor and image bounds
            using (var pen = new Pen(GetBrushColor(activeBrushType), 1))
            {
                if (cursorQueue.Count != 0)
                {
                    var point = cursorQueue.Dequeue();

                    g.DrawRectangle(pen, point.X, point.Y, cursorSize, cursorSize);
                }
            }

            using (var pen = new Pen(GetBrushColor(activeBrushType), 3))
            {
                g.DrawRectangle(pen, renderedImageBounds);
            }

            // Draw seeds selection regions
            DrawSeedSelectionRegion(g, backgroundSeedSelectionRegion, BrushType.Background);
            DrawSeedSelectionRegion(g, objectSeedSelectionRegion, BrushType.Object);
        }

        /**
         * Handle mouse moves on PictureBox canvas
         * **/
        private void pctrbx_selectedImage_MouseMove(object sender, MouseEventArgs e)
        {
            bool isXInBounds = e.X >= renderedImageBounds.X && e.X <= renderedImageBounds.X + renderedImageBounds.Width - cursorSize;
            bool isYInBounds = e.Y >= renderedImageBounds.Y && e.Y <= renderedImageBounds.Y + renderedImageBounds.Height - cursorSize;

            if (isXInBounds && isYInBounds)
            {
                // Values in initial image bitmap for evaluation pixel intensities
                var relativeX = (int)(e.X - renderedImageBounds.X * zoom);
                var relativeY = (int)(e.Y - renderedImageBounds.Y * zoom);

                cursorQueue.Enqueue(new Point(e.X, e.Y));

                if (isDrawing)
                {
                    for (var i = e.X; i < e.X + cursorSize; i++)
                    {
                        for (var j = e.Y; j < e.Y + cursorSize; j++)
                        {
                            switch (activeBrushType)
                            {
                                case BrushType.Background:
                                    backgroundSeedSelectionRegion[i, j] = 1;
                                    objectSeedSelectionRegion[i, j] = 0; // Remove pixel from oposite seed region
                                    break;

                                case BrushType.Object:
                                    objectSeedSelectionRegion[i, j] = 1;
                                    backgroundSeedSelectionRegion[i, j] = 0; // Remove pixel from oposite seed region
                                    break;
                            }
                        }
                    }
                }

                pctrbx_selectedImage.Refresh();
            }
        }

        /**
         * Handle mouse click start on PictureBox canvas
         * **/
        private void pctrbx_selectedImage_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        /**
         * Handle mouse click end on PictureBox canvas
         * **/
        private void pctrbx_selectedImage_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        /** 
         * Select background brush
         * **/
        private void btn_selectBackgroundBrush_Click(object sender, EventArgs e)
        {
            activeBrushType = BrushType.Background;

            pctrbx_selectedImage.Refresh();
        }

        /** 
         * Select object brush
         * **/
        private void btn_selectObjectBrush_Click(object sender, EventArgs e)
        {
            activeBrushType = BrushType.Object;

            pctrbx_selectedImage.Refresh();
        }

        /** 
         * Change background brush size
         * **/
        private void inpt_backgroundBrushSize_ValueChanged(object sender, EventArgs e)
        {
            cursorSize = (int)inpt_backgroundBrushSize.Value;
        }

        /** 
         * Change background brush size
         * **/
        private void inpt_objectBrushSize_ValueChanged(object sender, EventArgs e)
        {
            cursorSize = (int)inpt_objectBrushSize.Value;
        }
    }
}
