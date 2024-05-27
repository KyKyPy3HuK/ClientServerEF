namespace CourseWorkApp.View
{
    partial class inventAllCostDlg
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
            allCostLabel = new Label();
            SuspendLayout();
            // 
            // allCostLabel
            // 
            allCostLabel.AutoSize = true;
            allCostLabel.Font = new Font("Segoe UI", 15F);
            allCostLabel.Location = new Point(12, 9);
            allCostLabel.Name = "allCostLabel";
            allCostLabel.Size = new Size(81, 35);
            allCostLabel.TabIndex = 0;
            allCostLabel.Text = "label1";
            // 
            // inventAllCostDlg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 62);
            Controls.Add(allCostLabel);
            Name = "inventAllCostDlg";
            Text = "Отчет";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label allCostLabel;
    }
}