using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KurbanovFA.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string date = "Привет, Мир";
            switch (g, m, n )
            {
                case (2024, 10, 14):
                    date = "Понедельник";
                    break;
                case (2024, 10, 15):
                    date = "Вторник";
                    break;
                case (2024, 10, 16):
                    date = "Среда";
                    break;
                case (2024, 10, 17):
                    date = "Четверг";
                    break;
                case (2024, 10, 18):
                    date = "Пятница";
                    break;
                case (2024, 10, 19):
                    date = "Суббота";
                    break;
                case (2024, 10, 20):
                    date = "Воскресенье";
                    break;
                    default: return date;
            }
            return date;
        }
    }
}
