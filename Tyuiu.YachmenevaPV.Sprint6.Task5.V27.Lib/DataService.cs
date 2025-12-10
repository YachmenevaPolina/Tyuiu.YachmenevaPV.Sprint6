using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.YachmenevaPV.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        
        public double[] LoadFromDataFile(string path)
        {
            List<double> result = new List<double>();

            using (StreamReader sr = new StreamReader(path))
            {
                string? line;

                while ((line = sr.ReadLine()) != null)
                {
                    // Обработка русской запятой
                    double num = Convert.ToDouble(line.Replace(',', '.'), CultureInfo.InvariantCulture);

                    // Отбор чисел, не кратных 5
                    if (num % 5 != 0)
                    {
                        result.Add(Math.Round(num, 3));
                    }
                }
            }

            return result.ToArray();

        }
    }
}
