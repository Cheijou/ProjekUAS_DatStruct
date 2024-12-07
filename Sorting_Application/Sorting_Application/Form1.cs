using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Application
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Sort arrayData;
        int banyaknyaData;
        TimeSpan durasiSorting;

        public Form1()
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
            labelDurasiSorting.Text = durasiSorting.ToString("mm' : 'ss' : 'fff");
            for (int i = 0; i < arrayData.ArrData.Length; i++)
            {
                listBoxResult.Items.Add(arrayData.ArrData[i]);
            }
        }
    }
}
