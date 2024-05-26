namespace CourseWorkApp.View
{
    partial class loginForm
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
            label1 = new Label();
            passTextBox = new TextBox();
            buttonCancel = new Button();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите пароль администратора";
            // 
            // passTextBox
            // 
            passTextBox.ForeColor = SystemColors.WindowText;
            passTextBox.Location = new Point(12, 32);
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '#';
            passTextBox.Size = new Size(240, 27);
            passTextBox.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(12, 65);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(158, 65);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Вход";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 108);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Controls.Add(passTextBox);
            Controls.Add(label1);
            Name = "loginForm";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox2;
        private Button buttonCancel;
        private Button buttonOk;
        public TextBox passTextBox;
    }
}