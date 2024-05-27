namespace CourseWorkApp.View
{
    partial class VahtRemoveDlg
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
            labelNum = new Label();
            numLabel = new Label();
            labelType = new Label();
            typeLabel = new Label();
            labelDate = new Label();
            dateLabel = new Label();
            labelTime = new Label();
            timeLabel = new Label();
            cancelBtn = new Button();
            delBtn = new Button();
            labelWorker = new Label();
            workerLabel = new Label();
            SuspendLayout();
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Location = new Point(12, 9);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(57, 20);
            labelNum.TabIndex = 0;
            labelNum.Text = "Номер";
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Location = new Point(198, 9);
            numLabel.Name = "numLabel";
            numLabel.Size = new Size(79, 20);
            numLabel.TabIndex = 1;
            numLabel.Text = "defНомер";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(12, 29);
            labelType.Name = "labelType";
            labelType.Size = new Size(35, 20);
            labelType.TabIndex = 2;
            labelType.Text = "Тип";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(198, 29);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(57, 20);
            typeLabel.TabIndex = 3;
            typeLabel.Text = "defТип";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 49);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(92, 20);
            labelDate.TabIndex = 4;
            labelDate.Text = "Дата захода";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(198, 49);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(63, 20);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "defДата";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(12, 69);
            labelTime.Name = "labelTime";
            labelTime.RightToLeft = RightToLeft.No;
            labelTime.Size = new Size(105, 20);
            labelTime.TabIndex = 6;
            labelTime.Text = "Длительность";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(198, 69);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(127, 20);
            timeLabel.TabIndex = 7;
            timeLabel.Text = "defДлительность";
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(198, 112);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(138, 29);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            delBtn.DialogResult = DialogResult.OK;
            delBtn.Location = new Point(342, 112);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(123, 29);
            delBtn.TabIndex = 9;
            delBtn.Text = "Удалить";
            delBtn.UseVisualStyleBackColor = true;
            // 
            // labelWorker
            // 
            labelWorker.AutoSize = true;
            labelWorker.Location = new Point(12, 89);
            labelWorker.Name = "labelWorker";
            labelWorker.Size = new Size(56, 20);
            labelWorker.TabIndex = 10;
            labelWorker.Text = "Вахтер";
            // 
            // workerLabel
            // 
            workerLabel.AutoSize = true;
            workerLabel.Location = new Point(198, 89);
            workerLabel.Name = "workerLabel";
            workerLabel.Size = new Size(78, 20);
            workerLabel.TabIndex = 11;
            workerLabel.Text = "defВахтер";
            // 
            // VahtRemoveDlg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 145);
            Controls.Add(workerLabel);
            Controls.Add(labelWorker);
            Controls.Add(delBtn);
            Controls.Add(cancelBtn);
            Controls.Add(timeLabel);
            Controls.Add(labelTime);
            Controls.Add(dateLabel);
            Controls.Add(labelDate);
            Controls.Add(typeLabel);
            Controls.Add(labelType);
            Controls.Add(numLabel);
            Controls.Add(labelNum);
            Name = "VahtRemoveDlg";
            Text = "Удаление вахты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNum;
        private Label labelType;
        private Label labelDate;
        private Label labelTime;
        private Button cancelBtn;
        private Button delBtn;
        private Label labelWorker;
        public Label numLabel;
        public Label typeLabel;
        public Label dateLabel;
        public Label timeLabel;
        public Label workerLabel;
    }
}