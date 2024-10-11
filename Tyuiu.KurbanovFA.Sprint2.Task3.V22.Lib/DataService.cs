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
                y = Math.Pow(x + ((x + 3) / (x - 1)), x);
            }
            if (x == 0)
            {
                y = (Math.Pow(x, 2) - Math.Pow(Math.Cos(x), 2) + 10) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 10);
            }
            if (x > - 26 && x < 2)
            {
                y = Math.Pow(3 + 2 / Math.Pow(x, 2), x);
            }
            else
            {
                y = x + 10 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}
