using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace ProgrammingLab.Labs.Lab2
{
    public partial class LabWnd2 : Form
    {
        public LabWnd2()
        {
            InitializeComponent();
        }

        private struct RequestData
        {

            public Point A { get; set; }
            public Point B { get; set; }
            public Point C { get; set; }
            public Point D { get; set; }

            public struct Point
            {

                public Point(double X, double Y)
                {
                    this.X = X;
                    this.Y = Y;
                }
                
                public double X { get; set; }
                public double Y { get; set; }
            }
            
        }
        
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        private void Execute(RequestData requestData)
        {

            if (PointsAreEquals(requestData.A, requestData.D))
            {
                PointsAreEqualsSignal(
                    nameof(requestData.A),
                    nameof(requestData.D)
                );
            }
            else if (PointsAreEquals(requestData.B, requestData.D))
            {
                PointsAreEqualsSignal(
                    nameof(requestData.B),
                    nameof(requestData.D)
                );
            }
            else if (PointsAreEquals(requestData.C, requestData.D))
            {
                PointsAreEqualsSignal(
                    nameof(requestData.C),
                    nameof(requestData.D)
                );
            }
            else if (PointIsOnLine(requestData.D, requestData.A, requestData.B))
            {
                PointIsOnLineSignal(
                    nameof(requestData.D),
                    nameof(requestData.A) + nameof(requestData.B)
                );
            }
            else if (PointIsOnLine(requestData.D, requestData.B, requestData.C))
            {
                PointIsOnLineSignal(
                    nameof(requestData.D),
                    nameof(requestData.B) + nameof(requestData.C)
                );
            }
            else if (PointIsOnLine(requestData.D, requestData.A, requestData.C))
            {
                PointIsOnLineSignal(
                    nameof(requestData.D),
                    nameof(requestData.A) + nameof(requestData.C)
                );
            }
            else if (CheckTriangles())
            {
                MessageBox.Show(
                    $"Точка D знаходиться у площі трикутника!",
                    "Результат обчислення",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    $"Точка D знаходиться зовні площі трикутника!",
                    "Результат обчислення",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            
            void PointsAreEqualsSignal(string first, string second)
            {
                MessageBox.Show(
                    $"Точки {first} і {second} співпадають!",
                    "Результат обчислення",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            bool PointsAreEquals(RequestData.Point first, RequestData.Point second)
            {

                Console.WriteLine("Checking whether points with hashcodes " + first.GetHashCode() + " and " + second.GetHashCode() + " are equals...");

                return first.X == second.X && first.Y == second.Y;

            }
            
            void PointIsOnLineSignal(string point, string line)
            {

                Console.WriteLine($"Point {point} is on line {line}!");

                MessageBox.Show(
                    $"Точка {point} знаходиться на відрізку {line}!",
                    "Результат обчислення",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
            
            bool PointIsOnLine(RequestData.Point point, RequestData.Point linePoint1, RequestData.Point linePoint2)
            {

                Console.WriteLine($"Checking whether point with hashcode {point.GetHashCode()} is on line {linePoint1.GetHashCode() + linePoint2.GetHashCode()}...");

                var lengthOfLine = Math.Sqrt(
                    Math.Pow(linePoint2.X - linePoint1.X, 2) + Math.Pow(linePoint2.Y - linePoint1.Y, 2)
                );
                
                var lengthOfSubLine1 = Math.Sqrt(
                    Math.Pow(point.X - linePoint1.X, 2) + Math.Pow(point.Y - linePoint1.Y, 2)
                );
                var lengthOfSubLine2 = Math.Sqrt(
                    Math.Pow(point.X - linePoint2.X, 2) + Math.Pow(point.Y - linePoint2.Y, 2)
                );
                
                return Math.Round(lengthOfLine) >= Math.Round(lengthOfSubLine1 + lengthOfSubLine2);
                
            }
            
            bool CheckTriangles()
            {

                double aLength, bLength, cLength;
                double adLength, bdLength, cdLength;

                double halfPerimeterPrime;
                double halfPerimeter1, halfPerimeter2, halfPerimeter3;

                double primeArea;
                double subArea1, subArea2, subArea3;
                
                aLength = Math.Sqrt(
                    Math.Pow(requestData.B.X - requestData.A.X, 2) + Math.Pow(requestData.B.Y - requestData.A.Y, 2)
                );
                bLength = Math.Sqrt(
                    Math.Pow(requestData.C.X - requestData.B.X, 2) + Math.Pow(requestData.C.Y - requestData.B.Y, 2)
                );
                cLength = Math.Sqrt(
                    Math.Pow(requestData.A.X - requestData.C.X, 2) + Math.Pow(requestData.A.Y - requestData.C.Y, 2)
                );
                
                adLength = Math.Sqrt(
                    Math.Pow(requestData.D.X - requestData.A.X, 2) + Math.Pow(requestData.D.Y - requestData.A.Y, 2)
                );
                bdLength = Math.Sqrt(
                    Math.Pow(requestData.D.X - requestData.B.X, 2) + Math.Pow(requestData.D.Y - requestData.B.Y, 2)
                );
                cdLength = Math.Sqrt(
                    Math.Pow(requestData.D.X - requestData.C.X, 2) + Math.Pow(requestData.D.Y - requestData.C.Y, 2)
                );

                halfPerimeterPrime = (aLength + bLength + cLength) / 2;
                halfPerimeter1 = ( adLength + bdLength + aLength ) / 2;
                halfPerimeter2 = ( bdLength + cdLength + bLength ) / 2;
                halfPerimeter3 = ( adLength + cdLength + cLength ) / 2;

                primeArea = Math.Sqrt(
                    halfPerimeterPrime
                    * (halfPerimeterPrime - aLength)
                    * (halfPerimeterPrime - bLength)
                    * (halfPerimeterPrime - cLength)
                );

                subArea1 = Math.Sqrt(
                    halfPerimeter1
                    * (halfPerimeter1 - adLength)
                    * (halfPerimeter1 - bdLength)
                    * (halfPerimeter1 - aLength)
                );

                subArea2 = Math.Sqrt(
                    halfPerimeter2
                    * (halfPerimeter2 - bdLength)
                    * (halfPerimeter2 - cdLength)
                    * (halfPerimeter2 - bLength)
                );

                subArea3 = Math.Sqrt(
                    halfPerimeter3
                    * (halfPerimeter3 - adLength)
                    * (halfPerimeter3 - cdLength)
                    * (halfPerimeter3 - cLength)
                );

                return (subArea1 + subArea2 + subArea3) <= primeArea;

            }
            
        }
        
        private void executeBtn_Click(object sender, EventArgs e)
        {

            this.Enabled = false;

            try
            {
                Execute(new RequestData
                {
                    A = new RequestData.Point(
                        Convert.ToDouble(TextBoxX1.Text),
                        Convert.ToDouble(TextBoxY1.Text)
                    ),
                    B = new RequestData.Point(
                        Convert.ToDouble(TextBoxX2.Text), Convert.ToDouble(TextBoxY2.Text)
                    ),
                    C = new RequestData.Point(
                        Convert.ToDouble(TextBoxX3.Text), Convert.ToDouble(TextBoxY3.Text)
                    ),
                    D = new RequestData.Point(
                        Convert.ToDouble(TextBoxX4.Text), Convert.ToDouble(TextBoxY4.Text)
                    )
                });
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Вказані координати не є дійсними!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Вказані координати виходять за межі можливостей для обчислення цієї програми!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Виникла виключна ситуація!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            
            this.Enabled = true;

        }
    }
}