namespace Test3
{
    partial class MainForm
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
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MinimumTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(12, 12);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(436, 26);
            this.DataTextBox.TabIndex = 0;
            // 
            // DataListBox
            // 
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.ItemHeight = 20;
            this.DataListBox.Location = new System.Drawing.Point(12, 44);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DataListBox.Size = new System.Drawing.Size(436, 304);
            this.DataListBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(128, 354);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(196, 35);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить значение";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Получить минимум";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinimumTextBox
            // 
            this.MinimumTextBox.Enabled = false;
            this.MinimumTextBox.Location = new System.Drawing.Point(214, 402);
            this.MinimumTextBox.Name = "MinimumTextBox";
            this.MinimumTextBox.ReadOnly = true;
            this.MinimumTextBox.Size = new System.Drawing.Size(234, 26);
            this.MinimumTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 445);
            this.Controls.Add(this.MinimumTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DataListBox);
            this.Controls.Add(this.DataTextBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.ListBox DataListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MinimumTextBox;
    }
}

