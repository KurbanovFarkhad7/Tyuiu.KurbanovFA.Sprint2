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
            double x = 3;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 1.889;

            Assert.AreEqual(wait, res);
        }
    }
}