using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Массив добавленных чисел
        /// </summary>
        private readonly IList<double> _values;

        public MainForm()
        {
            _values = new List<double>();
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string textBoxValue = DataTextBox.Text;
            if (Double.TryParse(textBoxValue, out double value))
            {
                _values.Add(value);
                ChangeListBoxValues();
            }
            else
            {
                MessageBox.Show("Значение не является числом");
            }
        }

        private void ChangeListBoxValues()
        {
            DataListBox.Items.Clear();
            DataListBox.Items.AddRange(_values.Select(value => value.ToString()).
                                               ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataListBox.SelectedItems.Count > 0)
            {
                var values = DataListBox.SelectedItems.
                             OfType<string>().
                             Where(value => Double.TryParse(value, out double valueParse)).
                             Select(value => Double.Parse(value)).
                             Min();

                MinimumTextBox.Text = values.ToString();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            double ratio = (double)e.Y / (double)this.Height;
            int grayScaleRatio = 255 - (int)(255 * ratio);
            var color = Color.FromArgb(grayScaleRatio, grayScaleRatio, grayScaleRatio);
            this.BackColor = color;
        }
    }
}
