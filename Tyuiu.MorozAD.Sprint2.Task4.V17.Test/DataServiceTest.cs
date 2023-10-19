using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint2.Task4.V17.Lib;

namespace Tyuiu.MorozAD.Sprint2.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 26;
            double y = 9;
            double res = ds.Calculate(x, y);
            double wait = 10122507.817;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 23;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 4.023;
            Assert.AreEqual(wait, res);

        }
    }
}
