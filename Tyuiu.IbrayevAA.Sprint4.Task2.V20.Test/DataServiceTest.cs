using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint4.Task2.V20.Lib;

namespace Tyuiu.IbrayevAA.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1 };
            int res = ds.Calculate(numsArray);
            int wait = 38;
            Assert.AreEqual(wait, res);
        }
    }
}
