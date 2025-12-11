namespace Tyuiu.YachmenevaPV.Sprint6.Task7.V13
{
    partial class FormAbout_YPV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_YPV));
            labelInfo_YPV = new Label();
            buttonOK_YPV = new Button();
            SuspendLayout();
            // 
            // labelInfo_YPV
            // 
            labelInfo_YPV.AutoSize = true;
            labelInfo_YPV.Location = new Point(21, 38);
            labelInfo_YPV.Name = "labelInfo_YPV";
            labelInfo_YPV.Size = new Size(770, 451);
            labelInfo_YPV.TabIndex = 0;
            labelInfo_YPV.Text = resources.GetString("labelInfo_YPV.Text");
            // 
            // buttonOK_YPV
            // 
            buttonOK_YPV.FlatStyle = FlatStyle.Flat;
            buttonOK_YPV.Location = new Point(977, 452);
            buttonOK_YPV.Name = "buttonOK_YPV";
            buttonOK_YPV.Size = new Size(188, 58);
            buttonOK_YPV.TabIndex = 1;
            buttonOK_YPV.Text = "OK";
            buttonOK_YPV.UseVisualStyleBackColor = true;
            buttonOK_YPV.Click += buttonOK_Click;
            // 
            // FormAbout_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 561);
            Controls.Add(buttonOK_YPV);
            Controls.Add(labelInfo_YPV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAbout_YPV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_YPV;
        private Button buttonOK_YPV;
    }
}