using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Sorting_Application
{
    public class Sort : ISortEngine
    {
        private int[] arrData;
        private Stopwatch stopwatch;

        private bool isSorted = false;
        private Graphics graphics;
        private int maximumValue;
        Brush whiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush blackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

        public static int sortingMethod;
        public static bool isVisualize = false;
        public void DoWork(int[] theData, Graphics g, int maxValue)
        {
           arrData = theData;
           graphics = g;
           maximumValue = maxValue;

           while (isSorted == false)
           {
                if (sortingMethod == 1)
                {
                    FormSortingVisualizer.durasiSorting = BubbleSortVisualization();
                }
                else if (sortingMethod == 2)
                { 
                    FormSortingVisualizer.durasiSorting = InsertionSortVisualization();
                }
                else if (sortingMethod == 3)
                {
                    FormSortingVisualizer.durasiSorting = SelectionSortVisualization();
                }
                else if (sortingMethod == 4)
                {
                    ClearVisualization();
                    FormSortingVisualizer.durasiSorting = MergeSort();
                }
                else if (sortingMethod == 5)
                {
                    ClearVisualization();
                    FormSortingVisualizer.durasiSorting = QuickSort(0, this.ArrData.Length - 1);
                }
                isSorted = IsSorted();
           }
        }

        private bool IsSorted()
        {
            for (int i = 0; i < arrData.Count() - 1; i++)
            {
                if (arrData[i] > arrData[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public Sort(int jumlahData)
        {
            this.ArrData = new int[jumlahData];
        }

        public int[] ArrData
        {
            get => arrData;

            set
            {
                if (value.Length >= 500 || isVisualize == true)
                {
                    arrData = value;
                }
                else
                {
                    throw new Exception("Column length's minimum is 5000");
                }
            }
        }

        public void GenerateData()
        {
            Random random = new Random();
            this.ArrData = new int[FormSorting.banyaknyaData];
            for (int i = 0; i < this.ArrData.Length; i++)
            {
                this.ArrData[i] = random.Next(FormSorting.banyaknyaData);
            }
        }


        public void ClearVisualization()
        {
            graphics.FillRectangle(blackBrush, 0, 0, this.ArrData.Length, maximumValue);
        }

        public void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
       
        }
        #region Bubble Sort
        public TimeSpan BubbleSort()
        {
            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            int temp;
            for (int i = 1; i < ArrData.Length; i++)
            {
                for (int j = 0; j < ArrData.Length - i; j++)
                {
                    if (ArrData[j] > ArrData[j+1])
                    {
                        temp = ArrData[j];
                        ArrData[j] = ArrData[j+1];
                        ArrData[j+1] = temp;
                    }
                }
            }
            stopwatch.Stop();
            TimeSpan durasiSorting = stopwatch.Elapsed;
            return durasiSorting;
        }

        public TimeSpan BubbleSortVisualization()
        {
            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            int temp;
            for (int i = 1; i < ArrData.Length; i++)
            {
                for (int j = 0; j < ArrData.Length - i; j++)
                {
                    if (ArrData[j] > ArrData[j + 1])
                    {
                        temp = ArrData[j];
                        ArrData[j] = ArrData[j + 1];
                        ArrData[j + 1] = temp;

                        graphics.FillRectangle(blackBrush, j, 0, 1, maximumValue);
                        graphics.FillRectangle(blackBrush, j + 1, 0, 1, maximumValue);

                        graphics.FillRectangle(whiteBrush, j, maximumValue - ArrData[j], 1, maximumValue);
                        graphics.FillRectangle(whiteBrush, j+1, maximumValue - ArrData[j+1], 1, maximumValue);
                    }
                }
            }
            stopwatch.Stop();
            TimeSpan durasiSorting = stopwatch.Elapsed;
            return durasiSorting;
        }
        #endregion

        #region Quick Sort
        int pos;
        public TimeSpan QuickSort(int first, int last)
        {
            DateTime startSorting = DateTime.Now;
            
            if (first < last)
            {
                pos = SplitQuickSort(first, last);
                QuickSort(first, pos - 1);
                QuickSort(pos + 1, last);
            }
            DateTime endSorting = DateTime.Now;
            TimeSpan durasiSorting = endSorting - startSorting;
            return durasiSorting; 

        }

        public int SplitQuickSort(int first, int last)
        {
            int pivot = ArrData[first];
            int left = first;
            int right = last;
            while (left < right)
            {
                while (ArrData[right] > pivot)
                {
                    right--;
                }
                while (left < right && ArrData[left] <= pivot)
                {
                    left++;
                }
                if (left < right)
                {
                    Tukar(left, right);
                }
            }
            pos = right;
            ArrData[first] = ArrData[pos];
            ArrData[pos] = pivot;
            return pos;
        }

        public void Tukar(int left, int right)
        {
            int temp = ArrData[right];
            ArrData[right] = ArrData[left];
            arrData[left] = temp;

            if (isVisualize == true)
            {
                DrawData(left, arrData[left]);
                DrawData(right, arrData[right]);
            }
        }

        public void DrawData(int position, int height)
        {
            if (position >= 2)
            {
                graphics.FillRectangle(blackBrush, position + position, 0, 1, maximumValue);
                graphics.FillRectangle(whiteBrush, position + position, maximumValue - height, 1, maximumValue);
            }
            else if (position == 1)
            {
                
                graphics.FillRectangle(blackBrush, position + 1, 0, 1, maximumValue);
                graphics.FillRectangle(whiteBrush, position + 1, maximumValue - height, 1, maximumValue);
            }
            else
            {
                graphics.FillRectangle(blackBrush, position, 0, 1, maximumValue);
                graphics.FillRectangle(whiteBrush, position, maximumValue - height, 1, maximumValue);
            }
        }
        #endregion

        #region Selection Sort
        public TimeSpan SelectionSort()
        {
            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            for (int i = 0; i < ArrData.Length - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < ArrData.Length; j++)
                {
                    if (ArrData[j] < ArrData[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = ArrData[min_idx];
                ArrData[min_idx] = ArrData[i];
                ArrData[i] = temp;
            }
            stopwatch.Stop();

            TimeSpan durasiSorting = stopwatch.Elapsed;

            return durasiSorting;
        }

        public TimeSpan SelectionSortVisualization()
        {
            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            for (int i = 0; i < ArrData.Length - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < ArrData.Length; j++)
                {
                    if (ArrData[j] < ArrData[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = ArrData[min_idx];
                ArrData[min_idx] = ArrData[i];
                ArrData[i] = temp;

                graphics.FillRectangle(blackBrush, i, 0, 1, maximumValue);
                graphics.FillRectangle(whiteBrush, i, maximumValue - ArrData[i], 1, maximumValue);

                graphics.FillRectangle(blackBrush, min_idx, 0, 1, maximumValue);
                graphics.FillRectangle(whiteBrush, min_idx, maximumValue - ArrData[min_idx], 1, maximumValue);
            }
            stopwatch.Stop();

            TimeSpan durasiSorting = stopwatch.Elapsed;

            return durasiSorting;
        }
        #endregion

        #region Merge Sort
        public TimeSpan MergeSort()
        {
            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            //hasil array yang sudah urut dimasukan ke properti
            this.ArrData = MergeSortRecursive(this.ArrData);
            stopwatch.Stop();
            TimeSpan durasiSorting = stopwatch.Elapsed;
            return durasiSorting;
        }

        private int[] MergeSortRecursive(int[] data)
        {
            //array sudah urut dan di return
            if (data.Length <= 1)
            {
                return data;
            }

            int mid = data.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[data.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = data[i];
            }

            for (int i = mid; i < data.Length; i++)
            {
                right[i - mid] = data[i];
            }

            //direkursif terus sampai urut
            left = MergeSortRecursive(left);
            right = MergeSortRecursive(right);

            //kedua array kanan dan kiri yang sudah urut digabung
            return Merge(left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k] = left[i];

                    if (isVisualize == true)
                    {
                        DrawData(k, result[k]);
                    }
                    
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    if (isVisualize == true)
                    {
                        DrawData(k, result[k]);
                    }
                    j++;
                }
                k++;
            }
            while (i < left.Length)
            {
                result[k] = left[i];
                if (isVisualize == true)
                {
                    DrawData(k, result[k]);
                }
                i++;
                k++;
            }
            while (j < right.Length)
            {
                result[k] = right[j];
                if (isVisualize == true)
                {
                    DrawData(k, result[k]);
                }
                j++;
                k++;
            }
            return result;
        }
        #endregion

        #region Insertion Sort
        public TimeSpan InsertionSort()
        {
            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            for (int j = 1; j < ArrData.Length; j++)
            {
                int key = ArrData[j];
                int i = j - 1;
                while (i >= 0 && ArrData[i] > key) 
                {
                    ArrData[i + 1] = ArrData[i];
                    i -= 1;
                }
                ArrData[i+1] = key;
            }
            stopwatch.Stop();
            TimeSpan durasiSorting = stopwatch.Elapsed;
            return durasiSorting;
        }

        public TimeSpan InsertionSortVisualization()
        {
            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            for (int j = 1; j < ArrData.Length; j++)
            {
                int key = ArrData[j];
                int i = j - 1;
                while (i >= 0 && ArrData[i] > key)
                {
                    ArrData[i + 1] = ArrData[i];
                    graphics.FillRectangle(blackBrush, i, 0, 1, maximumValue);
                    graphics.FillRectangle(whiteBrush, i, maximumValue - ArrData[i], 1, maximumValue);
                    i -= 1;
                }
                ArrData[i + 1] = key;
                graphics.FillRectangle(blackBrush, i + 1, 0, 1, maximumValue);
                graphics.FillRectangle(whiteBrush, i + 1, maximumValue - ArrData[i+1], 1, maximumValue);
            }
            stopwatch.Stop();
            TimeSpan durasiSorting = stopwatch.Elapsed;
            return durasiSorting;
        }
        #endregion
    }
}
