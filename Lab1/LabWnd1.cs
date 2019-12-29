using System;
using System.Windows.Forms;

namespace ProgrammingLab.Labs.Lab1
{
    public partial class LabWnd1 : Form
    {
        public LabWnd1()
        {
            InitializeComponent();
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {

            Console.WriteLine("ExecuteBtn button clicked! ExecuteBtn_Click() is being executed!");

            Console.WriteLine("Executing formulas...");

            this.Enabled = false;
            
            try
            {

                double a, b, c;
                double d;
                double x1, x2;

                a = Convert.ToDouble(InputBoxA.Text);
                b = Convert.ToDouble(InputBoxB.Text);
                c = Convert.ToDouble(InputBoxC.Text);

                d = Math.Pow(b, 2) - 4 * a * c;

                if (d < 0)
                {

                    MessageBox.Show(
                        "Дійсних коренів рівняння не має.",
                        "Результат обчислення",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                }
                // ReSharper disable once CompareOfFloatsByEqualityOperator
                else if (d == 0)
                {

                    x1 = (-b + Math.Sqrt(d)) / (2 * a);

                    MessageBox.Show(
                        $"Рівняння має два однакових корені (з точністю до трьох знаків після коми): x1 = x2 = {x1.ToString("F3")}.",
                        "Результат обчислення",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                }
                else if (d > 0)
                {

                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    MessageBox.Show(
                        $"Рівняння має два корені (з точністю до трьох знаків після коми): x1 = {x1.ToString("F3")}; x2 = {x2.ToString("F3")}.",
                        "Результат обчислення",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                }

            }
            catch (FormatException ex)
            {

                Console.WriteLine("FORMAT EXCEPTION CATCHED!");

                MessageBox.Show(
                    ex.Message,
                    "Ви ввели коефіцієнти в неправильному форматі!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );

            }
            catch (OverflowException ex)
            {

                Console.WriteLine("OVERFLOW EXCEPTION CATCHED!");

                MessageBox.Show(
                    ex.Message,
                    "Коефіцієнти виходять за підтримувані межі обчислень!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );

            }
            catch (Exception ex)
            {

                Console.WriteLine("Unhandled exception catched at " + ex.Source + " with HResult " + ex.HResult + ": " + ex.Message);

                MessageBox.Show(
                    ex.Message,
                    "При обчисленні результату виникла фатальна помилка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );

            }

            this.Enabled = true;

            Console.WriteLine("Execution succeed!");

        }
    }
}