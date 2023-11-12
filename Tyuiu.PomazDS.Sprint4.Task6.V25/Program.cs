using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint4.Task6.V25.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint4.Task6.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();
            Random rnd = new Random();

            ptrn.MainPattern(4, "Двумерные массивы. (генератор случайных чисел)", 6, 25, "Дан строковый массив данных [\"Теннис\", \"Футбол\", \"Крикет\", \"Баскетбол\", \"Бейсбол\", \"Регби\", \"Хоккей\"] используя класс Array подсчитайте количество элементов, длина которых больше 6.");

            string[] array = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };

            ptrn.ResultPattern();

            Console.WriteLine(ds.Calculate(array));

            Console.ReadKey();
        }
    }
}
