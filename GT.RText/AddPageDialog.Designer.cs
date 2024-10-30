namespace GT.RText
{
    partial class AddPageDialog
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
            this.applyToAllLocalesCheckBox = new System.Windows.Forms.CheckBox();
            this.pageNameTextBox = new System.Windows.Forms.TextBox();
            this.pageNameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // applyToAllLocalesCheckBox
            // 
            this.applyToAllLocalesCheckBox.AutoSize = true;
            this.applyToAllLocalesCheckBox.Location = new System.Drawing.Point(15, 52);
            this.applyToAllLocalesCheckBox.Name = "applyToAllLocalesCheckBox";
            this.applyToAllLocalesCheckBox.Size = new System.Drawing.Size(113, 17);
            this.applyToAllLocalesCheckBox.TabIndex = 0;
            this.applyToAllLocalesCheckBox.Text = "Apply to all locales";
            this.applyToAllLocalesCheckBox.UseVisualStyleBackColor = true;
            this.applyToAllLocalesCheckBox.CheckedChanged += new System.EventHandler(this.applyToAllLocalesCheckBox_CheckedChanged);
            // 
            // pageNameTextBox
            // 
            this.pageNameTextBox.Location = new System.Drawing.Point(12, 26);
            this.pageNameTextBox.Name = "pageNameTextBox";
            this.pageNameTextBox.Size = new System.Drawing.Size(325, 20);
            this.pageNameTextBox.TabIndex = 1;
            this.pageNameTextBox.TextChanged += new System.EventHandler(this.pageNameTextBox_TextChanged);
            // 
            // pageNameLabel
            // 
            this.pageNameLabel.AutoSize = true;
            this.pageNameLabel.Location = new System.Drawing.Point(12, 9);
            this.pageNameLabel.Name = "pageNameLabel";
            this.pageNameLabel.Size = new System.Drawing.Size(35, 13);
            this.pageNameLabel.TabIndex = 2;
            this.pageNameLabel.Text = "Name";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(252, 52);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddPageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 87);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pageNameLabel);
            this.Controls.Add(this.pageNameTextBox);
            this.Controls.Add(this.applyToAllLocalesCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPageDialog";
            this.Text = "Add page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox applyToAllLocalesCheckBox;
        private System.Windows.Forms.TextBox pageNameTextBox;
        private System.Windows.Forms.Label pageNameLabel;
        private System.Windows.Forms.Button addButton;
    }
}
