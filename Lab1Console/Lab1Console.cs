using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginSystemLib;

namespace Lab1Console
{

    public class Lab1Console : PluginBase
    {

        public override string GetPluginName()
        {
            return "Знаходження коренів квадратних рівнянь (консольний варіант)";
        }

        public override void ExecutePlugin()
        {

            try
            {

                double a, b, c;
                double d;
                double x1, x2;

                Console.WriteLine("Ax^2+Bx+C=0");

                Console.Write("A = ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("B = ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("C = ");
                c = Convert.ToDouble(Console.ReadLine());

                d = Math.Pow(b, 2) - 4 * a * c;

                if (d < 0)
                {

                    Console.WriteLine("Non-complex results not found!");

                }
                // ReSharper disable once CompareOfFloatsByEqualityOperator
                else if (d == 0)
                {

                    x1 = (-b + Math.Sqrt(d)) / (2 * a);

                    Console.WriteLine($"Two results that are equals: x1 = x2 = {x1.ToString("F3")}.");

                }
                else if (d > 0)
                {

                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    Console.WriteLine($"Two results: x1 = {x1.ToString("F3")}; x2 = {x2.ToString("F3")}.");

                }

            }
            catch (FormatException ex)
            {

                Console.WriteLine("Format exception catched!");

            }
            catch (OverflowException ex)
            {

                Console.WriteLine("Owerflow exception!");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Unhandled exception catched at " + ex.Source + " with HResult " + ex.HResult + ": " + ex.Message);

            }

        }

    }

}
