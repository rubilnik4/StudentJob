using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test2.Encryption;

namespace Test2
{
    public partial class EncryptionForm : Form
    {
        /// <summary>
        /// Шифровка
        /// </summary>
        private EncryptionMessage _encryptionMessage;

        public EncryptionForm()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (OpenEncryptionDialog.ShowDialog() == DialogResult.OK)
            {
                var encryptionLines = File.ReadLines(OpenEncryptionDialog.FileName);
                _encryptionMessage = new EncryptionMessage(encryptionLines);
                ShowData(_encryptionMessage, DataType.Encrypted);
            }
        }

        private void ShowData(EncryptionMessage encryptionMessage, DataType dataType)
        {
            DataListBox.Items.Clear();
            if (dataType == DataType.Encrypted)
            {
                DataListBox.Items.AddRange(encryptionMessage.EncryptionLines.ToArray());
            }
            else
            {
                DataListBox.Items.AddRange(encryptionMessage.DecryptionLines.ToArray());
            }

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            ShowData(_encryptionMessage, DataType.Decrypted);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveEncryptionDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(SaveEncryptionDialog.FileName, _encryptionMessage.DecryptionLines);
            }
        }
    }
}
