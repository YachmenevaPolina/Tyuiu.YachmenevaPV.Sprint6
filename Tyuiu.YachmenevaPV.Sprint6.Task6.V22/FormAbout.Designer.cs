namespace Tyuiu.YachmenevaPV.Sprint6.Task6.V22
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
            labelInfo_YPV.Location = new Point(12, 21);
            labelInfo_YPV.Name = "labelInfo_YPV";
            labelInfo_YPV.Size = new Size(770, 369);
            labelInfo_YPV.TabIndex = 0;
            labelInfo_YPV.Text = resources.GetString("labelInfo_YPV.Text");
            // 
            // buttonOK_YPV
            // 
            buttonOK_YPV.BackColor = SystemColors.ActiveCaption;
            buttonOK_YPV.FlatStyle = FlatStyle.Flat;
            buttonOK_YPV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOK_YPV.Location = new Point(877, 311);
            buttonOK_YPV.Name = "buttonOK_YPV";
            buttonOK_YPV.Size = new Size(188, 79);
            buttonOK_YPV.TabIndex = 1;
            buttonOK_YPV.Text = "OK";
            buttonOK_YPV.UseVisualStyleBackColor = false;
            buttonOK_YPV.Click += buttonOK_YPV_Click;
            // 
            // FormAbout_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 426);
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