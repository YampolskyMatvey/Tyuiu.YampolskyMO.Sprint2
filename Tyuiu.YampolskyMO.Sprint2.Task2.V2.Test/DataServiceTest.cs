using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YampolskyMO.Sprint2.Task2.V2.Lib;

namespace Tyuiu.YampolskyMO.Sprint2.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 6;
            int y = 6;

            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}