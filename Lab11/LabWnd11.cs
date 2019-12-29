using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace Lab11
{

    public partial class LabWnd11 : Form
    {

        public LabWnd11()
        {
            InitializeComponent();
        }

        private void LabWnd11_Load(object sender, EventArgs e)
        {

            new WelcomeWnd().ShowDialog(this);

            foreach (DefiniteIntegral.ApproximationMethod enumItem in Enum.GetValues(typeof(DefiniteIntegral.ApproximationMethod)))
            {

                integrationMethodSelectBox.Items.Add(enumItem.ToString().ToUpper());

            }

            integrationMethodSelectBox.SelectedIndex = 0;

        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            new WelcomeWnd().ShowDialog(this);
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {

            try
            {

                using (var provider = new CSharpCodeProvider())
                {

                    Console.WriteLine("Subprocess source code generation started!");

                    var code =
                        $"public class DefiniteIntegral {{ public static double FExec(double x) {{ return {formulaInputBox.Text.Replace("Math", "System.Math")}; }} }}";

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

                    var classType = compilerResults.CompiledAssembly.GetType("DefiniteIntegral");
                    var method = classType.GetMethod("FExec", BindingFlags.Static | BindingFlags.Public);

                    var definiteIntegralCalculator = new DefiniteIntegral()
                    {
                        Domain = new DefiniteIntegral.Interval(
                            Convert.ToDouble(bottomLimitInputBox.Value),
                            Convert.ToDouble(topLimitInputBox.Value)
                        ),
                        Integrand = (x) => (double) (method.Invoke(null, new object[] {x}))

                    };

                    var result = definiteIntegralCalculator.Approximate(
                        (DefiniteIntegral.ApproximationMethod) Enum.Parse(
                            typeof(DefiniteIntegral.ApproximationMethod),
                            integrationMethodSelectBox.Text,
                            true
                        ),
                        Convert.ToInt32(subDomainsInputBox.Value)
                    );

                    MessageBox.Show(
                        "Приблизний результат обчислень: " + result,
                        "Результат роботи програми",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    ex.Message,
                    "Виникла помилка при спробі приблизного обчислення визначеного інтегралу!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            }

        }

    }

}
