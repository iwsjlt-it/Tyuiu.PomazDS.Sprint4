using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint4.Task5.V22.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint4.Task5.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();
            Random rnd = new Random();

            ptrn.MainPattern(4, "Двумерные массивы. (генератор случайных чисел)", 5, 22, "Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными значениями в диапазоне от -8 до 9. Найти количество отрицательных элементов.");

            int lenLines = int.Parse(Console.ReadLine());
            int lenColumn = int.Parse(Console.ReadLine());

            int[,] array = new int[lenLines, lenColumn];



            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-8, 10);
                }
            }

            ptrn.ResultPattern();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + ",");
                }
                Console.WriteLine();
            }

            Console.WriteLine(ds.Calculate(array));

            Console.ReadKey();
        }
    }
}
