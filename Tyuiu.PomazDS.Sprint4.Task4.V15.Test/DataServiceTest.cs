using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint4.Task4.V15.Lib;

namespace Tyuiu.PomazDS.Sprint4.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = { { 1, 2 }, { 3, 4 } };

            int result = ds.Calculate(array);

            Assert.AreEqual(4, result);


        }
    }
}
