using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint4.Task0.V24.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint4.Task0.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(4, "Одномерные массивы (статический ввод)", 0, 24, "Дан одномерный целечисленный массив на 10 элементов заполненный статическими значениями в диапазоне от 0 до 9 подсчитать произведение четных элементов массива. {9, 5, 7, 4, 5, 3, 7, 8, 9, 1}", "{9, 5, 7, 4, 5, 3, 7, 8, 9, 1}");

            ptrn.ResultPattern();

            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            Console.WriteLine("result = {0}", ds.GetMultEvenArrEl(array));

            Console.ReadKey();
        }
    }
}
