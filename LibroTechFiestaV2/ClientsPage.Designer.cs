using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibroTechFiestaV2
{
    partial class ClientsPage
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
            this.bookListClients = new System.Windows.Forms.ListView();
            this.loanButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.booksOwned = new System.Windows.Forms.ListView();
            this.returnButton = new System.Windows.Forms.Button();
            this.showLoanedButton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookListClients
            // 
            this.bookListClients.FullRowSelect = true;
            this.bookListClients.HideSelection = false;
            this.bookListClients.Location = new System.Drawing.Point(20, 20);
            this.bookListClients.Margin = new System.Windows.Forms.Padding(4);
            this.bookListClients.Name = "bookListClients";
            this.bookListClients.Size = new System.Drawing.Size(900, 400);
            this.bookListClients.TabIndex = 5;
            this.bookListClients.UseCompatibleStateImageBehavior = false;
            // 
            // loanButton
            // 
            this.loanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanButton.Location = new System.Drawing.Point(800, 600);
            this.loanButton.Margin = new System.Windows.Forms.Padding(4);
            this.loanButton.Name = "loanButton";
            this.loanButton.Size = new System.Drawing.Size(100, 50);
            this.loanButton.TabIndex = 1;
            this.loanButton.Text = "Loan";
            this.loanButton.UseVisualStyleBackColor = true;
            this.loanButton.Click += new System.EventHandler(this.loanButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchBox.Location = new System.Drawing.Point(1050, 50);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(220, 22);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search";
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.Enter += new System.EventHandler(this.SearchBoxText_Enter);
            this.searchBox.Leave += new System.EventHandler(this.SearchBoxText_Leave);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(1094, 100);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 70);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // booksOwned
            // 
            this.booksOwned.FullRowSelect = true;
            this.booksOwned.HideSelection = false;
            this.booksOwned.Location = new System.Drawing.Point(20, 600);
            this.booksOwned.Margin = new System.Windows.Forms.Padding(4);
            this.booksOwned.Name = "booksOwned";
            this.booksOwned.Size = new System.Drawing.Size(700, 250);
            this.booksOwned.TabIndex = 6;
            this.booksOwned.UseCompatibleStateImageBehavior = false;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(800, 800);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(168, 54);
            this.returnButton.TabIndex = 7;
            this.returnButton.Text = "Return A Book";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // showLoanedButton
            // 
            this.showLoanedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLoanedButton.Location = new System.Drawing.Point(800, 700);
            this.showLoanedButton.Margin = new System.Windows.Forms.Padding(4);
            this.showLoanedButton.Name = "showLoanedButton";
            this.showLoanedButton.Size = new System.Drawing.Size(168, 47);
            this.showLoanedButton.TabIndex = 8;
            this.showLoanedButton.Text = "Show Loaned Books";
            this.showLoanedButton.UseVisualStyleBackColor = true;
            this.showLoanedButton.Click += new System.EventHandler(this.showLoanedButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1689, 767);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(139, 76);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back to Main Page";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(1400, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(600, 500);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(1094, 319);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(150, 70);
            this.showDetailsButton.TabIndex = 12;
            this.showDetailsButton.Text = "Show Details";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click_1);
            // 
            // ClientsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibroTechFiestaV2.Properties.Resources.backgroundC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1853, 855);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.showLoanedButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.booksOwned);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.loanButton);
            this.Controls.Add(this.bookListClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bookListClients;
        private System.Windows.Forms.Button loanButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView booksOwned;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button showLoanedButton;
        private System.Windows.Forms.Button buttonBack;
        private RichTextBox richTextBox1;
        private System.Windows.Forms.Button showDetailsButton;
    }
}