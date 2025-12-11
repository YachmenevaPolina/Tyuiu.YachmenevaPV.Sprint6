using Tyuiu.YachmenevaPV.Sprint6.Task6.V22.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task6.V22
{
    public partial class FormMain_YPV : Form
    {
        public FormMain_YPV()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_YPV_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxRes_YPV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_YPV_Click(object seder, EventArgs e)
        {
            FormAbout_YPV formAbout = new FormAbout_YPV();
            formAbout.ShowDialog();
        }

        private void buttonFile_YPV_Click(object seder, EventArgs e)
        {
            openFileDialog_YPV.ShowDialog();
            openFilePath = openFileDialog_YPV.FileName;
            textBoxTask_YPV.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_YPV.Text = groupBoxOutput_YPV.Text + " " + openFileDialog_YPV.FileName;
            buttonDone_YPV.Enabled = true;
        }

       

        
    }
}
