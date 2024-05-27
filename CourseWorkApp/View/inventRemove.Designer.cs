namespace CourseWorkApp.View
{
    partial class inventRemove
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
            labelName = new Label();
            nameLabel = new Label();
            labelDate = new Label();
            dateLabel = new Label();
            labelCost = new Label();
            costLabel = new Label();
            cancelBtn = new Button();
            delBtn = new Button();
            label1 = new Label();
            roomLabel = new Label();
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
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 29);
            labelName.Name = "labelName";
            labelName.Size = new Size(116, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Наименование";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(198, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(138, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "defНаименование";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 49);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(108, 20);
            labelDate.TabIndex = 4;
            labelDate.Text = "Дата поставки";
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
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(12, 69);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(166, 20);
            labelCost.TabIndex = 6;
            labelCost.Text = "Закупочная стоимость";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(198, 69);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(105, 20);
            costLabel.TabIndex = 7;
            costLabel.Text = "defСтоимость";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 10;
            label1.Text = "Комната";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Location = new Point(198, 89);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(91, 20);
            roomLabel.TabIndex = 11;
            roomLabel.Text = "defКомната";
            // 
            // inventRemove
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 145);
            Controls.Add(roomLabel);
            Controls.Add(label1);
            Controls.Add(delBtn);
            Controls.Add(cancelBtn);
            Controls.Add(costLabel);
            Controls.Add(labelCost);
            Controls.Add(dateLabel);
            Controls.Add(labelDate);
            Controls.Add(nameLabel);
            Controls.Add(labelName);
            Controls.Add(numLabel);
            Controls.Add(labelNum);
            Name = "inventRemove";
            Text = "inventRemove";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNum;
        private Label labelName;
        private Label labelDate;
        private Label labelCost;
        private Button cancelBtn;
        private Button delBtn;
        private Label label1;
        public Label numLabel;
        public Label nameLabel;
        public Label dateLabel;
        public Label costLabel;
        public Label roomLabel;
    }
}