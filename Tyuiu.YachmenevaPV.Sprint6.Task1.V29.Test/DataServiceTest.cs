using Tyuiu.YachmenevaPV.Sprint6.Task1.V29.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;

            int len = end - start + 1;

            double[] value;
            value = new double[len];

            value[0] = -15.44;
            value[1] = -10.93;
            value[2] = -7.22;
            value[3] = -5.04;
            value[4] = 0;
            value[5] = -0.30;
            value[6] = 2.57;
            value[7] = 6.40;
            value[8] = 10.04;
            value[9] = 12.72;
            value[10] = 14.68;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(res, value);
        }
    }
}
