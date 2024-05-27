namespace CourseWorkApp.View
{
    partial class inventUpdate
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
            labelName = new Label();
            labelDate = new Label();
            labelCost = new Label();
            labelRoom = new Label();
            nameTextBox = new TextBox();
            dateTimePicker = new DateTimePicker();
            roomComboBox = new ComboBox();
            costNumeric = new NumericUpDown();
            cancelBtn = new Button();
            okBtn = new Button();
            labelCode = new Label();
            numLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)costNumeric).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 35);
            labelName.Name = "labelName";
            labelName.Size = new Size(116, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Наименование";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 70);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(108, 20);
            labelDate.TabIndex = 1;
            labelDate.Text = "Дата поставки";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(12, 100);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(166, 20);
            labelCost.TabIndex = 2;
            labelCost.Text = "Закупочная стоимость";
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Location = new Point(12, 134);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(122, 20);
            labelRoom.TabIndex = 3;
            labelRoom.Text = "Номер комнаты";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(218, 32);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 27);
            nameTextBox.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(218, 65);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // roomComboBox
            // 
            roomComboBox.FormattingEnabled = true;
            roomComboBox.Location = new Point(218, 131);
            roomComboBox.Name = "roomComboBox";
            roomComboBox.Size = new Size(122, 28);
            roomComboBox.TabIndex = 7;
            // 
            // costNumeric
            // 
            costNumeric.Location = new Point(218, 98);
            costNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            costNumeric.Name = "costNumeric";
            costNumeric.Size = new Size(122, 27);
            costNumeric.TabIndex = 8;
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
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(12, 9);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(57, 20);
            labelCode.TabIndex = 11;
            labelCode.Text = "Номер";
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Location = new Point(218, 9);
            numLabel.Name = "numLabel";
            numLabel.Size = new Size(79, 20);
            numLabel.TabIndex = 12;
            numLabel.Text = "defНомер";
            // 
            // inventUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 203);
            Controls.Add(numLabel);
            Controls.Add(labelCode);
            Controls.Add(okBtn);
            Controls.Add(cancelBtn);
            Controls.Add(costNumeric);
            Controls.Add(roomComboBox);
            Controls.Add(dateTimePicker);
            Controls.Add(nameTextBox);
            Controls.Add(labelRoom);
            Controls.Add(labelCost);
            Controls.Add(labelDate);
            Controls.Add(labelName);
            Name = "inventUpdate";
            Text = "Обновить инвентарь";
            ((System.ComponentModel.ISupportInitialize)costNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelDate;
        private Label labelCost;
        private Label labelRoom;
        private Button cancelBtn;
        private Button okBtn;
        private Label labelCode;
        public TextBox nameTextBox;
        public DateTimePicker dateTimePicker;
        public ComboBox roomComboBox;
        public NumericUpDown costNumeric;
        public Label numLabel;
    }
}