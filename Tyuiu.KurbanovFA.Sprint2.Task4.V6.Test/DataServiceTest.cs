using Tyuiu.KurbanovFA.Sprint2.Task4.V6.Lib;

namespace Tyuiu.KurbanovFA.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 0.007;

            Assert.AreEqual(wait, res);
        }
    }
}