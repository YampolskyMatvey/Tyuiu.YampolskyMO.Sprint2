using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YampolskyMO.Sprint2.Task6.V15.Lib;

namespace Tyuiu.YampolskyMO.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int k = 1;
            string wait = "понедельник";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }
    }
}