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
            this.SuspendLayout();
            // 
            // bookListClients
            // 
            this.bookListClients.HideSelection = false;
            this.bookListClients.Location = new System.Drawing.Point(44, 42);
            this.bookListClients.Name = "bookListClients";
            this.bookListClients.Size = new System.Drawing.Size(680, 326);
            this.bookListClients.TabIndex = 5;
            this.bookListClients.UseCompatibleStateImageBehavior = false;
            // 
            // loanButton
            // 
            this.loanButton.Location = new System.Drawing.Point(806, 254);
            this.loanButton.Name = "loanButton";
            this.loanButton.Size = new System.Drawing.Size(75, 23);
            this.loanButton.TabIndex = 1;
            this.loanButton.Text = "Loan";
            this.loanButton.UseVisualStyleBackColor = true;
            this.loanButton.Click += new System.EventHandler(this.loanButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchBox.Location = new System.Drawing.Point(840, 33);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(162, 20);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search";
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.Enter += new System.EventHandler(this.SearchBoxText_Enter);
            this.searchBox.Leave += new System.EventHandler(this.SearchBoxText_Leave);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(888, 76);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(70, 49);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // booksOwned
            // 
            this.booksOwned.HideSelection = false;
            this.booksOwned.Location = new System.Drawing.Point(44, 471);
            this.booksOwned.Name = "booksOwned";
            this.booksOwned.Size = new System.Drawing.Size(525, 179);
            this.booksOwned.TabIndex = 6;
            this.booksOwned.UseCompatibleStateImageBehavior = false;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(736, 582);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(126, 44);
            this.returnButton.TabIndex = 7;
            this.returnButton.Text = "Return A Book";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // showLoanedButton
            // 
            this.showLoanedButton.Location = new System.Drawing.Point(736, 488);
            this.showLoanedButton.Name = "showLoanedButton";
            this.showLoanedButton.Size = new System.Drawing.Size(110, 38);
            this.showLoanedButton.TabIndex = 8;
            this.showLoanedButton.Text = "Show Loaned Books";
            this.showLoanedButton.UseVisualStyleBackColor = true;
            this.showLoanedButton.Click += new System.EventHandler(this.showLoanedButton_Click);
            // 
            // ClientsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibroTechFiestaV2.Properties.Resources.backgroundClient;
            this.ClientSize = new System.Drawing.Size(1171, 695);
            this.Controls.Add(this.showLoanedButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.booksOwned);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.loanButton);
            this.Controls.Add(this.bookListClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}