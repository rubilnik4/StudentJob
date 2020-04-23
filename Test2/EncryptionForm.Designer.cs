namespace Test2
{
    partial class EncryptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadButton = new System.Windows.Forms.Button();
            this.OpenEncryptionDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveEncryptionDialog = new System.Windows.Forms.SaveFileDialog();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(40, 208);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(186, 23);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // OpenEncryptionDialog
            // 
            this.OpenEncryptionDialog.DefaultExt = "txt";
            this.OpenEncryptionDialog.FileName = "encryptionData";
            this.OpenEncryptionDialog.Filter = "encryption|*.txt";
            // 
            // SaveEncryptionDialog
            // 
            this.SaveEncryptionDialog.DefaultExt = "txt";
            this.SaveEncryptionDialog.FileName = "decryptionData";
            this.SaveEncryptionDialog.Filter = "encryption|*.txt";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(40, 237);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(186, 23);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(40, 266);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(186, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DataListBox
            // 
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.Location = new System.Drawing.Point(12, 12);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(256, 186);
            this.DataListBox.TabIndex = 4;
            // 
            // EncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 296);
            this.Controls.Add(this.DataListBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.LoadButton);
            this.Name = "EncryptionForm";
            this.Text = "Дешифровка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.OpenFileDialog OpenEncryptionDialog;
        private System.Windows.Forms.SaveFileDialog SaveEncryptionDialog;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListBox DataListBox;
    }
}

