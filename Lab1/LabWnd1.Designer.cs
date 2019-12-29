using System.ComponentModel;

namespace ProgrammingLab.Labs.Lab1
{
    partial class LabWnd1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.InputBoxA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputBoxB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputBoxC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBoxA
            // 
            this.InputBoxA.Location = new System.Drawing.Point(10, 12);
            this.InputBoxA.Name = "InputBoxA";
            this.InputBoxA.Size = new System.Drawing.Size(26, 20);
            this.InputBoxA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x^2 +";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InputBoxB
            // 
            this.InputBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputBoxB.Location = new System.Drawing.Point(86, 12);
            this.InputBoxB.Name = "InputBoxB";
            this.InputBoxB.Size = new System.Drawing.Size(26, 20);
            this.InputBoxB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x +";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InputBoxC
            // 
            this.InputBoxC.Location = new System.Drawing.Point(147, 12);
            this.InputBoxC.Name = "InputBoxC";
            this.InputBoxC.Size = new System.Drawing.Size(26, 20);
            this.InputBoxC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "= 0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteBtn.Location = new System.Drawing.Point(10, 42);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(192, 23);
            this.ExecuteBtn.TabIndex = 6;
            this.ExecuteBtn.Text = "Розрахувати";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // LabWnd1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(209, 71);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputBoxC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputBoxB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputBoxA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabWnd1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputBoxB;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.TextBox InputBoxC;
        private System.Windows.Forms.TextBox InputBoxA;
    }
}