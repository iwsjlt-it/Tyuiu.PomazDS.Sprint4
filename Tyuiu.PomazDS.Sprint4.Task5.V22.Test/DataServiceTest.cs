using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint4.Task5.V22.Lib;

namespace Tyuiu.PomazDS.Sprint4.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = { { -8, 2 }, { -3, 9 } };

            int result = ds.Calculate(array);

            Assert.AreEqual(2, result);
        }
    }
}
