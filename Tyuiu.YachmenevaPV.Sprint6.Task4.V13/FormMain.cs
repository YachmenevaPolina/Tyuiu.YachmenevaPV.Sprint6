using Tyuiu.YachmenevaPV.Sprint6.Task4.V13.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task4.V13
{
    public partial class FormMain_YPV : Form
    {
        public FormMain_YPV()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_YPV_CLick(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_YPV.Text);
                int stopValue = Convert.ToInt32(textBoxStop_YPV.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] TempArray = new double[len];

                TempArray = ds.GetMassFunction(startValue, stopValue);

                this.chartRes_YPV.ChartAreas[0].AxisX.Title = "ось X";
                this.chartRes_YPV.ChartAreas[0].AxisY.Title = "ось Y";

                textBoxRes_YPV.Text = "";

                chartRes_YPV.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartRes_YPV.Series[0].Points.AddXY(startValue, TempArray[i]);
                    textBoxRes_YPV.AppendText(TempArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_YPV_Click(object sender, EventArgs e)
        {
            try
            {
                string folder = @"C:\DataSprint6";
                string path = Path.Combine(folder, "OutPutDataFileTask4V13.txt");

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);   // ? создаёт папку автоматически!

                File.WriteAllText(path, textBoxRes_YPV.Text);

                DialogResult dr = MessageBox.Show("Файл " + path + " Сохранён успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void labelStart_YPV_Click(object sender, EventArgs e)
        {

        }



        private void buttonInfo_YPV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППб-25-1 Ячменёва Полина Викторовна");
        }
    }
}
