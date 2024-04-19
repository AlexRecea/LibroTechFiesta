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
            this.SuspendLayout();
            // 
            // bookListClients
            // 
            this.bookListClients.HideSelection = false;
            this.bookListClients.Location = new System.Drawing.Point(59, 52);
            this.bookListClients.Margin = new System.Windows.Forms.Padding(4);
            this.bookListClients.Name = "bookListClients";
            this.bookListClients.Size = new System.Drawing.Size(905, 400);
            this.bookListClients.TabIndex = 5;
            this.bookListClients.UseCompatibleStateImageBehavior = false;
            // 
            // loanButton
            // 
            this.loanButton.Location = new System.Drawing.Point(1000, 500);
            this.loanButton.Margin = new System.Windows.Forms.Padding(4);
            this.loanButton.Name = "loanButton";
            this.loanButton.Size = new System.Drawing.Size(100, 28);
            this.loanButton.TabIndex = 1;
            this.loanButton.Text = "Loan";
            this.loanButton.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchBox.Location = new System.Drawing.Point(1120, 41);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(215, 22);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search";
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.Enter += new System.EventHandler(this.SearchBoxText_Enter);
            this.searchBox.Leave += new System.EventHandler(this.SearchBoxText_Leave);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1184, 94);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 60);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ClientsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibroTechFiestaV2.Properties.Resources.backgroundClient;
            this.ClientSize = new System.Drawing.Size(1356, 760);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.loanButton);
            this.Controls.Add(this.bookListClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
    }
}