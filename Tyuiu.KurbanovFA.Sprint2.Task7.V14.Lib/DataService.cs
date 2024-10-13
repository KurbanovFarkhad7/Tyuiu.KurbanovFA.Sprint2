using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KurbanovFA.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (y + x <= 1 || Math.Pow(x,2) + Math.Pow(y,2) - 1 <= 2.5 || y - x <= 4)
            {
                res = true;
            }
            else {res = false;}
            return res;
        }
    }
}
