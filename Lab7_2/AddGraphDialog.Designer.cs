namespace ProgrammingLab.Labs.Lab7
{
    partial class AddGraphDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialogBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.graphTextBox = new System.Windows.Forms.RichTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colorDialogBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.applyBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 30);
            this.panel1.TabIndex = 0;
            // 
            // colorDialogBtn
            // 
            this.colorDialogBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorDialogBtn.FlatAppearance.BorderSize = 0;
            this.colorDialogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorDialogBtn.Location = new System.Drawing.Point(67, 0);
            this.colorDialogBtn.Name = "colorDialogBtn";
            this.colorDialogBtn.Size = new System.Drawing.Size(224, 30);
            this.colorDialogBtn.TabIndex = 2;
            this.colorDialogBtn.Text = "Обрати колір графіку";
            this.colorDialogBtn.UseVisualStyleBackColor = true;
            this.colorDialogBtn.Click += new System.EventHandler(this.colorDialogBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(0, 0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(67, 30);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.AutoSize = true;
            this.applyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtn.Location = new System.Drawing.Point(291, 0);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(93, 30);
            this.applyBtn.TabIndex = 0;
            this.applyBtn.Text = "Додати графік";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // graphTextBox
            // 
            this.graphTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graphTextBox.DetectUrls = false;
            this.graphTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphTextBox.Location = new System.Drawing.Point(0, 0);
            this.graphTextBox.MaxLength = 1000;
            this.graphTextBox.Name = "graphTextBox";
            this.graphTextBox.Size = new System.Drawing.Size(384, 131);
            this.graphTextBox.TabIndex = 1;
            this.graphTextBox.Text = "";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // AddGraphDialog
            // 
            this.AcceptButton = this.applyBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.ControlBox = false;
            this.Controls.Add(this.graphTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGraphDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додати новий графік";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.RichTextBox graphTextBox;
        private System.Windows.Forms.Button colorDialogBtn;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}