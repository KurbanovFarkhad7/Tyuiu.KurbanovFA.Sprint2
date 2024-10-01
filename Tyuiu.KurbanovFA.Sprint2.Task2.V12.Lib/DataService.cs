using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KurbanovFA.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 13))
            {
                if ((x >= 6) && (x <= 8) && (y >= 3) && (y <= 4) || (x >= 3) && (x <= 5) && (y >= 8) && (y <= 10)
                    || (x >= 3) && (x <= 6) && (y >= 12) || (x >= 8) && (x <= 10) && (y >= 9) && (y <= 12)
                    || (x >= 13) && (y >= 3) && (y <= 5) || (x <= 13) && (y >= 9) && (y <= 12))
                {
                    res = false;
                }
                else
                {
                    res = true;
                }
            }
            else { res = false; }
            return res;
        }
    }
}
