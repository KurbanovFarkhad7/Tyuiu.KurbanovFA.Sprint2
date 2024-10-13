using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KurbanovFA.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string date = "";
            switch (g % 400 == 0 || g % 4 != 0 && g % 100 != 0)
            {
                case (true):
                    
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
                    n -= 1;
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
