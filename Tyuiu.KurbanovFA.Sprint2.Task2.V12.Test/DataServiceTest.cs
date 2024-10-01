using Tyuiu.KurbanovFA.Sprint2.Task2.V12.Lib;
namespace Tyuiu.KurbanovFA.Sprint2.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 8;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}