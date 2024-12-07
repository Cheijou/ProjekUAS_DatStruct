using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Application
{
    public partial class FormSorting : Form
    {
        Random random = new Random();
        int banyaknyaData;
        TimeSpan durasiSorting;
        Sort arrayData;

        public FormSorting()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonBubble_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
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
            labelDurasiSorting.Text = durasiSorting.ToString("mm' : 'ss' : 'fff");
            for (int i = 0; i < arrayData.ArrData.Length; i++)
            {
                listBoxResult.Items.Add(arrayData.ArrData[i]);
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
    }
}
