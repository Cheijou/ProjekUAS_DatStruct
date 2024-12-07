using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Application
{
    public class Sort
    {
        private int[] arrData;

        public Sort(int jumlahData)
        {
            this.ArrData = new int[jumlahData];
        }

        public int[] ArrData { get => arrData; set => arrData = value; }

        public TimeSpan BubbleSort()
        {
            DateTime waktuMulai = DateTime.Now;
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
            DateTime waktuSelesai = DateTime.Now;
            TimeSpan durasiSorting = waktuSelesai - waktuMulai;
            return durasiSorting;
        }

        int pos;
        public TimeSpan QuickSort(int first, int last)
        {
            DateTime waktuMulai = DateTime.Now;
            if (first < last)
            {
                pos = SplitQuickSort(first, last);
                QuickSort(first, pos - 1);
                QuickSort(pos + 1, last);
            }
            DateTime waktuAkhir = DateTime.Now;
            TimeSpan durasiSorting = waktuAkhir - waktuMulai;
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
        }

        public TimeSpan SelectionSort()
        {
            DateTime waktuMulai = DateTime.Now;

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
            DateTime waktuSelesai = DateTime.Now;

            TimeSpan durasiSorting = waktuSelesai - waktuMulai;

            return durasiSorting;
        }

        //public DateTime MergeSort()
        //{

        //}

        public TimeSpan InsertionSort()
        {
            DateTime waktuMulai = DateTime.Now;

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
            DateTime waktuSelesai = DateTime.Now;
            TimeSpan durasiSorting = waktuSelesai - waktuMulai;
            return durasiSorting;
        }
    }
}
