namespace CourseWorkApp.View
{
    partial class VahtUpdDlg
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
            typeComboBox = new ComboBox();
            timeNumeric = new NumericUpDown();
            cancelBtn = new Button();
            okBtn = new Button();
            workerComboBox = new ComboBox();
            labelCode = new Label();
            codeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)timeNumeric).BeginInit();
            SuspendLayout();
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(12, 40);
            labelType.Name = "labelType";
            labelType.RightToLeft = RightToLeft.No;
            labelType.Size = new Size(35, 20);
            labelType.TabIndex = 0;
            labelType.Text = "Тип";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 70);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(92, 20);
            labelDate.TabIndex = 1;
            labelDate.Text = "Дата захода";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(12, 100);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(159, 20);
            labelTime.TabIndex = 2;
            labelTime.Text = "Длительность в часах";
            // 
            // labelWorker
            // 
            labelWorker.AutoSize = true;
            labelWorker.Location = new Point(12, 134);
            labelWorker.Name = "labelWorker";
            labelWorker.Size = new Size(56, 20);
            labelWorker.TabIndex = 3;
            labelWorker.Text = "Вахтер";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(218, 65);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(218, 32);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(250, 28);
            typeComboBox.TabIndex = 7;
            // 
            // timeNumeric
            // 
            timeNumeric.Location = new Point(218, 98);
            timeNumeric.Name = "timeNumeric";
            timeNumeric.Size = new Size(122, 27);
            timeNumeric.TabIndex = 8;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(218, 165);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(122, 29);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(346, 165);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(122, 29);
            okBtn.TabIndex = 10;
            okBtn.Text = "Обновить";
            okBtn.UseVisualStyleBackColor = true;
            // 
            // workerComboBox
            // 
            workerComboBox.FormattingEnabled = true;
            workerComboBox.Location = new Point(218, 131);
            workerComboBox.Name = "workerComboBox";
            workerComboBox.Size = new Size(250, 28);
            workerComboBox.TabIndex = 11;
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(12, 9);
            labelCode.Name = "labelCode";
            labelCode.RightToLeft = RightToLeft.No;
            labelCode.Size = new Size(57, 20);
            labelCode.TabIndex = 12;
            labelCode.Text = "Номер";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(218, 9);
            codeLabel.Name = "codeLabel";
            codeLabel.RightToLeft = RightToLeft.No;
            codeLabel.Size = new Size(79, 20);
            codeLabel.TabIndex = 13;
            codeLabel.Text = "defНомер";
            // 
            // vahtUpdDlg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 205);
            Controls.Add(codeLabel);
            Controls.Add(labelCode);
            Controls.Add(workerComboBox);
            Controls.Add(okBtn);
            Controls.Add(cancelBtn);
            Controls.Add(timeNumeric);
            Controls.Add(typeComboBox);
            Controls.Add(dateTimePicker);
            Controls.Add(labelWorker);
            Controls.Add(labelTime);
            Controls.Add(labelDate);
            Controls.Add(labelType);
            Name = "vahtUpdDlg";
            Text = "Обновить вахту";
            ((System.ComponentModel.ISupportInitialize)timeNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelType;
        private Label labelDate;
        private Label labelTime;
        private Label labelWorker;
        private DateTimePicker dateTimePicker;
        private ComboBox typeComboBox;
        private NumericUpDown timeNumeric;
        private Button cancelBtn;
        private Button okBtn;
        private ComboBox workerComboBox;
        private Label labelCode;
        private Label codeLabel;
    }
}