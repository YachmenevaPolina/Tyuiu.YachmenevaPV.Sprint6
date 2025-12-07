using Tyuiu.YachmenevaPV.Sprint6.Task2.V27.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task2.V27
{
    public partial class FormMain_YPV : Form
    {
        public FormMain_YPV()
        {
            InitializeComponent();
        }
     

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_YPV.Text);
                int stopStep = Convert.ToInt32(textBoxStop_YPV.Text);

                // получаем настоящий массив значений
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                this.DataGridView_YPV.Rows.Clear();
                this.chart_YPV.Series[0].Points.Clear();

                this.chart_YPV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart_YPV.ChartAreas[0].AxisY.Title = "Ось Y";

                int x = startStep;

                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.DataGridView_YPV.Rows.Add(x.ToString(), valueArray[i].ToString());
                    this.chart_YPV.Series[0].Points.AddXY(x, valueArray[i]);
                    x++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППб-25-1 Ячменёва Полина Викторовна");
        }
        private void buttonDone_MouseDown(object sender, EventArgs e)
        {
            buttonDone_YPV.BackColor = Color.Purple;
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_YPV.BackColor = Color.White;
        }
        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_YPV.BackColor = Color.Green; 

        }
    }
}
