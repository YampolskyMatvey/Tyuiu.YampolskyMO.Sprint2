using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YampolskyMO.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {

            bool[] res = new bool[6];

            res[0] = (a + 131 == b) | (c > d);    // True | False  -> True
            res[1] = (a < b) & (c != d);          // True & False  -> False
            res[2] = (a > b) || (c < d);          // False || False -> False
            res[3] = (a <= b) && (c > d);         // True && False  -> False
            res[4] = !(c <= d);                   // !(True)        -> False
            res[5] = (a >= b) ^ (c != d);         // False ^ False  -> False

            return res;
        }
    }
}