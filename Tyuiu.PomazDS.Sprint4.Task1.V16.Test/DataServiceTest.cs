using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint4.Task1.V16.Lib;

namespace Tyuiu.PomazDS.Sprint4.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            Assert.AreEqual(ds.Calculate(array), 297675);
        }
    }
}
