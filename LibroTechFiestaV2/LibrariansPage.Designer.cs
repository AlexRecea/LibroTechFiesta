﻿namespace LibroTechFiestaV2
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backToMainPageButton = new System.Windows.Forms.Button();
            this.booksView = new System.Windows.Forms.ListView();
            this.addNewBook = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // searchBox
            // 
            this.searchBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.searchBox.Location = new System.Drawing.Point(1112, 50);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(220, 25);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search";
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.Enter += new System.EventHandler(this.SearchBoxText_Enter);
            this.searchBox.Leave += new System.EventHandler(this.SearchBoxText_Leave);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1185, 100);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(90, 60);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // backToMainPageButton
            // 
            this.backToMainPageButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backToMainPageButton.Location = new System.Drawing.Point(570, 500);
            this.backToMainPageButton.Name = "backToMainPageButton";
            this.backToMainPageButton.Size = new System.Drawing.Size(170, 80);
            this.backToMainPageButton.TabIndex = 4;
            this.backToMainPageButton.Text = "Back to Main Page";
            this.backToMainPageButton.UseVisualStyleBackColor = true;
            this.backToMainPageButton.Click += new System.EventHandler(this.backToMainPageButton_Click);
            // 
            // booksView
            // 
            this.booksView.FullRowSelect = true;
            this.booksView.HideSelection = false;
            this.booksView.Location = new System.Drawing.Point(20, 20);
            this.booksView.Name = "booksView";
            this.booksView.Size = new System.Drawing.Size(900, 400);
            this.booksView.TabIndex = 5;
            this.booksView.UseCompatibleStateImageBehavior = false;
            // 
            // addNewBook
            // 
            this.addNewBook.Location = new System.Drawing.Point(150, 500);
            this.addNewBook.Name = "addNewBook";
            this.addNewBook.Size = new System.Drawing.Size(170, 80);
            this.addNewBook.TabIndex = 6;
            this.addNewBook.Text = "Update Books";
            this.addNewBook.UseVisualStyleBackColor = true;
            this.addNewBook.Click += new System.EventHandler(this.addNewBook_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1000, 250);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(450, 350);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // buttonShow
            // 
            this.buttonShow.ForeColor = System.Drawing.Color.Black;
            this.buttonShow.Location = new System.Drawing.Point(1185, 650);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(90, 60);
            this.buttonShow.TabIndex = 8;
            this.buttonShow.Text = "Show Details";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // LibrariansPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::LibroTechFiestaV2.Properties.Resources.backgroundL;
            this.ClientSize = new System.Drawing.Size(1461, 697);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.addNewBook);
            this.Controls.Add(this.booksView);
            this.Controls.Add(this.backToMainPageButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibrariansPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrariansPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backToMainPageButton;
        private System.Windows.Forms.ListView booksView;
        private System.Windows.Forms.Button addNewBook;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonShow;
    }
}