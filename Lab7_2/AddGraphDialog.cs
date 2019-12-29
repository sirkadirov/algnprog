using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingLab.Labs.Lab7
{
    public partial class AddGraphDialog : Form
    {

        private readonly ListView graphsList;

        public AddGraphDialog(ref ListView graphsList)
        {
            InitializeComponent();
            this.graphsList = graphsList;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {

            if (graphTextBox.TextLength <= 0)
            {
                MessageBox.Show(
                    "Формулу не задано!",
                    "Виникла помилка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;

            }

            if (graphsList.Items.IndexOfKey(graphTextBox.Text) >= 0)
            {

                MessageBox.Show(
                    "Ця формула вже присутня у списку!",
                    "Виникла помилка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;

            }

            graphsList.Items.Add(new ListViewItem
            {
                BackColor = colorDialog.Color,
                Checked = true,
                Focused = true,
                Text = graphTextBox.Text,
                SubItems = { colorDialog.Color.ToString() }
            });
            
            graphsList.Refresh();

            this.Close();

        }

        private void colorDialogBtn_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog(this);
        }
    }
}
