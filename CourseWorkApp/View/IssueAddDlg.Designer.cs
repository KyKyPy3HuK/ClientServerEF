namespace CourseWorkApp.View
{
    partial class IssueAddDlg
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
            labelTitle = new Label();
            cancelBtn = new Button();
            okBtn = new Button();
            textTextBox1 = new TextBox();
            labelText = new Label();
            titleTextBox = new TextBox();
            labelAutor = new Label();
            AutorComboBox = new ComboBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.RightToLeft = RightToLeft.No;
            labelTitle.Size = new Size(44, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Тема";
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(222, 298);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(122, 29);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(350, 298);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(122, 29);
            okBtn.TabIndex = 5;
            okBtn.Text = "Добавить";
            okBtn.UseVisualStyleBackColor = true;
            // 
            // textTextBox1
            // 
            textTextBox1.Location = new Point(12, 76);
            textTextBox1.Multiline = true;
            textTextBox1.Name = "textTextBox1";
            textTextBox1.ScrollBars = ScrollBars.Vertical;
            textTextBox1.Size = new Size(460, 182);
            textTextBox1.TabIndex = 2;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(12, 53);
            labelText.Name = "labelText";
            labelText.RightToLeft = RightToLeft.No;
            labelText.Size = new Size(118, 20);
            labelText.TabIndex = 13;
            labelText.Text = "Основной текст";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(62, 12);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(410, 27);
            titleTextBox.TabIndex = 1;
            // 
            // labelAutor
            // 
            labelAutor.AutoSize = true;
            labelAutor.Location = new Point(12, 267);
            labelAutor.Name = "labelAutor";
            labelAutor.RightToLeft = RightToLeft.No;
            labelAutor.Size = new Size(95, 20);
            labelAutor.TabIndex = 15;
            labelAutor.Text = "Составитель";
            // 
            // AutorComboBox
            // 
            AutorComboBox.FormattingEnabled = true;
            AutorComboBox.Location = new Point(123, 264);
            AutorComboBox.Name = "AutorComboBox";
            AutorComboBox.Size = new Size(349, 28);
            AutorComboBox.TabIndex = 3;
            // 
            // IssueAddDlg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 335);
            Controls.Add(AutorComboBox);
            Controls.Add(labelAutor);
            Controls.Add(titleTextBox);
            Controls.Add(labelText);
            Controls.Add(textTextBox1);
            Controls.Add(okBtn);
            Controls.Add(cancelBtn);
            Controls.Add(labelTitle);
            Name = "IssueAddDlg";
            Text = "Добавить заявку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button cancelBtn;
        private Button okBtn;
        private TextBox textTextBox1;
        private Label labelText;
        private TextBox titleTextBox;
        private Label labelAutor;
        private ComboBox AutorComboBox;
    }
}