using System;
using System.Windows.Forms;

namespace Lab6_2
{

    public partial class LabWnd6_2 : Form
    {

        public LabWnd6_2()
        {
            InitializeComponent();
        }

        private void LabWnd6_2_Load(object sender, EventArgs e)
        {
            rowsCountInputBox_ValueChanged(null, null);
        }

        private void rowsCountInputBox_ValueChanged(object sender, EventArgs e)
        {

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            for (var i = 0; i < Convert.ToInt32(rowsCountInputBox.Value) + 1; i++)
            {
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DisplayIndex = i,
                    CellTemplate = new DataGridViewTextBoxCell(),
                    ValueType = typeof(int)
                });
            }

            dataGridView.Rows.Add(Convert.ToInt32(rowsCountInputBox.Value));

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            rowsCountInputBox.Value = 2;
            rowsCountInputBox_ValueChanged(null, null);

        }

        private void executeBtn_Click(object sender, EventArgs e)
        {

            try
            {

                var rowsCount = Convert.ToInt32(rowsCountInputBox.Value);
                var dataArray = new int[rowsCount][];
                var aArray = new double[rowsCount, rowsCount];
                var bArray = new double[rowsCount];

                for (var i = 0; i < rowsCount; i++)
                {

                    dataArray[i] = new int[rowsCount + 1];

                    for (var j = 0; j < rowsCount + 1; j++)
                    {

                        dataArray[i][j] = (int) dataGridView.Rows[i].Cells[j].Value;

                        if (j < rowsCount)
                        {
                            aArray[i, j] = Convert.ToDouble((int) dataGridView.Rows[i].Cells[j].Value);
                        }
                        else
                        {
                            bArray[i] = Convert.ToDouble((int) dataGridView.Rows[i].Cells[j].Value);
                        }

                    }

                }

                double[] resultArray;

                if (gaussMethod.Checked)
                {
                    resultArray = new Gauss(aArray, bArray, 0.0001).Solve();
                }
                else if (cramerMethod.Checked)
                {
                    resultArray = Cramer.Solve(dataArray);
                }
                else
                {
                    throw new NotImplementedException();
                }

                MessageBox.Show(
                    "Вказана вами система лінійних алгебраїчних рівнянь має такі розв'язки:\r\n" +
                    string.Join(", ", resultArray) + "\r\nДякуємо за використання цієї підпрограми!",
                    "Результат роботи програми",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);

                MessageBox.Show(ex.Message, "EXCEPTION CATCHED!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }

}
