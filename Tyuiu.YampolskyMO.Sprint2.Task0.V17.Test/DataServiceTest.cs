using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YampolskyMO.Sprint2.Task0.V17.Lib;

namespace Tyuiu.YampolskyMO.Sprint2.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            int x = 1065;
            int y = 755;

            bool[] wait = new bool[6] { true, false, false, false, false, false };
            bool[] res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}