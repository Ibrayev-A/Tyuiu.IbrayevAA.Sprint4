using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.IbrayevAA.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int max = array[3, 0];

            for (int j = 0; j < 5; j++)
            {
                if (array[3, j] > max)
                    max = array[3, j];
            }
        return max;
        }
    }
}
