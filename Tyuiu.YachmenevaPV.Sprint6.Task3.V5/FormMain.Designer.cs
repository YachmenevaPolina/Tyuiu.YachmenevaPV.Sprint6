namespace Tyuiu.YachmenevaPV.Sprint6.Task3.V5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_YPV));
            groupBoxTask_YPV = new GroupBox();
            pictureBox1 = new PictureBox();
            labelTask_YPV = new Label();
            groupBoxRes_YPV = new GroupBox();
            buttonInfo_YPV = new Button();
            buttonRes_YPV = new Button();
            labelRes_YPV = new Label();
            dataGridViewRes_YPV = new DataGridView();
            groupBoxTask_YPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxRes_YPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_YPV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_YPV
            // 
            groupBoxTask_YPV.Controls.Add(pictureBox1);
            groupBoxTask_YPV.Controls.Add(labelTask_YPV);
            groupBoxTask_YPV.Location = new Point(35, 36);
            groupBoxTask_YPV.Name = "groupBoxTask_YPV";
            groupBoxTask_YPV.Size = new Size(768, 689);
            groupBoxTask_YPV.TabIndex = 0;
            groupBoxTask_YPV.TabStop = false;
            groupBoxTask_YPV.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 209);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 357);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTask_YPV
            // 
            labelTask_YPV.AutoSize = true;
            labelTask_YPV.Location = new Point(19, 57);
            labelTask_YPV.Name = "labelTask_YPV";
            labelTask_YPV.Size = new Size(709, 123);
            labelTask_YPV.TabIndex = 0;
            labelTask_YPV.Text = "Дан массив 5 на 5 элементов. \r\nВыполнить сортировку по возрастанию в третьем\r\nстолбце.";
            // 
            // groupBoxRes_YPV
            // 
            groupBoxRes_YPV.Controls.Add(buttonInfo_YPV);
            groupBoxRes_YPV.Controls.Add(buttonRes_YPV);
            groupBoxRes_YPV.Controls.Add(labelRes_YPV);
            groupBoxRes_YPV.Controls.Add(dataGridViewRes_YPV);
            groupBoxRes_YPV.Location = new Point(855, 36);
            groupBoxRes_YPV.Name = "groupBoxRes_YPV";
            groupBoxRes_YPV.Size = new Size(916, 689);
            groupBoxRes_YPV.TabIndex = 1;
            groupBoxRes_YPV.TabStop = false;
            groupBoxRes_YPV.Text = "Вывод данных:";
            // 
            // buttonInfo_YPV
            // 
            buttonInfo_YPV.BackColor = Color.FromArgb(192, 255, 192);
            buttonInfo_YPV.FlatStyle = FlatStyle.Popup;
            buttonInfo_YPV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonInfo_YPV.Location = new Point(379, 503);
            buttonInfo_YPV.Name = "buttonInfo_YPV";
            buttonInfo_YPV.Size = new Size(149, 85);
            buttonInfo_YPV.TabIndex = 3;
            buttonInfo_YPV.Text = "Справка";
            buttonInfo_YPV.UseVisualStyleBackColor = false;
            buttonInfo_YPV.Click += buttonInfo_YPV_Click;
            // 
            // buttonRes_YPV
            // 
            buttonRes_YPV.BackColor = Color.FromArgb(255, 128, 255);
            buttonRes_YPV.FlatStyle = FlatStyle.Popup;
            buttonRes_YPV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRes_YPV.ForeColor = Color.Black;
            buttonRes_YPV.Location = new Point(45, 482);
            buttonRes_YPV.Name = "buttonRes_YPV";
            buttonRes_YPV.Size = new Size(199, 126);
            buttonRes_YPV.TabIndex = 2;
            buttonRes_YPV.Text = "Выполнить";
            buttonRes_YPV.UseVisualStyleBackColor = false;
            buttonRes_YPV.Click += buttonRes_YPV_Click;
            // 
            // labelRes_YPV
            // 
            labelRes_YPV.AutoSize = true;
            labelRes_YPV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRes_YPV.Location = new Point(45, 57);
            labelRes_YPV.Name = "labelRes_YPV";
            labelRes_YPV.Size = new Size(166, 41);
            labelRes_YPV.TabIndex = 1;
            labelRes_YPV.Text = "Результат:";
            // 
            // dataGridViewRes_YPV
            // 
            dataGridViewRes_YPV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_YPV.Location = new Point(45, 121);
            dataGridViewRes_YPV.Name = "dataGridViewRes_YPV";
            dataGridViewRes_YPV.RowHeadersWidth = 102;
            dataGridViewRes_YPV.Size = new Size(483, 260);
            dataGridViewRes_YPV.TabIndex = 0;
            // 
            // FormMain_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 771);
            Controls.Add(groupBoxRes_YPV);
            Controls.Add(groupBoxTask_YPV);
            Name = "FormMain_YPV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 5 | Ячменёва П.В.";
            groupBoxTask_YPV.ResumeLayout(false);
            groupBoxTask_YPV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxRes_YPV.ResumeLayout(false);
            groupBoxRes_YPV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_YPV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_YPV;
        private PictureBox pictureBox1;
        private Label labelTask_YPV;
        private GroupBox groupBoxRes_YPV;
        private DataGridView dataGridViewRes_YPV;
        private Label labelRes_YPV;
        private Button buttonInfo_YPV;
        private Button buttonRes_YPV;
    }
}
