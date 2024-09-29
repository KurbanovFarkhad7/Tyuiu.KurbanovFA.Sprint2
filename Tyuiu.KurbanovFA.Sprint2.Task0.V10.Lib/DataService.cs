using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KurbanovFA.Sprint2.Task0.V10.Lib
{
    public class DataService : ISprint2Task0V10
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] valueArray = new bool[6];
            valueArray[0] = x == y;
            valueArray[1] = x != y;
            valueArray[2] = x < y;
            valueArray[3] = x > y;
            valueArray[4] = x <= y;
            valueArray[5] = x >= y;

            return valueArray;
        }
    }
}
