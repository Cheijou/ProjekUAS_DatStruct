using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Application
{
    internal interface ISortEngine
    {
        void DoWork(int[] theData, Graphics graphics, int maximumValue);
    }
}
