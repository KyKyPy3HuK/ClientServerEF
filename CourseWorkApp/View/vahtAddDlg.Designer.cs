namespace CourseWorkApp.View
{
    partial class VahtAddDlg
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
            labelType = new Label();
            labelDate = new Label();
            labelTime = new Label();
            labelWorker = new Label();
            dateTimePicker = new DateTimePicker();
            roomComboBox = new ComboBox();
            costNumeric = new NumericUpDown();
            cancelBtn = new Button();
            okBtn = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)costNumeric).BeginInit();
            SuspendLayout();
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(12, 20);
            labelType.Name = "labelType";
            labelType.RightToLeft = RightToLeft.No;
            labelType.Size = new Size(35, 20);
            labelType.TabIndex = 0;
            labelType.Text = "Тип";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 50);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(92, 20);
            labelDate.TabIndex = 1;
            labelDate.Text = "Дата захода";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(12, 80);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(159, 20);
            labelTime.TabIndex = 2;
            labelTime.Text = "Длительность в часах";
            // 
            // labelWorker
            // 
            labelWorker.AutoSize = true;
            labelWorker.Location = new Point(12, 114);
            labelWorker.Name = "labelWorker";
            labelWorker.Size = new Size(56, 20);
            labelWorker.TabIndex = 3;
            labelWorker.Text = "Вахтер";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(218, 45);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // roomComboBox
            // 
            roomComboBox.FormattingEnabled = true;
            roomComboBox.Location = new Point(218, 12);
            roomComboBox.Name = "roomComboBox";
            roomComboBox.Size = new Size(250, 28);
            roomComboBox.TabIndex = 7;
            // 
            // costNumeric
            // 
            costNumeric.Location = new Point(218, 78);
            costNumeric.Name = "costNumeric";
            costNumeric.Size = new Size(122, 27);
            costNumeric.TabIndex = 8;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(218, 145);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(122, 29);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(346, 145);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(122, 29);
            okBtn.TabIndex = 10;
            okBtn.Text = "Добавить";
            okBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(218, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 11;
            // 
            // VahtAddDlg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 184);
            Controls.Add(comboBox1);
            Controls.Add(okBtn);
            Controls.Add(cancelBtn);
            Controls.Add(costNumeric);
            Controls.Add(roomComboBox);
            Controls.Add(dateTimePicker);
            Controls.Add(labelWorker);
            Controls.Add(labelTime);
            Controls.Add(labelDate);
            Controls.Add(labelType);
            Name = "VahtAddDlg";
            Text = "Добавить вахту";
            ((System.ComponentModel.ISupportInitialize)costNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelType;
        private Label labelDate;
        private Label labelTime;
        private Label labelWorker;
        private Button cancelBtn;
        private Button okBtn;
        public DateTimePicker dateTimePicker;
        public ComboBox roomComboBox;
        public NumericUpDown costNumeric;
        public ComboBox comboBox1;
    }
}