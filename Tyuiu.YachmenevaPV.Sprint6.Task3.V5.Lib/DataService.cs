using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.YachmenevaPV.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = (int[,])matrix.Clone();

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (result[i, 2] > result[j, 2]) // сортируем по 3-му столбцу
                    {
                        // меняем строки местами
                        for (int k = 0; k < cols; k++)
                        {
                            int temp = result[i, k];
                            result[i, k] = result[j, k];
                            result[j, k] = temp;
                        }
                    }
                }
            }

            return result;
        }
    }
}
