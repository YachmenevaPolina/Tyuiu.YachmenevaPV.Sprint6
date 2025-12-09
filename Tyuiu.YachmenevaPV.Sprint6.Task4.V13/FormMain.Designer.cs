namespace Tyuiu.YachmenevaPV.Sprint6.Task4.V13
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_YPV = new GroupBox();
            labelTask_YPV = new Label();
            groupBoxSteps_YPV = new GroupBox();
            textBoxStop_YPV = new TextBox();
            textBoxStart_YPV = new TextBox();
            labelStop_YPV = new Label();
            labelStart_YPV = new Label();
            groupBoxRes_YPV = new GroupBox();
            textBoxRes_YPV = new TextBox();
            chartRes_YPV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_YPV = new Button();
            buttonSave_YPV = new Button();
            buttonInfo_YPV = new Button();
            groupBoxTask_YPV.SuspendLayout();
            groupBoxSteps_YPV.SuspendLayout();
            groupBoxRes_YPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_YPV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_YPV
            // 
            groupBoxTask_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_YPV.Controls.Add(labelTask_YPV);
            groupBoxTask_YPV.Location = new Point(30, 39);
            groupBoxTask_YPV.Name = "groupBoxTask_YPV";
            groupBoxTask_YPV.Size = new Size(1120, 195);
            groupBoxTask_YPV.TabIndex = 0;
            groupBoxTask_YPV.TabStop = false;
            groupBoxTask_YPV.Text = "Условие:";
            // 
            // labelTask_YPV
            // 
            labelTask_YPV.AutoSize = true;
            labelTask_YPV.Dock = DockStyle.Top;
            labelTask_YPV.Location = new Point(3, 43);
            labelTask_YPV.Name = "labelTask_YPV";
            labelTask_YPV.Size = new Size(1071, 123);
            labelTask_YPV.TabIndex = 0;
            labelTask_YPV.Text = "Произвести табулирование f(x) на заданном диапазоне  [-5; 5]\r\nРезультат вывести в textBox, построить график функции и сохранить в файл \r\nOutPutFileTask4V13.txt по нажатию кнопки.";
            // 
            // groupBoxSteps_YPV
            // 
            groupBoxSteps_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxSteps_YPV.Controls.Add(textBoxStop_YPV);
            groupBoxSteps_YPV.Controls.Add(textBoxStart_YPV);
            groupBoxSteps_YPV.Controls.Add(labelStop_YPV);
            groupBoxSteps_YPV.Controls.Add(labelStart_YPV);
            groupBoxSteps_YPV.Location = new Point(1174, 49);
            groupBoxSteps_YPV.Name = "groupBoxSteps_YPV";
            groupBoxSteps_YPV.Size = new Size(628, 185);
            groupBoxSteps_YPV.TabIndex = 1;
            groupBoxSteps_YPV.TabStop = false;
            groupBoxSteps_YPV.Text = "Ввод данных:";
            // 
            // textBoxStop_YPV
            // 
            textBoxStop_YPV.Location = new Point(305, 109);
            textBoxStop_YPV.Name = "textBoxStop_YPV";
            textBoxStop_YPV.Size = new Size(196, 47);
            textBoxStop_YPV.TabIndex = 3;
            // 
            // textBoxStart_YPV
            // 
            textBoxStart_YPV.Location = new Point(26, 109);
            textBoxStart_YPV.Name = "textBoxStart_YPV";
            textBoxStart_YPV.Size = new Size(196, 47);
            textBoxStart_YPV.TabIndex = 2;
            // 
            // labelStop_YPV
            // 
            labelStop_YPV.AutoSize = true;
            labelStop_YPV.Location = new Point(305, 57);
            labelStop_YPV.Name = "labelStop_YPV";
            labelStop_YPV.Size = new Size(184, 41);
            labelStop_YPV.TabIndex = 1;
            labelStop_YPV.Text = "Конец шага:";
            // 
            // labelStart_YPV
            // 
            labelStart_YPV.AutoSize = true;
            labelStart_YPV.Location = new Point(26, 57);
            labelStart_YPV.Name = "labelStart_YPV";
            labelStart_YPV.Size = new Size(174, 41);
            labelStart_YPV.TabIndex = 0;
            labelStart_YPV.Text = "Старт шага:";
            labelStart_YPV.Click += labelStart_YPV_Click;
            // 
            // groupBoxRes_YPV
            // 
            groupBoxRes_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxRes_YPV.Controls.Add(textBoxRes_YPV);
            groupBoxRes_YPV.Location = new Point(30, 240);
            groupBoxRes_YPV.Name = "groupBoxRes_YPV";
            groupBoxRes_YPV.Size = new Size(839, 1157);
            groupBoxRes_YPV.TabIndex = 2;
            groupBoxRes_YPV.TabStop = false;
            groupBoxRes_YPV.Text = "Вывод:";
            // 
            // textBoxRes_YPV
            // 
            textBoxRes_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxRes_YPV.Location = new Point(3, 43);
            textBoxRes_YPV.Multiline = true;
            textBoxRes_YPV.Name = "textBoxRes_YPV";
            textBoxRes_YPV.ReadOnly = true;
            textBoxRes_YPV.Size = new Size(833, 1111);
            textBoxRes_YPV.TabIndex = 0;
            // 
            // chartRes_YPV
            // 
            chartRes_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartRes_YPV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartRes_YPV.Legends.Add(legend1);
            chartRes_YPV.Location = new Point(889, 240);
            chartRes_YPV.Name = "chartRes_YPV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_YPV.Series.Add(series1);
            chartRes_YPV.Size = new Size(1678, 1059);
            chartRes_YPV.TabIndex = 3;
            chartRes_YPV.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title1.Name = "Title1";
            title1.Text = "График функции cos(x)";
            chartRes_YPV.Titles.Add(title1);
            // 
            // buttonDone_YPV
            // 
            buttonDone_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_YPV.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_YPV.FlatStyle = FlatStyle.Flat;
            buttonDone_YPV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_YPV.Location = new Point(1849, 82);
            buttonDone_YPV.Name = "buttonDone_YPV";
            buttonDone_YPV.Size = new Size(210, 136);
            buttonDone_YPV.TabIndex = 4;
            buttonDone_YPV.Text = "Выполнить";
            buttonDone_YPV.UseVisualStyleBackColor = false;
            buttonDone_YPV.Click += buttonDone_YPV_CLick;
            // 
            // buttonSave_YPV
            // 
            buttonSave_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_YPV.BackColor = Color.FromArgb(128, 255, 255);
            buttonSave_YPV.FlatStyle = FlatStyle.Flat;
            buttonSave_YPV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave_YPV.Location = new Point(2108, 82);
            buttonSave_YPV.Name = "buttonSave_YPV";
            buttonSave_YPV.Size = new Size(188, 136);
            buttonSave_YPV.TabIndex = 5;
            buttonSave_YPV.Text = "Сохранить";
            buttonSave_YPV.UseVisualStyleBackColor = false;
            buttonSave_YPV.Click += buttonSave_YPV_Click;
            // 
            // buttonInfo_YPV
            // 
            buttonInfo_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_YPV.BackColor = Color.FromArgb(255, 192, 255);
            buttonInfo_YPV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonInfo_YPV.Location = new Point(2366, 82);
            buttonInfo_YPV.Name = "buttonInfo_YPV";
            buttonInfo_YPV.Size = new Size(188, 136);
            buttonInfo_YPV.TabIndex = 6;
            buttonInfo_YPV.Text = "Справка";
            buttonInfo_YPV.UseVisualStyleBackColor = false;
            buttonInfo_YPV.Click += buttonInfo_YPV_Click;
            // 
            // FormMain_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2579, 1311);
            Controls.Add(buttonInfo_YPV);
            Controls.Add(buttonSave_YPV);
            Controls.Add(buttonDone_YPV);
            Controls.Add(chartRes_YPV);
            Controls.Add(groupBoxRes_YPV);
            Controls.Add(groupBoxSteps_YPV);
            Controls.Add(groupBoxTask_YPV);
            MinimumSize = new Size(2611, 1399);
            Name = "FormMain_YPV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 13 | Ячменёва П.В.";
            groupBoxTask_YPV.ResumeLayout(false);
            groupBoxTask_YPV.PerformLayout();
            groupBoxSteps_YPV.ResumeLayout(false);
            groupBoxSteps_YPV.PerformLayout();
            groupBoxRes_YPV.ResumeLayout(false);
            groupBoxRes_YPV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_YPV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_YPV;
        private Label labelTask_YPV;
        private GroupBox groupBoxSteps_YPV;
        private TextBox textBoxStop_YPV;
        private TextBox textBoxStart_YPV;
        private Label labelStop_YPV;
        private Label labelStart_YPV;
        private GroupBox groupBoxRes_YPV;
        private TextBox textBoxRes_YPV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_YPV;
        private Button buttonDone_YPV;
        private Button buttonSave_YPV;
        private Button buttonInfo_YPV;
    }
}
