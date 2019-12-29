using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.CSharp;

namespace ProgrammingLab.Labs.Lab7
{

    public partial class LabWnd7 : Form
    {

        public LabWnd7()
        {

            Console.WriteLine("Executing InitializeComponent()!");

            InitializeComponent();

            Console.WriteLine("InitializeComponent() execution succeed!");

        }

        private void deleteGraphsBtn_Click(object sender, System.EventArgs e)
        {

            Console.WriteLine("Performing graphs removal...");

            this.Enabled = false;

            foreach (ListViewItem checkedItem in graphsList.CheckedItems)
            {

                Console.WriteLine("Removing graph " + checkedItem.Name);

                graphsList.Items.Remove(checkedItem);

            }

            graphsList.Refresh();

            this.Enabled = true;

            Console.WriteLine("Graphs removal action finished!");

        }

        private void addGraphBtn_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Opening graph creation wizard...");

            _ = new AddGraphDialog(ref graphsList).ShowDialog(this);

            Console.WriteLine("Graph creation wizard finished!");

        }

        private void buildGraphsBtn_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Performing security checks before graphs drawing engine init...");

            if (Convert.ToDouble(leftLimitBox.Text) >= Convert.ToDouble(rightLimitBox.Text))
            {

                Console.WriteLine("LEFT AND RIGHTS LIMITS ERROR");

                MessageBox.Show(
                    "Ліва границя не може бути менше чи дорівнювати правій границі!",
                    "Неправильний формат даних!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;

            }

            if (Convert.ToDouble(incrementBox.Text) <= 0)
            {

                Console.WriteLine("INCREMENT ERROR");

                MessageBox.Show(
                    "Інкремент не може бути меншим чи дорівнювати 0!",
                    "Неправильний формат даних!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;

            }

            graphsPane.Visible = true;
            controlPanel.Enabled = false;

            try
            {

                Console.WriteLine("Initializing graphs building/drawing engine...");

                ExecuteBuild();

                Console.WriteLine("Graphs building engine finished their work!");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Unhandled exception catched: " + ex.Message);

                MessageBox.Show(
                    ex.Message,
                    "Виникла критична помилка при побудові графіків!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            }

            controlPanel.Enabled = true;

        }

        private void ExecuteBuild()
        {

            Console.WriteLine("Cleaning old graphs pane series...");

            graphsPane.Series.Clear();

            Console.WriteLine("Drawing process initialization");

            foreach (ListViewItem item in graphsList.CheckedItems)
            {

                Console.WriteLine("Progress bar initialization started!");

                progressBar.Visible = true;
                progressBar.Maximum = Convert.ToInt32(
                    Math.Round(
                        (Math.Abs(Convert.ToDouble(rightLimitBox.Text)) + Math.Abs(Convert.ToDouble(leftLimitBox.Text))) / Convert.ToDouble(incrementBox.Text)
                    )
                );

                progressBar.Step = 1;
                progressBar.Value = 0;

                Console.WriteLine("Progress bar initialization finished!");

                var seriesName = "y = " + item.Text;

                Console.WriteLine("NOW BUILDING GRAPH " + seriesName.ToUpper());

                var itemSeries = new Series(seriesName)
                {
                    ChartType = SeriesChartType.Spline,
                    Color = item.BackColor != Color.White ? item.BackColor : Color.Black
                };

                graphsPane.Series.Add(itemSeries);

                itemSeries = graphsPane.Series.FindByName(seriesName) ?? throw new ArgumentNullException("itemSeries");

                Console.WriteLine("CSharpCodeProvider initialization...");

                using (var provider = new CSharpCodeProvider())
                {

                    Console.WriteLine("Subprocess source code generation started!");

                    var code = $"public class GraphBuilder {{ public static double Build(double x) {{ return {item.Text.Replace("Math", "System.Math")}; }} }}";

                    Console.WriteLine("Subprocess source code generation finished!");

                    Console.WriteLine("Subprocess source code: " + code);

                    Console.WriteLine("Setting up C# compiler (Roslyn-based)...");

                    var options = new CompilerParameters
                    {
                        GenerateExecutable = false,
                        GenerateInMemory = true
                    };

                    options.ReferencedAssemblies.Add("System.dll");

                    var compilerResults = provider.CompileAssemblyFromSource(options, code);

                    var classType = compilerResults.CompiledAssembly.GetType("GraphBuilder");
                    var method = classType.GetMethod("Build", BindingFlags.Static | BindingFlags.Public);

                    Console.WriteLine("Graph build process starts NOW!");

                    for (var x = Convert.ToDouble(leftLimitBox.Text);
                        x <= Convert.ToDouble(rightLimitBox.Text);
                        x += Convert.ToDouble(incrementBox.Text))
                    {

                        Console.WriteLine("Building point for X = " + x + ":");

                        try
                        {

                            Console.WriteLine("Invoking subprocess and getting RAW Y data...");

                            var rawY = method.Invoke(null, new object[] {x});

                            Console.WriteLine("RAW Y FOR POINT X = " + x + " IS " + rawY.GetHashCode() + "!");

                            Console.WriteLine("Point verification process started!");

                            if (rawY != null)
                            {

                                Console.WriteLine("Retrieving normalized Y...");

                                var y = (double) rawY;

                                Console.WriteLine("NORMALIZED Y WITH DOUBLE PRECISION FOR X = " + x + " IS " + y + "!");

                                Console.WriteLine("Creating a point on graph...");

                                itemSeries.Points.AddXY(x, y);

                                Console.WriteLine("Point successfully created!");

                                Console.WriteLine("Updating graphs pane...");

                                graphsPane.Update();

                                Console.WriteLine("Graphs pane was successfully updated.");

                            }

                            Console.WriteLine("Point verification process finalized!");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Non-critical exception in " + ex.Source + " catched (" + ex.HResult + ")! Details: " + ex.Message);
                        }

                        Console.WriteLine("Performing progress bar step...");

                        progressBar.PerformStep();

                    }

                    Console.WriteLine("Current graph built successfully!");

                }

                Console.WriteLine("CSharpCodeProvider disposal succeed!");

                progressBar.Visible = false;

            }

        }

    }

}