namespace ProgrammingLab
{
    partial class MainWindow
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
            this.aboutBtn = new System.Windows.Forms.Button();
            this.primaryPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // aboutBtn
            // 
            this.aboutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Location = new System.Drawing.Point(0, 212);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(534, 37);
            this.aboutBtn.TabIndex = 1;
            this.aboutBtn.Text = "Про програму";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // primaryPanel
            // 
            this.primaryPanel.AutoScroll = true;
            this.primaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryPanel.Location = new System.Drawing.Point(0, 0);
            this.primaryPanel.Name = "primaryPanel";
            this.primaryPanel.Size = new System.Drawing.Size(534, 212);
            this.primaryPanel.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 249);
            this.Controls.Add(this.primaryPanel);
            this.Controls.Add(this.aboutBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приклади виконання лабораторних робіт з програмування (1 курс)";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Panel primaryPanel;
    }
}