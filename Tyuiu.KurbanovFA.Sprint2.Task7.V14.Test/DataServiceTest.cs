using Tyuiu.KurbanovFA.Sprint2.Task7.V14.Lib;

namespace Tyuiu.KurbanovFA.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.7; double y = 0.7;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}