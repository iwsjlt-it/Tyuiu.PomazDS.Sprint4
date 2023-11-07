using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint4.Task0.V24.Lib;

namespace Tyuiu.PomazDS.Sprint4.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int result = 32;

            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            Assert.AreEqual(result, ds.GetMultEvenArrEl(array));
        }

    }
}

