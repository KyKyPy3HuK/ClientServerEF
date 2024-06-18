namespace CourseWorkApp.View
{
    partial class IssueUpdateDlg
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
            numLabel = new Label();
            titleLabel = new Label();
            textTextBox = new TextBox();
            statusLabel = new Label();
            statusComboBox = new ComboBox();
            labelText = new Label();
            okBtn = new Button();
            cancelBtn = new Button();
            autorLabel = new Label();
            dataLabel = new Label();
            SuspendLayout();
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Location = new Point(12, 9);
            numLabel.Name = "numLabel";
            numLabel.Size = new Size(77, 20);
            numLabel.TabIndex = 0;
            numLabel.Text = "Заявка №";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(12, 29);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(44, 20);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Тема";
            // 
            // textTextBox
            // 
            textTextBox.Location = new Point(12, 169);
            textTextBox.Multiline = true;
            textTextBox.Name = "textTextBox";
            textTextBox.ReadOnly = true;
            textTextBox.ScrollBars = ScrollBars.Vertical;
            textTextBox.Size = new Size(460, 182);
            textTextBox.TabIndex = 2;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(12, 49);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(55, 20);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Статус:";
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.ImeMode = ImeMode.NoControl;
            statusComboBox.Location = new Point(12, 72);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(151, 28);
            statusComboBox.TabIndex = 1;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(12, 146);
            labelText.Name = "labelText";
            labelText.Size = new Size(45, 20);
            labelText.TabIndex = 5;
            labelText.Text = "Текст";
            // 
            // okBtn
            // 
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(344, 357);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(128, 29);
            okBtn.TabIndex = 4;
            okBtn.Text = "Подтвердить";
            okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(210, 357);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(128, 29);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new Point(12, 126);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new Size(51, 20);
            autorLabel.TabIndex = 6;
            autorLabel.Text = "Автор";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new Point(12, 103);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new Size(41, 20);
            dataLabel.TabIndex = 7;
            dataLabel.Text = "Дата";
            // 
            // IssueUpdateDlg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 398);
            Controls.Add(dataLabel);
            Controls.Add(autorLabel);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(labelText);
            Controls.Add(statusComboBox);
            Controls.Add(statusLabel);
            Controls.Add(textTextBox);
            Controls.Add(titleLabel);
            Controls.Add(numLabel);
            Name = "IssueUpdateDlg";
            Text = "Изменить статус";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label statusLabel;
        private Label labelText;
        private Button okBtn;
        private Button cancelBtn;
        public ComboBox statusComboBox;
        public Label numLabel;
        public Label titleLabel;
        public TextBox textTextBox;
        public Label autorLabel;
        public Label dataLabel;
    }
}