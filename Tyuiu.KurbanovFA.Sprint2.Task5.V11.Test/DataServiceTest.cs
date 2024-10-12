using Tyuiu.KurbanovFA.Sprint2.Task5.V11.Lib;

namespace Tyuiu.KurbanovFA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int g = 2024; int m = 10; int n = 16;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "Среда";

            Assert.AreEqual(wait, res);
        }
    }
}