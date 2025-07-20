using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSortingAlgorithm
{
    class SortEngineBubble : ISortEngine
    {
        private bool _sorted = false;
        private int[] arrNum;
        private Graphics g;
        private int MaxVal;
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        Brush RedBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        public void DoWork(int[] ArrNum_In, Graphics g_In, int MaxVal_In) // Giving them local "In" names
        {
            arrNum = ArrNum_In;
            g = g_In;
            MaxVal = MaxVal_In;

            while (!_sorted) // loop until the boolean value "_sorted" is true
            {
                for(int i = 0; i < arrNum.Count() -1; i++)
                {
                    if (arrNum[i] > arrNum[i + 1])
                    {
                        // sawp the values
                        Swap(i, i + 1);

                    }
                }
                _sorted = IsSorted(); // create IsSorted method that returns true or false
            }
        }

        private void Swap(int i, int v)
        {
            //Swap the values
            int temp = arrNum[i];
            arrNum[i] = arrNum[v];
            arrNum[v] = temp;

            // remove old values from display
            g.FillRectangle(RedBrush, i, 0, 1, MaxVal);
            g.FillRectangle(BlackBrush, i, 0, 1, MaxVal);
            g.FillRectangle(RedBrush, v, 0, 1, MaxVal);
            g.FillRectangle(BlackBrush, v, 0, 1, MaxVal);

            // add new values to display
            g.FillRectangle(RedBrush, i, MaxVal - arrNum[i], 1, MaxVal);
            g.FillRectangle(WhiteBrush, i, MaxVal - arrNum[i], 1, MaxVal);
            g.FillRectangle(RedBrush, v, MaxVal - arrNum[v], 1, MaxVal);
            g.FillRectangle(WhiteBrush, v, MaxVal - arrNum[v], 1, MaxVal);

            // learn how to optimize sorting algorithms and graphics
        }

        private bool IsSorted()
        {
           for (int i = 0; i < arrNum.Count() - 1; i++)
            {
                    if (arrNum[i] > arrNum[i + 1]) return false;
                
                
            }
           return true;
        }
    }
}
