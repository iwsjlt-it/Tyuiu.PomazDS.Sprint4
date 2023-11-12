using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PomazDS.Sprint4.Task7.V25.Lib
{
    public class DataService : ISprint4Task7V25
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] array = new int[n, m];

            int sum = 0;
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(value.Substring(count, 1));
                    count++;
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
