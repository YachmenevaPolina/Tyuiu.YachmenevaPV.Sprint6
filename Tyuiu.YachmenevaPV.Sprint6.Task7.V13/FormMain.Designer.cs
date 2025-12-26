namespace Tyuiu.YachmenevaPV.Sprint6.Task7.V13
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
            groupBoxIn_YPV = new GroupBox();
            dataGridViewIn_YPV = new DataGridView();
            groupBoxOut_YPV = new GroupBox();
            dataGridViewOut_YPV = new DataGridView();
            buttonFile_YPV = new Button();
            buttonDone_YPV = new Button();
            buttonInfo_YPV = new Button();
            openFileDialogTask_YPV = new OpenFileDialog();
            toolTip_YPV = new ToolTip(components);
            buttonSave_YPV = new Button();
            saveFileDialogTask_YPV = new SaveFileDialog();
            groupBoxButtons_YPV = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBoxTask_YPV.SuspendLayout();
            groupBoxIn_YPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_YPV).BeginInit();
            groupBoxOut_YPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_YPV).BeginInit();
            groupBoxButtons_YPV.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_YPV
            // 
            groupBoxTask_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_YPV.Controls.Add(labelTask_YPV);
            groupBoxTask_YPV.Location = new Point(27, 204);
            groupBoxTask_YPV.Name = "groupBoxTask_YPV";
            groupBoxTask_YPV.Size = new Size(2776, 186);
            groupBoxTask_YPV.TabIndex = 0;
            groupBoxTask_YPV.TabStop = false;
            groupBoxTask_YPV.Text = "Условие:";
            // 
            // labelTask_YPV
            // 
            labelTask_YPV.AutoSize = true;
            labelTask_YPV.Location = new Point(24, 61);
            labelTask_YPV.Name = "labelTask_YPV";
            labelTask_YPV.Size = new Size(2570, 82);
            labelTask_YPV.TabIndex = 0;
            labelTask_YPV.Text = resources.GetString("labelTask_YPV.Text");
            // 
            // groupBoxIn_YPV
            // 
            groupBoxIn_YPV.Controls.Add(dataGridViewIn_YPV);
            groupBoxIn_YPV.Dock = DockStyle.Fill;
            groupBoxIn_YPV.Location = new Point(0, 0);
            groupBoxIn_YPV.Name = "groupBoxIn_YPV";
            groupBoxIn_YPV.Size = new Size(1222, 733);
            groupBoxIn_YPV.TabIndex = 1;
            groupBoxIn_YPV.TabStop = false;
            groupBoxIn_YPV.Text = "Ввод:";
            // 
            // dataGridViewIn_YPV
            // 
            dataGridViewIn_YPV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_YPV.Dock = DockStyle.Fill;
            dataGridViewIn_YPV.Location = new Point(3, 43);
            dataGridViewIn_YPV.Name = "dataGridViewIn_YPV";
            dataGridViewIn_YPV.ReadOnly = true;
            dataGridViewIn_YPV.RowHeadersWidth = 102;
            dataGridViewIn_YPV.Size = new Size(1216, 687);
            dataGridViewIn_YPV.TabIndex = 0;
            // 
            // groupBoxOut_YPV
            // 
            groupBoxOut_YPV.Controls.Add(dataGridViewOut_YPV);
            groupBoxOut_YPV.Dock = DockStyle.Fill;
            groupBoxOut_YPV.Location = new Point(0, 0);
            groupBoxOut_YPV.Name = "groupBoxOut_YPV";
            groupBoxOut_YPV.Size = new Size(1574, 736);
            groupBoxOut_YPV.TabIndex = 2;
            groupBoxOut_YPV.TabStop = false;
            groupBoxOut_YPV.Text = "Вывод:";
            // 
            // dataGridViewOut_YPV
            // 
            dataGridViewOut_YPV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_YPV.Dock = DockStyle.Fill;
            dataGridViewOut_YPV.Location = new Point(3, 43);
            dataGridViewOut_YPV.Name = "dataGridViewOut_YPV";
            dataGridViewOut_YPV.ReadOnly = true;
            dataGridViewOut_YPV.RowHeadersWidth = 102;
            dataGridViewOut_YPV.Size = new Size(1568, 690);
            dataGridViewOut_YPV.TabIndex = 0;
            // 
            // buttonFile_YPV
            // 
            buttonFile_YPV.FlatStyle = FlatStyle.Flat;
            buttonFile_YPV.Image = (Image)resources.GetObject("buttonFile_YPV.Image");
            buttonFile_YPV.Location = new Point(17, 30);
            buttonFile_YPV.Name = "buttonFile_YPV";
            buttonFile_YPV.Size = new Size(196, 150);
            buttonFile_YPV.TabIndex = 3;
            toolTip_YPV.SetToolTip(buttonFile_YPV, "Открыть файл\r\nВыберите нужный файл для обратботки\r\n");
            buttonFile_YPV.UseVisualStyleBackColor = true;
            buttonFile_YPV.Click += buttonFile_YPV_Click;
            // 
            // buttonDone_YPV
            // 
            buttonDone_YPV.Enabled = false;
            buttonDone_YPV.FlatStyle = FlatStyle.Flat;
            buttonDone_YPV.Image = (Image)resources.GetObject("buttonDone_YPV.Image");
            buttonDone_YPV.Location = new Point(249, 30);
            buttonDone_YPV.Name = "buttonDone_YPV";
            buttonDone_YPV.Size = new Size(188, 150);
            buttonDone_YPV.TabIndex = 4;
            toolTip_YPV.SetToolTip(buttonDone_YPV, "Обработать данные в файле");
            buttonDone_YPV.UseVisualStyleBackColor = true;
            buttonDone_YPV.Click += buttonDone_YPV_Click;
            // 
            // buttonInfo_YPV
            // 
            buttonInfo_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_YPV.FlatStyle = FlatStyle.Flat;
            buttonInfo_YPV.Image = (Image)resources.GetObject("buttonInfo_YPV.Image");
            buttonInfo_YPV.Location = new Point(2617, 30);
            buttonInfo_YPV.Name = "buttonInfo_YPV";
            buttonInfo_YPV.Size = new Size(188, 150);
            buttonInfo_YPV.TabIndex = 5;
            toolTip_YPV.SetToolTip(buttonInfo_YPV, "Сведения о пользователе");
            buttonInfo_YPV.UseVisualStyleBackColor = true;
            buttonInfo_YPV.Click += buttonInfo_YPV_Click;
            // 
            // toolTip_YPV
            // 
            toolTip_YPV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_YPV.ToolTipTitle = "Подсказка";
            // 
            // buttonSave_YPV
            // 
            buttonSave_YPV.FlatStyle = FlatStyle.Flat;
            buttonSave_YPV.Image = (Image)resources.GetObject("buttonSave_YPV.Image");
            buttonSave_YPV.Location = new Point(480, 30);
            buttonSave_YPV.Name = "buttonSave_YPV";
            buttonSave_YPV.Size = new Size(188, 150);
            buttonSave_YPV.TabIndex = 6;
            toolTip_YPV.SetToolTip(buttonSave_YPV, "Сохранение результата в файл");
            buttonSave_YPV.UseVisualStyleBackColor = true;
            buttonSave_YPV.Click += buttonSave_YPV_Click;
            // 
            // groupBoxButtons_YPV
            // 
            groupBoxButtons_YPV.Controls.Add(buttonInfo_YPV);
            groupBoxButtons_YPV.Controls.Add(buttonSave_YPV);
            groupBoxButtons_YPV.Controls.Add(buttonFile_YPV);
            groupBoxButtons_YPV.Controls.Add(buttonDone_YPV);
            groupBoxButtons_YPV.Dock = DockStyle.Top;
            groupBoxButtons_YPV.Location = new Point(0, 0);
            groupBoxButtons_YPV.Name = "groupBoxButtons_YPV";
            groupBoxButtons_YPV.Size = new Size(2831, 186);
            groupBoxButtons_YPV.TabIndex = 3;
            groupBoxButtons_YPV.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(groupBoxOut_YPV);
            panel1.Location = new Point(1245, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(1574, 736);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(groupBoxIn_YPV);
            panel2.Location = new Point(17, 418);
            panel2.Name = "panel2";
            panel2.Size = new Size(1222, 733);
            panel2.TabIndex = 5;
            // 
            // FormMain_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2831, 1166);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBoxButtons_YPV);
            Controls.Add(groupBoxTask_YPV);
            Name = "FormMain_YPV";
            Text = "Спринт 6 | Таск 7 | Вариант 13 | Ячменёва П.В.";
            groupBoxTask_YPV.ResumeLayout(false);
            groupBoxTask_YPV.PerformLayout();
            groupBoxIn_YPV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_YPV).EndInit();
            groupBoxOut_YPV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_YPV).EndInit();
            groupBoxButtons_YPV.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_YPV;
        private Label labelTask_YPV;
        private GroupBox groupBoxIn_YPV;
        private DataGridView dataGridViewIn_YPV;
        private GroupBox groupBoxOut_YPV;
        private DataGridView dataGridViewOut_YPV;
        private Button buttonFile_YPV;
        private Button buttonDone_YPV;
        private Button buttonInfo_YPV;
        private OpenFileDialog openFileDialogTask_YPV;
        private ToolTip toolTip_YPV;
        private SaveFileDialog saveFileDialogTask_YPV;
        private Button buttonSave_YPV;
        private GroupBox groupBoxButtons_YPV;
        private Panel panel1;
        private Panel panel2;
    }
}
