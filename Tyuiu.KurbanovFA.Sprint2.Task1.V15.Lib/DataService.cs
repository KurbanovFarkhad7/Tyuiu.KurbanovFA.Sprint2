using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KurbanovFA.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            /*int a = 415; tffft
            int b = 616;
            int c = 134;
            int d = 127;*/

            bool[] valueArray = new bool[6];
            valueArray[0] = a == d | a > c;
            valueArray[1] = a != d & a < c;
            valueArray[2] = a > b || a < c;
            valueArray[3] = a >= b && a == c;
            valueArray[4] = a == d !;
            valueArray[5] = a > b ^ a != c;

            return valueArray;
        }
    }
}
