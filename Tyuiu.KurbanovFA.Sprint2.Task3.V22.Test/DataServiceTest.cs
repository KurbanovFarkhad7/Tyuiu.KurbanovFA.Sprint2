using Tyuiu.KurbanovFA.Sprint2.Task3.V22.Lib;

namespace Tyuiu.KurbanovFA.Sprint2.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 10;

            double res = ds.Calculate(x);
            double wait = 49.537;

            Assert.AreEqual(wait, res);
        }
    }
}