using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint4.Task1.V16.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint4.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(4, "Одномерные массивы. (ввод с клавиатуры)", 1, 16, "Дан одномерный целочисленный массив на 13 элементов заполненный значениями с клавиатуры в диапазоне от 3 до 8. Подсчитать произведение нечетных эпементов массина. С клавнатуры: 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4", "4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 ");

            Console.Write("Введите количество элементов: ");
            int len = int.Parse(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write("Введите значение элемента {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            ptrn.ResultPattern();

            Console.WriteLine(ds.Calculate(array));

            Console.ReadKey();
        }
    }
}
