using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint4.Task5.V25.Lib;

namespace Tyuiu.IbrayevAA.Sprint4.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {  { 0, 2, -2, 1, 3 },

                                           { 0, 2, -2, 1, 3 },

                                           { 0, 2, -2, 1, 3 },

                                           { 0, 2, -2, 1, 3 },

                                           { 0, 2, -2, 1, 3 } };
            int res = ds.Calculate(mas2);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
