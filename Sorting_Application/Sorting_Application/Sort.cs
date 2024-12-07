﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
        
        public DateTime QuickSort()
        {
            return DateTime.Now;
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
