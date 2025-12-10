using Tyuiu.YachmenevaPV.Sprint6.Task5.V27.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string filePath = "InPutDataFileTask5V27.txt";

            File.WriteAllText(filePath,
                "-17\n0\n12\n-14,32\n5\n-7,84\n12,89\n-1,57\n-3,64\n-13,26\n-8,91\n-17,77\n35\n-9\n13,83\n12,76\n8,86\n0\n-1,49\n-7");

            double[] expected =
            {
                -17, 12, -14.32, -7.84, 12.89, -1.57,
                -3.64, -13.26, -8.91, -17.77, -9,
                13.83, 12.76, 8.86, -1.49, -7
            };

            

            double[] result = ds.LoadFromDataFile(filePath);

            CollectionAssert.AreEqual(expected, result);
        }
    }
    
}
