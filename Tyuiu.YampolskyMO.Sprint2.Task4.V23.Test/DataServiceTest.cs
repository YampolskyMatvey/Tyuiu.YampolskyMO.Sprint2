using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YampolskyMO.Sprint2.Task4.V23.Lib;

namespace Tyuiu.YampolskyMO.Sprint2.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 60.8;
            Assert.AreEqual(wait, res);
        }
    }
}