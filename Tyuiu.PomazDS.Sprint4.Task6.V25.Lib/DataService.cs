using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PomazDS.Sprint4.Task6.V25.Lib
{
    public class DataService : ISprint4Task6V25
    {
        public int Calculate(string[] array)
        {
            string[] str = Array.FindAll(array, x => x.Length>6);
            
            return str.Length;
        }
    }
}
