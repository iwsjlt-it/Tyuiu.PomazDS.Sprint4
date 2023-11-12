using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint4.Task7.V25.Lib;

namespace Tyuiu.PomazDS.Sprint4.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string value = "348561792486";
            int n = 4;
            int m = 3;

            int result = ds.Calculate(n,m,value); 
            Assert.AreEqual(38, result);
        }
    }
}
