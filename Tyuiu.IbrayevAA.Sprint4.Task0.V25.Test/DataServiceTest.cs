﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint4.Task0.V25.Lib;

namespace Tyuiu.IbrayevAA.Sprint4.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int wait = 42;
            Assert.AreEqual(wait, res);
        }
    } 
}
