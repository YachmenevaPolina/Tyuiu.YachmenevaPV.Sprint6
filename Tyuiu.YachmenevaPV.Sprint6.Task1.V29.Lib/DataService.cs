using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.YachmenevaPV.Sprint6.Task1.V29.Lib
{
    public class DataService : ISprint6Task1V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] value = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1 == 0)
                {
                    value[count] = 0;
                }
                else
                {
                    double y = (Math.Cos(x) / (x + 1)) - Math.Cos(x) * 1.3 + 3 * x;
                    value[count] = Math.Round(y, 2);
                }

                count++;
            }

            return value;
        }
    }
}
