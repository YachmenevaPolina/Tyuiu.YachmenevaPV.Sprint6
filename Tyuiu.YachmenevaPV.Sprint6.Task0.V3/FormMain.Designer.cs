namespace Tyuiu.YachmenevaPV.Sprint6.Task0.V3
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            button2 = new Button();
            DiscriptTextBox_YPV = new Label();
            pictureBox1 = new PictureBox();
            groupBoxX_YPV = new GroupBox();
            textBoxForX_YPV = new TextBox();
            BoxWithX_YPV = new Label();
            textRes_YPV = new TextBox();
            groupBoxRes_YPV = new GroupBox();
            resBox_YPV = new Label();
            DiscriptGroupBox_YPV = new GroupBox();
            ButtonInfo_YPV = new Button();
            ButtonDone_click_YPV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxX_YPV.SuspendLayout();
            groupBoxRes_YPV.SuspendLayout();
            DiscriptGroupBox_YPV.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(584, 0);
            button2.Name = "button2";
            button2.Size = new Size(102, 8);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // DiscriptTextBox_YPV
            // 
            DiscriptTextBox_YPV.AutoSize = true;
            DiscriptTextBox_YPV.Location = new Point(17, 62);
            DiscriptTextBox_YPV.Name = "DiscriptTextBox_YPV";
            DiscriptTextBox_YPV.Size = new Size(513, 41);
            DiscriptTextBox_YPV.TabIndex = 5;
            DiscriptTextBox_YPV.Text = "Вычислить выражение по формуле.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(720, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBoxX_YPV
            // 
            groupBoxX_YPV.Controls.Add(textBoxForX_YPV);
            groupBoxX_YPV.Controls.Add(BoxWithX_YPV);
            groupBoxX_YPV.Location = new Point(78, 513);
            groupBoxX_YPV.Name = "groupBoxX_YPV";
            groupBoxX_YPV.Size = new Size(421, 221);
            groupBoxX_YPV.TabIndex = 7;
            groupBoxX_YPV.TabStop = false;
            groupBoxX_YPV.Text = "Ввод данных";
            // 
            // textBoxForX_YPV
            // 
            textBoxForX_YPV.Location = new Point(17, 137);
            textBoxForX_YPV.Name = "textBoxForX_YPV";
            textBoxForX_YPV.Size = new Size(250, 47);
            textBoxForX_YPV.TabIndex = 1;
            // 
            // BoxWithX_YPV
            // 
            BoxWithX_YPV.AutoSize = true;
            BoxWithX_YPV.Location = new Point(17, 62);
            BoxWithX_YPV.Name = "BoxWithX_YPV";
            BoxWithX_YPV.Size = new Size(223, 41);
            BoxWithX_YPV.TabIndex = 0;
            BoxWithX_YPV.Text = "Переменная Х:";
            // 
            // textRes_YPV
            // 
            textRes_YPV.Location = new Point(39, 123);
            textRes_YPV.Multiline = true;
            textRes_YPV.Name = "textRes_YPV";
            textRes_YPV.ReadOnly = true;
            textRes_YPV.Size = new Size(309, 72);
            textRes_YPV.TabIndex = 8;
            textRes_YPV.TextChanged += textRes_YPV_TextChanged;
            // 
            // groupBoxRes_YPV
            // 
            groupBoxRes_YPV.Controls.Add(resBox_YPV);
            groupBoxRes_YPV.Controls.Add(textRes_YPV);
            groupBoxRes_YPV.Location = new Point(709, 513);
            groupBoxRes_YPV.Name = "groupBoxRes_YPV";
            groupBoxRes_YPV.Size = new Size(444, 221);
            groupBoxRes_YPV.TabIndex = 9;
            groupBoxRes_YPV.TabStop = false;
            groupBoxRes_YPV.Text = "Вывод данных:";
            // 
            // resBox_YPV
            // 
            resBox_YPV.AutoSize = true;
            resBox_YPV.Location = new Point(39, 62);
            resBox_YPV.Name = "resBox_YPV";
            resBox_YPV.Size = new Size(156, 41);
            resBox_YPV.TabIndex = 9;
            resBox_YPV.Text = "Результат:";
            // 
            // DiscriptGroupBox_YPV
            // 
            DiscriptGroupBox_YPV.Controls.Add(DiscriptTextBox_YPV);
            DiscriptGroupBox_YPV.Controls.Add(pictureBox1);
            DiscriptGroupBox_YPV.Location = new Point(78, 59);
            DiscriptGroupBox_YPV.Name = "DiscriptGroupBox_YPV";
            DiscriptGroupBox_YPV.Size = new Size(1075, 434);
            DiscriptGroupBox_YPV.TabIndex = 10;
            DiscriptGroupBox_YPV.TabStop = false;
            DiscriptGroupBox_YPV.Text = "Условие";
            // 
            // ButtonInfo_YPV
            // 
            ButtonInfo_YPV.FlatStyle = FlatStyle.Flat;
            ButtonInfo_YPV.Location = new Point(748, 765);
            ButtonInfo_YPV.Name = "ButtonInfo_YPV";
            ButtonInfo_YPV.Size = new Size(78, 62);
            ButtonInfo_YPV.TabIndex = 11;
            ButtonInfo_YPV.Text = "?";
            ButtonInfo_YPV.UseVisualStyleBackColor = true;
            ButtonInfo_YPV.Click += ButtonInfo_Click;
            // 
            // ButtonDone_click_YPV
            // 
            ButtonDone_click_YPV.FlatStyle = FlatStyle.Flat;
            ButtonDone_click_YPV.Location = new Point(919, 767);
            ButtonDone_click_YPV.Name = "ButtonDone_click_YPV";
            ButtonDone_click_YPV.Size = new Size(188, 58);
            ButtonDone_click_YPV.TabIndex = 12;
            ButtonDone_click_YPV.Text = "Выполнить";
            ButtonDone_click_YPV.UseVisualStyleBackColor = true;
            ButtonDone_click_YPV.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 852);
            Controls.Add(ButtonDone_click_YPV);
            Controls.Add(ButtonInfo_YPV);
            Controls.Add(DiscriptGroupBox_YPV);
            Controls.Add(groupBoxRes_YPV);
            Controls.Add(groupBoxX_YPV);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 3 | Ячменёва П.В.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxX_YPV.ResumeLayout(false);
            groupBoxX_YPV.PerformLayout();
            groupBoxRes_YPV.ResumeLayout(false);
            groupBoxRes_YPV.PerformLayout();
            DiscriptGroupBox_YPV.ResumeLayout(false);
            DiscriptGroupBox_YPV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Label DiscriptTextBox_YPV;
        private PictureBox pictureBox1;
        private GroupBox groupBoxX_YPV;
        private TextBox textRes_YPV;
        private TextBox textBoxForX_YPV;
        private Label BoxWithX_YPV;
        private GroupBox groupBoxRes_YPV;
        private Label resBox_YPV;
        private GroupBox DiscriptGroupBox_YPV;
        private Button ButtonInfo_YPV;
        private Button ButtonDone_click_YPV;
    }
}
