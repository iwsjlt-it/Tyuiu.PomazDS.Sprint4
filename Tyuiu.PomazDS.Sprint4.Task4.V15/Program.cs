using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint4.Task4.V15.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint4.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(4, "Двумерные массивы. (ввод с клавиатуры)", 4, 15, "Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с клавиатуры в диапазоне от 2 до 6. Найдите сумму нечетных элементов массива.");

            int lenLines = int.Parse(Console.ReadLine());
            int lenColumn = int.Parse(Console.ReadLine());

            int[,] array = new int[lenLines, lenColumn];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            ptrn.ResultPattern();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]+ ",");
                }
                Console.WriteLine();
            }

            Console.WriteLine(ds.Calculate(array));

            Console.ReadKey();
        }
    }
}
