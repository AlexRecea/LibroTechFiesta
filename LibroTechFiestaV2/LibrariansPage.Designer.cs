namespace LibroTechFiestaV2
{
    partial class LibrariansPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrariansPage));
            this.booksList = new System.Windows.Forms.ListBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backToMainPageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booksList
            // 
            this.booksList.FormattingEnabled = true;
            this.booksList.ItemHeight = 17;
            this.booksList.Location = new System.Drawing.Point(12, 59);
            this.booksList.Name = "booksList";
            this.booksList.Size = new System.Drawing.Size(687, 378);
            this.booksList.TabIndex = 0;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available books";
            // 
            // searchBox
            // 
            this.searchBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.searchBox.Location = new System.Drawing.Point(819, 76);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 25);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search";
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.Enter += new System.EventHandler(this.SearchBoxText_Enter);
            this.searchBox.Leave += new System.EventHandler(this.SearchBoxText_Leave);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(998, 76);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 60);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // backToMainPageButton
            // 
            this.backToMainPageButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backToMainPageButton.Location = new System.Drawing.Point(941, 410);
            this.backToMainPageButton.Name = "backToMainPageButton";
            this.backToMainPageButton.Size = new System.Drawing.Size(151, 77);
            this.backToMainPageButton.TabIndex = 4;
            this.backToMainPageButton.Text = "Back to Main Page";
            this.backToMainPageButton.UseVisualStyleBackColor = true;
            this.backToMainPageButton.Click += new System.EventHandler(this.backToMainPageButton_Click);
            // 
            // LibrariansPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::LibroTechFiestaV2.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(1461, 697);
            this.Controls.Add(this.backToMainPageButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booksList);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibrariansPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox booksList;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backToMainPageButton;
    }
}