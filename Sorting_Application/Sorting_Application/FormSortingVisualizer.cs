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
    public partial class FormSortingVisualizer : Form
    {
        int[] theData;
        Graphics graphics;
        public static TimeSpan durasiSorting;

        public FormSortingVisualizer()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            graphics = panelVisualization.CreateGraphics();
            int numberOfEntries = panelVisualization.Width;
            int maximumValue = panelVisualization.Height;
            theData = new int[numberOfEntries];

            graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, numberOfEntries, maximumValue);
            Random random = new Random();
            for (int i = 0;  i < numberOfEntries; i++)
            {
                theData[i] = random.Next(0, maximumValue);
            }
            for (int i = 0; i < numberOfEntries; i++)
            {
                graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, maximumValue - theData[i], 1, maximumValue);
            }
        }

        private void buttonStartSorting_Click(object sender, EventArgs e)
        {
            Sort.isVisualize = true;
            ISortEngine sortEngine = new Sort(panelVisualization.Height);
            sortEngine.DoWork(theData, graphics, panelVisualization.Height);
            labelDurasiSorting.Text = durasiSorting.ToString("mm' : 'ss' : 'fff");
        }

        private void comboBoxSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort.sortingMethod = comboBoxSorting.SelectedIndex + 1;
        }
    }
}
