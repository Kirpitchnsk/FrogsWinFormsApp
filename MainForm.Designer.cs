namespace FrogsWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stepNumberLabel = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            rulesToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // stepNumberLabel
            // 
            stepNumberLabel.AutoSize = true;
            stepNumberLabel.Location = new Point(12, 145);
            stepNumberLabel.Name = "stepNumberLabel";
            stepNumberLabel.Size = new Size(22, 25);
            stepNumberLabel.TabIndex = 1;
            stepNumberLabel.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rulesToolStripMenuItem, restartToolStripMenuItem1 });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(78, 29);
            menuToolStripMenuItem.Text = "Меню";
            // 
            // rulesToolStripMenuItem
            // 
            rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            rulesToolStripMenuItem.Size = new Size(237, 34);
            rulesToolStripMenuItem.Text = "Правила Игры";
            rulesToolStripMenuItem.Click += rulesToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem1
            // 
            restartToolStripMenuItem1.Name = "restartToolStripMenuItem1";
            restartToolStripMenuItem1.Size = new Size(237, 34);
            restartToolStripMenuItem1.Text = "Начать Заново";
            restartToolStripMenuItem1.Click += restartToolStripMenuItem1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 173);
            Controls.Add(stepNumberLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label stepNumberLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem1;
    }
}