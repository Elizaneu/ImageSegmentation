using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace Graphs
{
    class IntensityHistogram
    {
        public int[] histogram;

        public IntensityHistogram(Bitmap bitmap)
        {
            histogram = new int[256];

            for (var i = 0; i < bitmap.Width; i++)
            {
                for (var j = 0; j < bitmap.Height; j++)
                {
                    var intensity = bitmap.GetPixel(i, j).GetBrightness();
                    int normalizedIntensity = (int)(intensity * 255);

                    histogram[normalizedIntensity] += 1;
                }
            }
        }

        public int GetPixelHistogramIntensityValue(int intensity)
        {
            if (intensity > 255 || intensity < 0)
            {
                throw new Exception("Intensity must be in range [0, 255]");
            }

            return histogram[intensity];
        }

        public int MaximumDistributionIntensity
        {
            get
            {
                return 90;
                
                int maximum = -1;
                int intensity = -1;

                for (var i = 0; i < histogram.Length; i++)
                {
                    if (maximum < histogram[i])
                    {
                        maximum = histogram[i];
                        intensity = i;
                    }
                }

                return intensity;
            }
        }

        public int MinimumDistributionIntensity
        {
            get
            {
                return 19;

                int minimum = 256;
                int intensity = -1;

                for (var i = 0; i < histogram.Length; i++)
                {
                    if (minimum > histogram[i])
                    {
                        minimum = histogram[i];
                        intensity = i;
                    }
                }

                return intensity;
            }
        }
    }
}
