using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KurbanovFA.Sprint2.Task3.V22.Lib
{
    public class DataService : ISprint2Task3V22
    {
        public double Calculate(double x)
        {
            double y; 
            if (x > 1)
            {
                y = x + Math.Pow((x + 3) / (x - 1), x);
                return Math.Round(y, 3);
            }
            if (x == 0)
            {
                y = (Math.Pow(x, 2) - Math.Pow(Math.Cos(x), 2) + 10) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 10);
                return Math.Round(y, 3);
            }
            if (x > - 26 && x < 2)
            {
                y = Math.Pow(3 + 2 / Math.Pow(x, 2), x);
                return Math.Round(y, 3);
            }
            if (x < -26)
            {
                y = x + 10 * x - (1 / x);
                return Math.Round(y, 3);
            }
            else { return Math.Round(y = x, 3); }
            
        }
    }
}
