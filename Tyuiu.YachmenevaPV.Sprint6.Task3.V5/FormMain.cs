using System.Windows.Forms;

using Tyuiu.YachmenevaPV.Sprint6.Task3.V5.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task3.V5
{
    public partial class FormMain_YPV : Form
    {
        public FormMain_YPV()
        {
            InitializeComponent();
        }

        private void buttonRes_YPV_Click(object sender, EventArgs e)
        {

            
            dataGridViewRes_YPV.Columns.Clear();
            dataGridViewRes_YPV.Rows.Clear();

            
            dataGridViewRes_YPV.ColumnHeadersVisible = false;
            dataGridViewRes_YPV.RowHeadersVisible = false;

            
            for (int i = 0; i < 5; i++)
            {
                dataGridViewRes_YPV.Columns.Add($"Col{i + 1}", $"Column {i + 1}");
            }

            
            dataGridViewRes_YPV.AllowUserToAddRows = false;

            
            foreach (DataGridViewColumn col in dataGridViewRes_YPV.Columns)
            {
                col.Width = 95;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Исходная матрица
            int[,] matrix =
            {
                { 30, -20,  7,  -8,  9 },
                { 32,  17, -14, -7, 33 },
                { 19, -19, -13, 14, -20 },
                { 11,  30, -1,  26,  6 },
                { 30, -15, -20, -5, 15 }
            };

            DataService ds = new DataService();

            
            int[,] result = ds.Calculate(matrix);

            
            for (int i = 0; i < result.GetLength(0); i++)
            {
                object[] row = new object[result.GetLength(1)];
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    row[j] = result[i, j];
                }
                dataGridViewRes_YPV.Rows.Add(row);
            }
        }
        private void buttonInfo_YPV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППб-25-1 Ячменёва Полина Викторовна");
        }
    }
}
