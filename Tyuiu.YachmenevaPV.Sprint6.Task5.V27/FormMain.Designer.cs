namespace Tyuiu.YachmenevaPV.Sprint6.Task5.V27
{
    partial class FormMain_YPV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_YPV = new GroupBox();
            labelTask_YPV = new Label();
            groupBoxRes_YPV = new GroupBox();
            dataGridViewRes_YPV = new DataGridView();
            chartRes_YPV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_YPV = new Button();
            buttonFile_YPV = new Button();
            buttonInfo_YPV = new Button();
            groupBoxTask_YPV.SuspendLayout();
            groupBoxRes_YPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_YPV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRes_YPV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_YPV
            // 
            groupBoxTask_YPV.Controls.Add(labelTask_YPV);
            groupBoxTask_YPV.Location = new Point(34, 36);
            groupBoxTask_YPV.Name = "groupBoxTask_YPV";
            groupBoxTask_YPV.Size = new Size(1176, 160);
            groupBoxTask_YPV.TabIndex = 0;
            groupBoxTask_YPV.TabStop = false;
            groupBoxTask_YPV.Text = "Условие:";
            // 
            // labelTask_YPV
            // 
            labelTask_YPV.AutoSize = true;
            labelTask_YPV.Location = new Point(15, 43);
            labelTask_YPV.Name = "labelTask_YPV";
            labelTask_YPV.Size = new Size(1054, 82);
            labelTask_YPV.TabIndex = 0;
            labelTask_YPV.Text = "Прочитать данные из файла InPutFileTask5V27.txt. Вывести в dataGridView. \r\nВывести все числа не кратные 5. Построить диаграмму по этим значениям.";
            // 
            // groupBoxRes_YPV
            // 
            groupBoxRes_YPV.Controls.Add(dataGridViewRes_YPV);
            groupBoxRes_YPV.Location = new Point(34, 216);
            groupBoxRes_YPV.Name = "groupBoxRes_YPV";
            groupBoxRes_YPV.Size = new Size(500, 972);
            groupBoxRes_YPV.TabIndex = 1;
            groupBoxRes_YPV.TabStop = false;
            groupBoxRes_YPV.Text = "Вывод данных:";
            // 
            // dataGridViewRes_YPV
            // 
            dataGridViewRes_YPV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_YPV.Location = new Point(15, 65);
            dataGridViewRes_YPV.Name = "dataGridViewRes_YPV";
            dataGridViewRes_YPV.ReadOnly = true;
            dataGridViewRes_YPV.RowHeadersWidth = 102;
            dataGridViewRes_YPV.Size = new Size(463, 889);
            dataGridViewRes_YPV.TabIndex = 0;
            // 
            // chartRes_YPV
            // 
            chartArea1.Name = "ChartArea1";
            chartRes_YPV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartRes_YPV.Legends.Add(legend1);
            chartRes_YPV.Location = new Point(552, 216);
            chartRes_YPV.Name = "chartRes_YPV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_YPV.Series.Add(series1);
            chartRes_YPV.Size = new Size(1398, 966);
            chartRes_YPV.TabIndex = 2;
            chartRes_YPV.Text = "chart1";
            // 
            // buttonDone_YPV
            // 
            buttonDone_YPV.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_YPV.FlatStyle = FlatStyle.Flat;
            buttonDone_YPV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_YPV.Location = new Point(1238, 36);
            buttonDone_YPV.Name = "buttonDone_YPV";
            buttonDone_YPV.Size = new Size(200, 160);
            buttonDone_YPV.TabIndex = 3;
            buttonDone_YPV.Text = "Выполнить";
            buttonDone_YPV.UseVisualStyleBackColor = false;
            buttonDone_YPV.Click += buttonDone_YPV_Click;
            // 
            // buttonFile_YPV
            // 
            buttonFile_YPV.BackColor = Color.FromArgb(192, 255, 255);
            buttonFile_YPV.FlatStyle = FlatStyle.Flat;
            buttonFile_YPV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFile_YPV.Location = new Point(1487, 36);
            buttonFile_YPV.Name = "buttonFile_YPV";
            buttonFile_YPV.Size = new Size(188, 160);
            buttonFile_YPV.TabIndex = 4;
            buttonFile_YPV.Text = "Открыть файл";
            buttonFile_YPV.UseVisualStyleBackColor = false;
            buttonFile_YPV.Click += buttonFile_YPV_Click;
            // 
            // buttonInfo_YPV
            // 
            buttonInfo_YPV.BackColor = Color.FromArgb(255, 192, 255);
            buttonInfo_YPV.FlatStyle = FlatStyle.Flat;
            buttonInfo_YPV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonInfo_YPV.Location = new Point(1728, 36);
            buttonInfo_YPV.Name = "buttonInfo_YPV";
            buttonInfo_YPV.Size = new Size(188, 160);
            buttonInfo_YPV.TabIndex = 5;
            buttonInfo_YPV.Text = "Справка";
            buttonInfo_YPV.UseVisualStyleBackColor = false;
            buttonInfo_YPV.Click += buttonInfo_YPV_Click;
            // 
            // FormMain_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1962, 1200);
            Controls.Add(buttonInfo_YPV);
            Controls.Add(buttonFile_YPV);
            Controls.Add(buttonDone_YPV);
            Controls.Add(chartRes_YPV);
            Controls.Add(groupBoxRes_YPV);
            Controls.Add(groupBoxTask_YPV);
            Name = "FormMain_YPV";
            Text = "Спринт 6 | Таск 5 | Вариант 27 | Ячменёва П.В.";
            groupBoxTask_YPV.ResumeLayout(false);
            groupBoxTask_YPV.PerformLayout();
            groupBoxRes_YPV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_YPV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRes_YPV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_YPV;
        private Label labelTask_YPV;
        private GroupBox groupBoxRes_YPV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_YPV;
        private Button buttonDone_YPV;
        private Button buttonFile_YPV;
        private Button buttonInfo_YPV;
        private DataGridView dataGridViewRes_YPV;
    }
}
