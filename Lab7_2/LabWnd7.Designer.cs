using System.ComponentModel;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProgrammingLab.Labs.Lab7
{
    partial class LabWnd7
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
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Math.Cos(x)"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Red, null);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Math.Pow((x + 2), 2)"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Aqua, null);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "Math.Pow(x, 2)"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Yellow, null);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "Math.Sin(x)"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Lime, null);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(new string[] {
            "Math.Sqrt(x)"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Blue, null);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.graphsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addGraphBtn = new System.Windows.Forms.Button();
            this.deleteGraphsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.incrementPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.incrementBox = new System.Windows.Forms.TextBox();
            this.buildGraphsBtn = new System.Windows.Forms.Button();
            this.limitPanel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rightLimitBox = new System.Windows.Forms.TextBox();
            this.limitPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.leftLimitBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.graphsPane = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.controlPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.incrementPanel.SuspendLayout();
            this.limitPanel2.SuspendLayout();
            this.limitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphsPane)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.panel2);
            this.controlPanel.Controls.Add(this.panel1);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 303);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(586, 183);
            this.controlPanel.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.graphsList);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 135);
            this.panel2.TabIndex = 6;
            // 
            // graphsList
            // 
            this.graphsList.BackColor = System.Drawing.Color.White;
            this.graphsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphsList.CheckBoxes = true;
            this.graphsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.graphsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphsList.FullRowSelect = true;
            this.graphsList.HideSelection = false;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.StateImageIndex = 0;
            listViewItem18.StateImageIndex = 0;
            listViewItem19.StateImageIndex = 0;
            listViewItem20.StateImageIndex = 0;
            this.graphsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20});
            this.graphsList.Location = new System.Drawing.Point(0, 0);
            this.graphsList.Name = "graphsList";
            this.graphsList.ShowItemToolTips = true;
            this.graphsList.Size = new System.Drawing.Size(586, 106);
            this.graphsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.graphsList.TabIndex = 1;
            this.graphsList.UseCompatibleStateImageBehavior = false;
            this.graphsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Формула";
            this.columnHeader1.Width = 478;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Колір";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addGraphBtn);
            this.flowLayoutPanel1.Controls.Add(this.deleteGraphsBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(586, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addGraphBtn
            // 
            this.addGraphBtn.AutoSize = true;
            this.addGraphBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addGraphBtn.FlatAppearance.BorderSize = 0;
            this.addGraphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGraphBtn.Location = new System.Drawing.Point(438, 3);
            this.addGraphBtn.Name = "addGraphBtn";
            this.addGraphBtn.Size = new System.Drawing.Size(145, 23);
            this.addGraphBtn.TabIndex = 0;
            this.addGraphBtn.Text = "Додати графічну функцію";
            this.addGraphBtn.UseVisualStyleBackColor = true;
            this.addGraphBtn.Click += new System.EventHandler(this.addGraphBtn_Click);
            // 
            // deleteGraphsBtn
            // 
            this.deleteGraphsBtn.AutoSize = true;
            this.deleteGraphsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteGraphsBtn.FlatAppearance.BorderSize = 0;
            this.deleteGraphsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGraphsBtn.Location = new System.Drawing.Point(332, 3);
            this.deleteGraphsBtn.Name = "deleteGraphsBtn";
            this.deleteGraphsBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteGraphsBtn.TabIndex = 1;
            this.deleteGraphsBtn.Text = "Видалити обрані";
            this.deleteGraphsBtn.UseVisualStyleBackColor = true;
            this.deleteGraphsBtn.Click += new System.EventHandler(this.deleteGraphsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.incrementPanel);
            this.panel1.Controls.Add(this.buildGraphsBtn);
            this.panel1.Controls.Add(this.limitPanel2);
            this.panel1.Controls.Add(this.limitPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 48);
            this.panel1.TabIndex = 3;
            // 
            // incrementPanel
            // 
            this.incrementPanel.Controls.Add(this.label3);
            this.incrementPanel.Controls.Add(this.incrementBox);
            this.incrementPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.incrementPanel.Location = new System.Drawing.Point(172, 0);
            this.incrementPanel.Name = "incrementPanel";
            this.incrementPanel.Size = new System.Drawing.Size(86, 48);
            this.incrementPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Інкремент:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incrementBox
            // 
            this.incrementBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.incrementBox.Location = new System.Drawing.Point(0, 28);
            this.incrementBox.Name = "incrementBox";
            this.incrementBox.Size = new System.Drawing.Size(86, 20);
            this.incrementBox.TabIndex = 1;
            this.incrementBox.Text = "0.1";
            // 
            // buildGraphsBtn
            // 
            this.buildGraphsBtn.AutoSize = true;
            this.buildGraphsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buildGraphsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.buildGraphsBtn.FlatAppearance.BorderSize = 0;
            this.buildGraphsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildGraphsBtn.Location = new System.Drawing.Point(433, 0);
            this.buildGraphsBtn.Name = "buildGraphsBtn";
            this.buildGraphsBtn.Size = new System.Drawing.Size(153, 48);
            this.buildGraphsBtn.TabIndex = 2;
            this.buildGraphsBtn.Text = "Побудувати обрані графіки";
            this.buildGraphsBtn.UseVisualStyleBackColor = true;
            this.buildGraphsBtn.Click += new System.EventHandler(this.buildGraphsBtn_Click);
            // 
            // limitPanel2
            // 
            this.limitPanel2.Controls.Add(this.label2);
            this.limitPanel2.Controls.Add(this.rightLimitBox);
            this.limitPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.limitPanel2.Location = new System.Drawing.Point(86, 0);
            this.limitPanel2.Name = "limitPanel2";
            this.limitPanel2.Size = new System.Drawing.Size(86, 48);
            this.limitPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Права границя:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightLimitBox
            // 
            this.rightLimitBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rightLimitBox.Location = new System.Drawing.Point(0, 28);
            this.rightLimitBox.Name = "rightLimitBox";
            this.rightLimitBox.Size = new System.Drawing.Size(86, 20);
            this.rightLimitBox.TabIndex = 1;
            this.rightLimitBox.Text = "100";
            // 
            // limitPanel1
            // 
            this.limitPanel1.Controls.Add(this.label1);
            this.limitPanel1.Controls.Add(this.leftLimitBox);
            this.limitPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.limitPanel1.Location = new System.Drawing.Point(0, 0);
            this.limitPanel1.Name = "limitPanel1";
            this.limitPanel1.Size = new System.Drawing.Size(86, 48);
            this.limitPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ліва границя:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftLimitBox
            // 
            this.leftLimitBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leftLimitBox.Location = new System.Drawing.Point(0, 28);
            this.leftLimitBox.Name = "leftLimitBox";
            this.leftLimitBox.Size = new System.Drawing.Size(86, 20);
            this.leftLimitBox.TabIndex = 1;
            this.leftLimitBox.Text = "-100";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(586, 30);
            this.progressBar.TabIndex = 8;
            this.progressBar.Visible = false;
            // 
            // graphsPane
            // 
            chartArea4.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea4.AxisX.Crossing = 0D;
            chartArea4.AxisX.Interval = 5D;
            chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.IsStartedFromZero = false;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorGrid.Interval = 5D;
            chartArea4.AxisX.MinorGrid.Interval = 1D;
            chartArea4.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea4.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea4.AxisY.Crossing = 0D;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.graphsPane.ChartAreas.Add(chartArea4);
            this.graphsPane.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.graphsPane.Legends.Add(legend4);
            this.graphsPane.Location = new System.Drawing.Point(0, 30);
            this.graphsPane.Name = "graphsPane";
            this.graphsPane.Size = new System.Drawing.Size(586, 273);
            this.graphsPane.SuppressExceptions = true;
            this.graphsPane.TabIndex = 9;
            this.graphsPane.Visible = false;
            // 
            // LabWnd7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 486);
            this.Controls.Add(this.graphsPane);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.controlPanel);
            this.Name = "LabWnd7";
            this.controlPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.incrementPanel.ResumeLayout(false);
            this.incrementPanel.PerformLayout();
            this.limitPanel2.ResumeLayout(false);
            this.limitPanel2.PerformLayout();
            this.limitPanel1.ResumeLayout(false);
            this.limitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphsPane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView graphsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addGraphBtn;
        private System.Windows.Forms.Button deleteGraphsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel incrementPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox incrementBox;
        private System.Windows.Forms.Button buildGraphsBtn;
        private System.Windows.Forms.Panel limitPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rightLimitBox;
        private System.Windows.Forms.Panel limitPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox leftLimitBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private Chart graphsPane;
    }
}