using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint4.Task7.V25.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint4.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();
            Random rnd = new Random();

            ptrn.MainPattern(4, "Добавление к решению итоговых проектов по спринту", 7, 25, "Дана строка из одноразрядных цифр \"348561792486\". Преобразуйте ее в матрицу 4 на 3 и подсчитайте сумму четных чисел.");

            string value = "348561792486";
            int n = 4;
            int m = 3;

            ptrn.ResultPattern();

            Console.WriteLine(ds.Calculate(n, m, value));

            Console.ReadKey();
        }
    }
}
