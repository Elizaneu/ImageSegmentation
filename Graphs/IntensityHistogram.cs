using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Windows.Forms;

namespace Graphs
{
    class IntensityHistogram
    {
        public int[] histogram;

        private double averageObjectIntensityReference;
        private double averageBackgroundIntensityReference;

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

            GetDefaultSeedsValues();
        }

        public double AverageObjectIntensityReferece
        {
            get
            {
                return averageObjectIntensityReference;
            }
        }

        public double AverageBackgroundIntensityReference
        { 
            get
            {
                return averageBackgroundIntensityReference;
            }
        }

        private void GetDefaultSeedsValues()
        {
            averageObjectIntensityReference = 0;
            averageBackgroundIntensityReference = 0;
            
            int[] backwardIndexMap = new int[256];

            for (var i = 0; i < 256; i++)
            {
                backwardIndexMap[i] = i;
            }

            var sortedHistogram = QuickSort(histogram.ToArray(), backwardIndexMap);

            int maxDiff = 0;
            int maxDiffIndex = -1;

            for (var i = 0; i < 255; i++)
            {
                var diff = sortedHistogram[i + 1] - sortedHistogram[i];

                if (maxDiff < diff)
                {
                    maxDiff = diff;
                    maxDiffIndex = i;
                }
            }

            int objectIntensityPartitionLength = 0;
            int backgroundIntensityPartitionLength = 0;
            bool isLeftPartitionSmaller = maxDiffIndex < 127;

            for (var i = 0; i < 256; i++)
            {
                if (histogram[backwardIndexMap[i]] > 0)
                {
                    if (isLeftPartitionSmaller)
                    {
                        if (i < maxDiffIndex)
                        {
                            averageObjectIntensityReference += backwardIndexMap[i];
                            objectIntensityPartitionLength += 1;
                        }
                        else
                        {
                            averageBackgroundIntensityReference += backwardIndexMap[i];
                            backgroundIntensityPartitionLength += 1;
                        }
                    }
                    else
                    {
                        if (i < maxDiffIndex)
                        {
                            averageBackgroundIntensityReference += backwardIndexMap[i];
                            backgroundIntensityPartitionLength += 1;
                        }
                        else
                        {
                            averageObjectIntensityReference += backwardIndexMap[i];
                            objectIntensityPartitionLength += 1;
                        }
                    }
                }
            }

            averageObjectIntensityReference /= objectIntensityPartitionLength;
            averageBackgroundIntensityReference /= backgroundIntensityPartitionLength;

            MessageBox.Show(averageObjectIntensityReference + " " + averageBackgroundIntensityReference);
        }

        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        static int Partition(int[] array, int minIndex, int maxIndex, int[] indexMap)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref indexMap[pivot], ref indexMap[i]);
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref indexMap[pivot], ref indexMap[maxIndex]);
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        static int[] QuickSort(int[] array, int minIndex, int maxIndex, int[] indexMap)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex, indexMap);
            QuickSort(array, minIndex, pivotIndex - 1, indexMap);
            QuickSort(array, pivotIndex + 1, maxIndex, indexMap);

            return array;
        }

        static int[] QuickSort(int[] array, int[] indexMap)
        {
            return QuickSort(array, 0, array.Length - 1, indexMap);
        }
    }
}
