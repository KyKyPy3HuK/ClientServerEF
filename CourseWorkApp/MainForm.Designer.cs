namespace CourseWorkApp
{
    partial class MainForm
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
            tabControl = new TabControl();
            vahtsTabPage = new TabPage();
            dataGridView2 = new DataGridView();
            menuStrip2 = new MenuStrip();
            добавитьToolStripMenuItem1 = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            inventTabPage = new TabPage();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            обновитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem1 = new ToolStripMenuItem();
            zayavTabPage = new TabPage();
            dataGridView3 = new DataGridView();
            menuStrip3 = new MenuStrip();
            добавитьToolStripMenuItem2 = new ToolStripMenuItem();
            обновитьСтатусToolStripMenuItem = new ToolStripMenuItem();
            tabControl.SuspendLayout();
            vahtsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            menuStrip2.SuspendLayout();
            inventTabPage.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            zayavTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(vahtsTabPage);
            tabControl.Controls.Add(inventTabPage);
            tabControl.Controls.Add(zayavTabPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            // 
            // vahtsTabPage
            // 
            vahtsTabPage.Controls.Add(dataGridView2);
            vahtsTabPage.Controls.Add(menuStrip2);
            vahtsTabPage.Location = new Point(4, 29);
            vahtsTabPage.Name = "vahtsTabPage";
            vahtsTabPage.Padding = new Padding(3);
            vahtsTabPage.Size = new Size(792, 417);
            vahtsTabPage.TabIndex = 0;
            vahtsTabPage.Text = "Вахты";
            vahtsTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 31);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(786, 383);
            dataGridView2.TabIndex = 1;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem1, изменитьToolStripMenuItem, удалитьToolStripMenuItem });
            menuStrip2.Location = new Point(3, 3);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(786, 28);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // добавитьToolStripMenuItem1
            // 
            добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            добавитьToolStripMenuItem1.Size = new Size(90, 24);
            добавитьToolStripMenuItem1.Text = "Добавить";
            добавитьToolStripMenuItem1.Click += добавитьToolStripMenuItem1_Click;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(92, 24);
            изменитьToolStripMenuItem.Text = "Изменить";
            изменитьToolStripMenuItem.Click += изменитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(79, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // inventTabPage
            // 
            inventTabPage.Controls.Add(panel1);
            inventTabPage.Controls.Add(menuStrip1);
            inventTabPage.Location = new Point(4, 29);
            inventTabPage.Name = "inventTabPage";
            inventTabPage.Padding = new Padding(3);
            inventTabPage.Size = new Size(792, 417);
            inventTabPage.TabIndex = 1;
            inventTabPage.Text = "Инвентарь";
            inventTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 383);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(786, 383);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, обновитьToolStripMenuItem, удалитьToolStripMenuItem1 });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(786, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(90, 24);
            добавитьToolStripMenuItem.Text = "Добавить";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // обновитьToolStripMenuItem
            // 
            обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            обновитьToolStripMenuItem.Size = new Size(92, 24);
            обновитьToolStripMenuItem.Text = "Обновить";
            обновитьToolStripMenuItem.Click += обновитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem1
            // 
            удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            удалитьToolStripMenuItem1.Size = new Size(79, 24);
            удалитьToolStripMenuItem1.Text = "Удалить";
            удалитьToolStripMenuItem1.Click += удалитьToolStripMenuItem1_Click;
            // 
            // zayavTabPage
            // 
            zayavTabPage.Controls.Add(dataGridView3);
            zayavTabPage.Controls.Add(menuStrip3);
            zayavTabPage.Location = new Point(4, 29);
            zayavTabPage.Name = "zayavTabPage";
            zayavTabPage.Padding = new Padding(3);
            zayavTabPage.Size = new Size(792, 417);
            zayavTabPage.TabIndex = 2;
            zayavTabPage.Text = "Заявки";
            zayavTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 31);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(786, 383);
            dataGridView3.TabIndex = 1;
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem2, обновитьСтатусToolStripMenuItem });
            menuStrip3.Location = new Point(3, 3);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(786, 28);
            menuStrip3.TabIndex = 0;
            menuStrip3.Text = "menuStrip3";
            // 
            // добавитьToolStripMenuItem2
            // 
            добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            добавитьToolStripMenuItem2.Size = new Size(90, 24);
            добавитьToolStripMenuItem2.Text = "Добавить";
            добавитьToolStripMenuItem2.Click += добавитьToolStripMenuItem2_Click;
            // 
            // обновитьСтатусToolStripMenuItem
            // 
            обновитьСтатусToolStripMenuItem.Name = "обновитьСтатусToolStripMenuItem";
            обновитьСтатусToolStripMenuItem.Size = new Size(137, 24);
            обновитьСтатусToolStripMenuItem.Text = "Обновить статус";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            tabControl.ResumeLayout(false);
            vahtsTabPage.ResumeLayout(false);
            vahtsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            inventTabPage.ResumeLayout(false);
            inventTabPage.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            zayavTabPage.ResumeLayout(false);
            zayavTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage vahtsTabPage;
        private TabPage inventTabPage;
        private Panel panel1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private TabPage zayavTabPage;
        private DataGridView dataGridView2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem добавитьToolStripMenuItem1;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private DataGridView dataGridView3;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem добавитьToolStripMenuItem2;
        private ToolStripMenuItem обновитьСтатусToolStripMenuItem;
        private ToolStripMenuItem обновитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem1;
    }
}