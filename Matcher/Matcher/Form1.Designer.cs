namespace Matcher
{
    partial class matcherForm
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
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.matchedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.matchedLabel = new System.Windows.Forms.Label();
            this.patternLabel = new System.Windows.Forms.Label();
            this.patternTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Location = new System.Drawing.Point(37, 46);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(290, 171);
            this.inputRichTextBox.TabIndex = 0;
            this.inputRichTextBox.Text = "";
            // 
            // matchedRichTextBox
            // 
            this.matchedRichTextBox.Enabled = false;
            this.matchedRichTextBox.Location = new System.Drawing.Point(367, 46);
            this.matchedRichTextBox.Name = "matchedRichTextBox";
            this.matchedRichTextBox.Size = new System.Drawing.Size(291, 171);
            this.matchedRichTextBox.TabIndex = 1;
            this.matchedRichTextBox.Text = "";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(34, 27);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(28, 13);
            this.textLabel.TabIndex = 2;
            this.textLabel.Text = "Text";
            // 
            // matchedLabel
            // 
            this.matchedLabel.AutoSize = true;
            this.matchedLabel.Location = new System.Drawing.Point(364, 27);
            this.matchedLabel.Name = "matchedLabel";
            this.matchedLabel.Size = new System.Drawing.Size(49, 13);
            this.matchedLabel.TabIndex = 3;
            this.matchedLabel.Text = "Matched";
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Location = new System.Drawing.Point(76, 250);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(41, 13);
            this.patternLabel.TabIndex = 4;
            this.patternLabel.Text = "Pattern";
            // 
            // patternTextBox
            // 
            this.patternTextBox.Location = new System.Drawing.Point(123, 250);
            this.patternTextBox.Name = "patternTextBox";
            this.patternTextBox.Size = new System.Drawing.Size(204, 20);
            this.patternTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(367, 250);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // matcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 298);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.patternTextBox);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.matchedLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.matchedRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Name = "matcherForm";
            this.Text = "Matcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RichTextBox matchedRichTextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label matchedLabel;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.TextBox patternTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

