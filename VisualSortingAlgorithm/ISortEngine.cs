using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSortingAlgorithm
{
    internal interface ISortEngine
    {
        void DoWork(int[] ArrNum, Graphics g, int MaxVal);
    }
}
