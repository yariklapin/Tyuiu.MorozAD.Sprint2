using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint2.Task6.V15.Lib;

namespace Tyuiu.MorozAD.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("Вторник", ds.FindDayName(1, 2));
            Assert.AreEqual("Среда", ds.FindDayName(1, 3));
            Assert.AreEqual("Четверг", ds.FindDayName(1, 4));
            Assert.AreEqual("Пятница", ds.FindDayName(1, 5));
            Assert.AreEqual("Суббота", ds.FindDayName(1, 6));
            Assert.AreEqual("Воскресение", ds.FindDayName(1, 7));
        }
    }
}
