using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var dataItems = new List<string>()
            {
                "1",
                "3,4,5",
                "0,1,2,3,4,5,6,7,8,9",
                "0,2,5,7,9",
            };

            DataListBox.Items.AddRange(dataItems.ToArray());
        }

        /// <summary>
        /// Получить количество строк, содержащих множество
        /// </summary>
        /// <returns></returns>
        private int GetSequenceCount()
        {

            var charsSequence = new List<char>() { '0', '2', '5', '7', '9' };
            return DataListBox.Items.OfType<string>().
                   Where(item => charsSequence.All(charToContain => item.ToLower().Contains(charToContain))).
                   Count();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetSequenceCount().ToString();
        }
    }
}
