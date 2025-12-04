using Tyuiu.YachmenevaPV.Sprint6.Task0.V3.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textRes_YPV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxForX_YPV.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxForX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППб-25-1 Ячменёва Полина Викторовна");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textRes_YPV_TextChanged(object sender, EventArgs e)
        {
            
        }



    }
}
