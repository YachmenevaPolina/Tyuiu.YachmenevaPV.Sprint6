namespace Tyuiu.YachmenevaPV.Sprint6.Task6.V22
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_YPV));
            groupBoxTask_YPV = new GroupBox();
            labelTask_YPV = new Label();
            groupBoxInput_YPV = new GroupBox();
            textBoxTask_YPV = new TextBox();
            groupBoxOutput_YPV = new GroupBox();
            textBoxRes_YPV = new TextBox();
            buttonFile_YPV = new Button();
            buttonDone_YPV = new Button();
            buttonInfo_YPV = new Button();
            openFileDialog_YPV = new OpenFileDialog();
            toolTip_YPV = new ToolTip(components);
            groupBoxTask_YPV.SuspendLayout();
            groupBoxInput_YPV.SuspendLayout();
            groupBoxOutput_YPV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_YPV
            // 
            groupBoxTask_YPV.Controls.Add(labelTask_YPV);
            groupBoxTask_YPV.Location = new Point(12, 150);
            groupBoxTask_YPV.Name = "groupBoxTask_YPV";
            groupBoxTask_YPV.Size = new Size(2245, 203);
            groupBoxTask_YPV.TabIndex = 0;
            groupBoxTask_YPV.TabStop = false;
            groupBoxTask_YPV.Text = "Условие:";
            // 
            // labelTask_YPV
            // 
            labelTask_YPV.AutoSize = true;
            labelTask_YPV.Location = new Point(23, 61);
            labelTask_YPV.Name = "labelTask_YPV";
            labelTask_YPV.Size = new Size(1836, 82);
            labelTask_YPV.TabIndex = 0;
            labelTask_YPV.Text = resources.GetString("labelTask_YPV.Text");
            // 
            // groupBoxInput_YPV
            // 
            groupBoxInput_YPV.Controls.Add(textBoxTask_YPV);
            groupBoxInput_YPV.Location = new Point(19, 371);
            groupBoxInput_YPV.Name = "groupBoxInput_YPV";
            groupBoxInput_YPV.Size = new Size(1115, 826);
            groupBoxInput_YPV.TabIndex = 1;
            groupBoxInput_YPV.TabStop = false;
            groupBoxInput_YPV.Text = "Ввод:";
            // 
            // textBoxTask_YPV
            // 
            textBoxTask_YPV.Location = new Point(16, 58);
            textBoxTask_YPV.Multiline = true;
            textBoxTask_YPV.Name = "textBoxTask_YPV";
            textBoxTask_YPV.ReadOnly = true;
            textBoxTask_YPV.Size = new Size(1071, 762);
            textBoxTask_YPV.TabIndex = 0;
            // 
            // groupBoxOutput_YPV
            // 
            groupBoxOutput_YPV.Controls.Add(textBoxRes_YPV);
            groupBoxOutput_YPV.Location = new Point(1161, 371);
            groupBoxOutput_YPV.Name = "groupBoxOutput_YPV";
            groupBoxOutput_YPV.Size = new Size(1096, 826);
            groupBoxOutput_YPV.TabIndex = 2;
            groupBoxOutput_YPV.TabStop = false;
            groupBoxOutput_YPV.Text = "Вывод:";
            // 
            // textBoxRes_YPV
            // 
            textBoxRes_YPV.Location = new Point(18, 58);
            textBoxRes_YPV.Multiline = true;
            textBoxRes_YPV.Name = "textBoxRes_YPV";
            textBoxRes_YPV.ReadOnly = true;
            textBoxRes_YPV.Size = new Size(1056, 762);
            textBoxRes_YPV.TabIndex = 0;
            // 
            // buttonFile_YPV
            // 
            buttonFile_YPV.BackColor = SystemColors.ButtonFace;
            buttonFile_YPV.Image = (Image)resources.GetObject("buttonFile_YPV.Image");
            buttonFile_YPV.Location = new Point(19, 23);
            buttonFile_YPV.Name = "buttonFile_YPV";
            buttonFile_YPV.Size = new Size(198, 121);
            buttonFile_YPV.TabIndex = 3;
            toolTip_YPV.SetToolTip(buttonFile_YPV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonFile_YPV.UseVisualStyleBackColor = false;
            buttonFile_YPV.Click += buttonFile_YPV_Click;
            // 
            // buttonDone_YPV
            // 
            buttonDone_YPV.BackColor = SystemColors.ButtonFace;
            buttonDone_YPV.Image = (Image)resources.GetObject("buttonDone_YPV.Image");
            buttonDone_YPV.Location = new Point(272, 23);
            buttonDone_YPV.Name = "buttonDone_YPV";
            buttonDone_YPV.Size = new Size(188, 121);
            buttonDone_YPV.TabIndex = 4;
            toolTip_YPV.SetToolTip(buttonDone_YPV, "Производит работу над файлом");
            buttonDone_YPV.UseVisualStyleBackColor = false;
            buttonDone_YPV.Click += buttonDone_YPV_Click;
            // 
            // buttonInfo_YPV
            // 
            buttonInfo_YPV.BackColor = SystemColors.ButtonFace;
            buttonInfo_YPV.Image = (Image)resources.GetObject("buttonInfo_YPV.Image");
            buttonInfo_YPV.Location = new Point(2047, 23);
            buttonInfo_YPV.Name = "buttonInfo_YPV";
            buttonInfo_YPV.Size = new Size(188, 121);
            buttonInfo_YPV.TabIndex = 5;
            toolTip_YPV.SetToolTip(buttonInfo_YPV, "Сведение о пользователе");
            buttonInfo_YPV.UseVisualStyleBackColor = false;
            buttonInfo_YPV.Click += buttonInfo_YPV_Click;
            // 
            // openFileDialog_YPV
            // 
            openFileDialog_YPV.FileName = "openFileDialog1";
            // 
            // toolTip_YPV
            // 
            toolTip_YPV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_YPV.ToolTipTitle = "Подсказка";
            // 
            // FormMain_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2276, 1209);
            Controls.Add(buttonInfo_YPV);
            Controls.Add(buttonDone_YPV);
            Controls.Add(buttonFile_YPV);
            Controls.Add(groupBoxOutput_YPV);
            Controls.Add(groupBoxInput_YPV);
            Controls.Add(groupBoxTask_YPV);
            Name = "FormMain_YPV";
            Text = "Спринт 6 | Таск 6 | Вариант 22 | Ячменёва П.В.";
            groupBoxTask_YPV.ResumeLayout(false);
            groupBoxTask_YPV.PerformLayout();
            groupBoxInput_YPV.ResumeLayout(false);
            groupBoxInput_YPV.PerformLayout();
            groupBoxOutput_YPV.ResumeLayout(false);
            groupBoxOutput_YPV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_YPV;
        private Label labelTask_YPV;
        private GroupBox groupBoxInput_YPV;
        private GroupBox groupBoxOutput_YPV;
        private TextBox textBoxTask_YPV;
        private TextBox textBoxRes_YPV;
        private Button buttonFile_YPV;
        private Button buttonDone_YPV;
        private Button buttonInfo_YPV;
        private ToolTip toolTip_YPV;
        private OpenFileDialog openFileDialog_YPV;
    }
}
