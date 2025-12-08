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

            
            int[] thirdCol = new int[rows];
            for (int i = 0; i < rows; i++)
                thirdCol[i] = result[i, 2];

            
            Array.Sort(thirdCol);

            
            for (int i = 0; i < rows; i++)
                result[i, 2] = thirdCol[i];

            return result;
        }
    }
}
