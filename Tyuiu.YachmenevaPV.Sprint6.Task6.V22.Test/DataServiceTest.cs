using Tyuiu.YachmenevaPV.Sprint6.Task6.V22.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask6V22.txt";
            string wait = "MLgyapd kEPQzl IOuDWll TMRyztkPxzEVkcarVMlQ unwTmf";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
