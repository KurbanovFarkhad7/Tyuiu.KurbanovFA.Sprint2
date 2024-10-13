using Tyuiu.KurbanovFA.Sprint2.Task6.V12.Lib;

namespace Tyuiu.KurbanovFA.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int g = 2024; int m = 9; int n = 8;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = "07.09.2024";

            Assert.AreEqual(wait, res);
        }
    }
}