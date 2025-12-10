using Tyuiu.YachmenevaPV.Sprint6.Task5.V27.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task5.V27
{
    public partial class FormMain_YPV : Form
    {
        public FormMain_YPV()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();


        // Файл входных данных (как в задании)
        string inputPath = @"C:\DataSprint6\InPutDataFileTask5V27.txt";

        // Файл выходных данных (чтобы открыть обработанные числа)
        string outputPath = @"C:\DataSprint6\OutPutDataFileTask5V27.txt";

        private void buttonDone_YPV_Click(object sender, EventArgs e)
        {
            try
            {
                // Чистим таблицу
                dataGridViewRes_YPV.Rows.Clear();
                dataGridViewRes_YPV.Columns.Clear();

                // Настройки грида
                dataGridViewRes_YPV.RowHeadersVisible = false; // убирает левый пустой столбец
                dataGridViewRes_YPV.ColumnHeadersVisible = false; // убирает заголовки "N" и "Значение"

                // Оставляем один единственный столбец без названия
                dataGridViewRes_YPV.ColumnCount = 1;
                dataGridViewRes_YPV.Columns[0].Width = 120;
                dataGridViewRes_YPV.Columns[0].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                // Настройка диаграммы
                chartRes_YPV.Series[0].Points.Clear();
                chartRes_YPV.ChartAreas[0].AxisX.Title = "Ось X";
                chartRes_YPV.ChartAreas[0].AxisY.Title = "Ось Y";

                // Загружаем обработанные числа
                double[] nums = ds.LoadFromDataFile(inputPath);

                // Выводим В ТАБЛИЦУ ТОЛЬКО ЗНАЧЕНИЕ (без индексов!)
                for (int i = 0; i < nums.Length; i++)
                {
                    dataGridViewRes_YPV.Rows.Add(nums[i].ToString());
                    chartRes_YPV.Series[0].Points.AddXY(i, nums[i]);
                }

                // Сохраняем обработанные числа в отдельный файл
                File.WriteAllLines(outputPath, nums.Select(x => x.ToString()));

                MessageBox.Show("Данные успешно обработаны!", "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка: неверные данные или файл не найден.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFile_YPV_Click(object sender, EventArgs e)
        {
            try
            {
                var proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "notepad.exe";
                proc.StartInfo.Arguments = outputPath; // Открываем готовые данные
                proc.Start();
            }
            catch
            {
                MessageBox.Show("Не удалось открыть файл.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_YPV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РППб-25-1 Ячменёва Полина Викторовна");
        }
    }
}
