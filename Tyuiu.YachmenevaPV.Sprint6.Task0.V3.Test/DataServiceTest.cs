using Tyuiu.YachmenevaPV.Sprint6.Task0.V3.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 4.154;
            Assert.AreEqual(wait, res);
        }
    }
}
