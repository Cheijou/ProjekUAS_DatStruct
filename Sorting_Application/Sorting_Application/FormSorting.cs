using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Application
{
    public partial class FormSorting : Form
    {
        Random random = new Random();
        public static int banyaknyaData;
        TimeSpan durasiSorting;
        Sort arrayData;

        public FormSorting()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxResult.Items.Clear();
                banyaknyaData = int.Parse(textBoxBanyakData.Text);
                arrayData = new Sort(banyaknyaData);
                for (int i = 0; i < arrayData.ArrData.Length; i++)
                {
                    arrayData.ArrData[i] = random.Next(banyaknyaData * 2);
                }
                if (radioButtonBubble.Checked == true)
                {
                    durasiSorting = arrayData.BubbleSort();
                }
                else if (radioButtonInsertion.Checked == true)
                {
                    durasiSorting = arrayData.InsertionSort();
                }
                else if (radioButtonSelection.Checked == true)
                {
                    durasiSorting = arrayData.SelectionSort();
                }
                else if (radioButtonQuick.Checked == true)
                {
                    int first = 0;
                    int last = arrayData.ArrData.Length - 1;
                    durasiSorting = arrayData.QuickSort(first, last);
                }
                else if (radioButtonMerge.Checked == true) 
                {
                    durasiSorting = arrayData.MergeSort();
                }
                labelDurasiSorting.Text = durasiSorting.ToString("mm' : 'ss' : 'fff");
                for (int i = 0; i < arrayData.ArrData.Length; i++)
                {
                    listBoxResult.Items.Add(arrayData.ArrData[i]);
                }
            }
            catch (Exception ex)
            {
                if(ex is FormatException)
                    MessageBox.Show("please input the number format correctly");
                else
                    MessageBox.Show(ex.Message);
                textBoxBanyakData.Clear();
                textBoxBanyakData.Focus();
            }
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxBanyakData.Clear();
            listBoxResult.Items.Clear();
            radioButtonBubble.Checked = false;
            radioButtonInsertion.Checked = false;
            radioButtonSelection.Checked = false;
            radioButtonMerge.Checked = false;
            radioButtonQuick.Checked = false;
            textBoxBanyakData.Focus();
        }

        private void buttonVisualize_Click(object sender, EventArgs e)
        {
            FormSortingVisualizer formVisualize = new FormSortingVisualizer();
            formVisualize.Owner = this;
            formVisualize.ShowDialog();
        }
    }
}
