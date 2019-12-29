namespace Lab11
{
    partial class LabWnd11
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
            this.helpBtn = new System.Windows.Forms.Button();
            this.executeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.integrationMethodSelectBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subDomainsInputBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.topLimitInputBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.bottomLimitInputBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.formulaInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subDomainsInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLimitInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLimitInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.helpBtn);
            this.panel1.Controls.Add(this.executeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 69);
            this.panel1.TabIndex = 0;
            // 
            // helpBtn
            // 
            this.helpBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Location = new System.Drawing.Point(0, 0);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(150, 69);
            this.helpBtn.TabIndex = 1;
            this.helpBtn.Text = "Допомога";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // executeBtn
            // 
            this.executeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.executeBtn.FlatAppearance.BorderSize = 0;
            this.executeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeBtn.Location = new System.Drawing.Point(534, 0);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(150, 69);
            this.executeBtn.TabIndex = 0;
            this.executeBtn.Text = "Обчислити";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.integrationMethodSelectBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.subDomainsInputBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.topLimitInputBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bottomLimitInputBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.formulaInputBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 332);
            this.panel2.TabIndex = 1;
            // 
            // integrationMethodSelectBox
            // 
            this.integrationMethodSelectBox.BackColor = System.Drawing.Color.White;
            this.integrationMethodSelectBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.integrationMethodSelectBox.DropDownHeight = 200;
            this.integrationMethodSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.integrationMethodSelectBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.integrationMethodSelectBox.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrationMethodSelectBox.IntegralHeight = false;
            this.integrationMethodSelectBox.ItemHeight = 40;
            this.integrationMethodSelectBox.Location = new System.Drawing.Point(0, 340);
            this.integrationMethodSelectBox.Name = "integrationMethodSelectBox";
            this.integrationMethodSelectBox.Size = new System.Drawing.Size(667, 48);
            this.integrationMethodSelectBox.Sorted = true;
            this.integrationMethodSelectBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(667, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Оберіть метод інтегрування:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subDomainsInputBox
            // 
            this.subDomainsInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subDomainsInputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.subDomainsInputBox.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subDomainsInputBox.Location = new System.Drawing.Point(0, 263);
            this.subDomainsInputBox.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.subDomainsInputBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.subDomainsInputBox.Name = "subDomainsInputBox";
            this.subDomainsInputBox.Size = new System.Drawing.Size(667, 42);
            this.subDomainsInputBox.TabIndex = 7;
            this.subDomainsInputBox.ThousandsSeparator = true;
            this.subDomainsInputBox.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(667, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вкажіть кількість піддоменів:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topLimitInputBox
            // 
            this.topLimitInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topLimitInputBox.DecimalPlaces = 15;
            this.topLimitInputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLimitInputBox.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLimitInputBox.Location = new System.Drawing.Point(0, 186);
            this.topLimitInputBox.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.topLimitInputBox.Minimum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            -2147483648});
            this.topLimitInputBox.Name = "topLimitInputBox";
            this.topLimitInputBox.Size = new System.Drawing.Size(667, 42);
            this.topLimitInputBox.TabIndex = 5;
            this.topLimitInputBox.ThousandsSeparator = true;
            this.topLimitInputBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(667, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вкажіть верхню границю:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bottomLimitInputBox
            // 
            this.bottomLimitInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bottomLimitInputBox.DecimalPlaces = 15;
            this.bottomLimitInputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomLimitInputBox.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLimitInputBox.Location = new System.Drawing.Point(0, 109);
            this.bottomLimitInputBox.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.bottomLimitInputBox.Minimum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            -2147483648});
            this.bottomLimitInputBox.Name = "bottomLimitInputBox";
            this.bottomLimitInputBox.Size = new System.Drawing.Size(667, 42);
            this.bottomLimitInputBox.TabIndex = 3;
            this.bottomLimitInputBox.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(667, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вкажіть нижню границю:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formulaInputBox
            // 
            this.formulaInputBox.BackColor = System.Drawing.Color.White;
            this.formulaInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.formulaInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.formulaInputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.formulaInputBox.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulaInputBox.Location = new System.Drawing.Point(0, 35);
            this.formulaInputBox.Name = "formulaInputBox";
            this.formulaInputBox.Size = new System.Drawing.Size(667, 39);
            this.formulaInputBox.TabIndex = 1;
            this.formulaInputBox.Text = "Math.Pow(x, 3)";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть функцію, яку необхідно проінтегрувати, у вигляді C# коду:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabWnd11
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LabWnd11";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LabWnd11_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subDomainsInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLimitInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLimitInputBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox formulaInputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown topLimitInputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown bottomLimitInputBox;
        private System.Windows.Forms.NumericUpDown subDomainsInputBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox integrationMethodSelectBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button helpBtn;
    }
}