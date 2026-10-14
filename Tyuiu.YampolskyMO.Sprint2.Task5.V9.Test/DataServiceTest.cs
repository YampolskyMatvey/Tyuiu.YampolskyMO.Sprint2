using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YampolskyMO.Sprint2.Task5.V9.Lib;

namespace Tyuiu.YampolskyMO.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int m = 5;
            int n = 15;
            string wait = "16.05.2024";
            string res = ds.FindDateOfNextDay(m, n);
            Assert.AreEqual(wait, res);
        }
    }
}