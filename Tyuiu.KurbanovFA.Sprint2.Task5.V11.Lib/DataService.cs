using Microsoft.VisualBasic;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KurbanovFA.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string date = "";
            switch (g % 400 == 0 || g % 4 != 0 && g % 100 != 0)
            {
                case (true):
                    n += 1;
                    if (m < 10 || n < 10)
                    {
                        date = "0" + n + ".0" + m + "." + g;
                    }
                    else
                    {
                        date = n + "." + m + "." + g;
                    }
                    break;
                case (false):
                    if (m < 10 || n < 10)
                    {
                        date = "0" + n + ".0" + m + "." + g;
                    }
                    else
                    {
                        date = n + "." + m + "." + g;
                    }
                    break;
            }
            return date;
        }
    }
}
