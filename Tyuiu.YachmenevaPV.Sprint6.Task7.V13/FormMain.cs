using System.Windows.Forms;
using Tyuiu.YachmenevaPV.Sprint6.Task7.V13.Lib;
namespace Tyuiu.YachmenevaPV.Sprint6.Task7.V13
{
    public partial class FormMain_YPV : Form
    {
        public FormMain_YPV()
        {
            InitializeComponent();
            dataGridViewIn_YPV.RowHeadersVisible = false;
            dataGridViewOut_YPV.RowHeadersVisible = false;

            dataGridViewIn_YPV.AllowUserToAddRows = false;
            dataGridViewOut_YPV.AllowUserToAddRows = false;

            dataGridViewIn_YPV.ReadOnly = true;
            dataGridViewOut_YPV.ReadOnly = true;
            
        }

        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;
        public static int[,] LoadFromData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return result;
        }

        private void buttonFile_YPV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_YPV.ShowDialog();
            openFilePath = openFileDialogTask_YPV.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFilePath);
            dataGridViewIn_YPV.ColumnCount = columns;
            dataGridViewIn_YPV.RowCount = rows;
            dataGridViewOut_YPV.ColumnCount = columns;
            dataGridViewOut_YPV.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_YPV.Columns[i].Width = 100;
                dataGridViewOut_YPV.Columns[i].Width = 100;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewIn_YPV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_YPV.Enabled = true;
        }

        private void buttonDone_YPV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_YPV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_YPV.Enabled = true;
        }

        private void buttonInfo_YPV_Click(object sender, EventArgs e) 
        { 
            FormAbout_YPV form = new FormAbout_YPV(); 
            form.ShowDialog(); 
        }

        private void buttonSave_YPV_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_YPV.FileName = "OutPutFileTask7V13.csv";
            saveFileDialogTask_YPV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_YPV.ShowDialog();
            string path = saveFileDialogTask_YPV.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_YPV.RowCount;
            int col = dataGridViewOut_YPV.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != col - 1)
                    {
                        str += dataGridViewOut_YPV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_YPV.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }




    }
}
