using Tyuiu.YachmenevaPV.Sprint6.Task1.V29.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task1.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_YPV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_YPV.Text);
                int stopStep = Convert.ToInt32(textBoxStop_YPV.Text);

                string strLine;
                int len = (ds.GetMassFunction(startStep, stopStep)).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxRes_YPV.Text = "";
                textBoxRes_YPV.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxRes_YPV.AppendText("+    X    |   F(x)  +" + Environment.NewLine);
                textBoxRes_YPV.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i < valueArray.Length ; i++)
                {
                    strLine = String.Format("|{0,5:d}    |  {1,5:f2}   |", startStep, valueArray[i]);
                    textBoxRes_YPV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRes_YPV.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППб-25-1 Ячменёва Полина Викторовна");
        }

    }
}
