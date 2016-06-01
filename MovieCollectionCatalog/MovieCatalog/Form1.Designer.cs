namespace MovieCatalog
{
    partial class movieCollectionCatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movieCollectionCatalogForm));
            this.btnAddAsNew = new System.Windows.Forms.Button();
            this.btnOverwrite = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.videoFormatComboBox = new System.Windows.Forms.ComboBox();
            this.videoFormatLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextbox = new System.Windows.Forms.TextBox();
            this.premierYearLabel = new System.Windows.Forms.Label();
            this.premiereYearTextbox = new System.Windows.Forms.TextBox();
            this.hungarianTitleLabel = new System.Windows.Forms.Label();
            this.hungarianTitleTextbox = new System.Windows.Forms.TextBox();
            this.originalTitleLabel = new System.Windows.Forms.Label();
            this.originalTitleTextbox = new System.Windows.Forms.TextBox();
            this.moviesListView = new System.Windows.Forms.ListView();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAsNew
            // 
            this.btnAddAsNew.Location = new System.Drawing.Point(96, 323);
            this.btnAddAsNew.Name = "btnAddAsNew";
            this.btnAddAsNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddAsNew.TabIndex = 9;
            this.btnAddAsNew.Text = "Add as New";
            this.btnAddAsNew.UseVisualStyleBackColor = true;
            this.btnAddAsNew.Click += new System.EventHandler(this.btnAddAsNew_Click);
            // 
            // btnOverwrite
            // 
            this.btnOverwrite.Location = new System.Drawing.Point(177, 323);
            this.btnOverwrite.Name = "btnOverwrite";
            this.btnOverwrite.Size = new System.Drawing.Size(75, 23);
            this.btnOverwrite.TabIndex = 10;
            this.btnOverwrite.Text = "Overwrite";
            this.btnOverwrite.UseVisualStyleBackColor = true;
            this.btnOverwrite.Click += new System.EventHandler(this.btnOverwrite_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(258, 323);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Search:";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(109, 208);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(288, 20);
            this.searchTextbox.TabIndex = 7;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // videoFormatComboBox
            // 
            this.videoFormatComboBox.FormattingEnabled = true;
            this.videoFormatComboBox.Items.AddRange(new object[] {
            "VHS",
            "VCD",
            "DVD",
            "Blu-Ray"});
            this.videoFormatComboBox.Location = new System.Drawing.Point(284, 86);
            this.videoFormatComboBox.Name = "videoFormatComboBox";
            this.videoFormatComboBox.Size = new System.Drawing.Size(113, 21);
            this.videoFormatComboBox.TabIndex = 22;
            // 
            // videoFormatLabel
            // 
            this.videoFormatLabel.AutoSize = true;
            this.videoFormatLabel.Location = new System.Drawing.Point(209, 89);
            this.videoFormatLabel.Name = "videoFormatLabel";
            this.videoFormatLabel.Size = new System.Drawing.Size(69, 13);
            this.videoFormatLabel.TabIndex = 21;
            this.videoFormatLabel.Text = "Video format:";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(24, 119);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(38, 13);
            this.notesLabel.TabIndex = 14;
            this.notesLabel.Text = "Notes:";
            // 
            // notesTextbox
            // 
            this.notesTextbox.Location = new System.Drawing.Point(109, 112);
            this.notesTextbox.Multiline = true;
            this.notesTextbox.Name = "notesTextbox";
            this.notesTextbox.Size = new System.Drawing.Size(288, 62);
            this.notesTextbox.TabIndex = 20;
            // 
            // premierYearLabel
            // 
            this.premierYearLabel.AutoSize = true;
            this.premierYearLabel.Location = new System.Drawing.Point(24, 89);
            this.premierYearLabel.Name = "premierYearLabel";
            this.premierYearLabel.Size = new System.Drawing.Size(74, 13);
            this.premierYearLabel.TabIndex = 15;
            this.premierYearLabel.Text = "Premiere year:";
            // 
            // premiereYearTextbox
            // 
            this.premiereYearTextbox.Location = new System.Drawing.Point(109, 86);
            this.premiereYearTextbox.Name = "premiereYearTextbox";
            this.premiereYearTextbox.Size = new System.Drawing.Size(57, 20);
            this.premiereYearTextbox.TabIndex = 19;
            // 
            // hungarianTitleLabel
            // 
            this.hungarianTitleLabel.AutoSize = true;
            this.hungarianTitleLabel.Location = new System.Drawing.Point(24, 60);
            this.hungarianTitleLabel.Name = "hungarianTitleLabel";
            this.hungarianTitleLabel.Size = new System.Drawing.Size(78, 13);
            this.hungarianTitleLabel.TabIndex = 16;
            this.hungarianTitleLabel.Text = "Hungarian title:";
            // 
            // hungarianTitleTextbox
            // 
            this.hungarianTitleTextbox.Location = new System.Drawing.Point(109, 57);
            this.hungarianTitleTextbox.Name = "hungarianTitleTextbox";
            this.hungarianTitleTextbox.Size = new System.Drawing.Size(288, 20);
            this.hungarianTitleTextbox.TabIndex = 17;
            // 
            // originalTitleLabel
            // 
            this.originalTitleLabel.AutoSize = true;
            this.originalTitleLabel.Location = new System.Drawing.Point(24, 33);
            this.originalTitleLabel.Name = "originalTitleLabel";
            this.originalTitleLabel.Size = new System.Drawing.Size(64, 13);
            this.originalTitleLabel.TabIndex = 18;
            this.originalTitleLabel.Text = "Original title:";
            // 
            // originalTitleTextbox
            // 
            this.originalTitleTextbox.Location = new System.Drawing.Point(109, 30);
            this.originalTitleTextbox.Name = "originalTitleTextbox";
            this.originalTitleTextbox.Size = new System.Drawing.Size(288, 20);
            this.originalTitleTextbox.TabIndex = 13;
            // 
            // moviesListView
            // 
            this.moviesListView.Location = new System.Drawing.Point(27, 245);
            this.moviesListView.Name = "moviesListView";
            this.moviesListView.Size = new System.Drawing.Size(370, 60);
            this.moviesListView.TabIndex = 23;
            this.moviesListView.UseCompatibleStateImageBehavior = false;
            this.moviesListView.View = System.Windows.Forms.View.List;
            this.moviesListView.SelectedIndexChanged += new System.EventHandler(this.moviesListView_SelectedIndexChanged);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Enabled = false;
            this.saveToFileButton.Location = new System.Drawing.Point(339, 323);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(75, 23);
            this.saveToFileButton.TabIndex = 24;
            this.saveToFileButton.Text = "Save to File";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(13, 323);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(75, 23);
            this.btnClearFields.TabIndex = 26;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // movieCollectionCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(426, 354);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.moviesListView);
            this.Controls.Add(this.videoFormatComboBox);
            this.Controls.Add(this.videoFormatLabel);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.notesTextbox);
            this.Controls.Add(this.premierYearLabel);
            this.Controls.Add(this.premiereYearTextbox);
            this.Controls.Add(this.hungarianTitleLabel);
            this.Controls.Add(this.hungarianTitleTextbox);
            this.Controls.Add(this.originalTitleLabel);
            this.Controls.Add(this.originalTitleTextbox);
            this.Controls.Add(this.btnAddAsNew);
            this.Controls.Add(this.btnOverwrite);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "movieCollectionCatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Collection Catalog";
            this.Load += new System.EventHandler(this.movieCollectionCatalogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddAsNew;
        private System.Windows.Forms.Button btnOverwrite;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.ComboBox videoFormatComboBox;
        private System.Windows.Forms.Label videoFormatLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTextbox;
        private System.Windows.Forms.Label premierYearLabel;
        private System.Windows.Forms.TextBox premiereYearTextbox;
        private System.Windows.Forms.Label hungarianTitleLabel;
        private System.Windows.Forms.TextBox hungarianTitleTextbox;
        private System.Windows.Forms.Label originalTitleLabel;
        private System.Windows.Forms.TextBox originalTitleTextbox;
        private System.Windows.Forms.ListView moviesListView;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.Button btnClearFields;
    }
}

