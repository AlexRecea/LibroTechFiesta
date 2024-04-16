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
            this.SuspendLayout();
            // 
            // bookListClients
            // 
            this.bookListClients.HideSelection = false;
            this.bookListClients.Location = new System.Drawing.Point(44, 42);
            this.bookListClients.Name = "bookListClients";
            this.bookListClients.Size = new System.Drawing.Size(400, 227);
            this.bookListClients.TabIndex = 0;
            this.bookListClients.UseCompatibleStateImageBehavior = false;
            // 
            // loanButton
            // 
            this.loanButton.Location = new System.Drawing.Point(594, 111);
            this.loanButton.Name = "loanButton";
            this.loanButton.Size = new System.Drawing.Size(75, 23);
            this.loanButton.TabIndex = 1;
            this.loanButton.Text = "Loan";
            this.loanButton.UseVisualStyleBackColor = true;
            // 
            // ClientsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loanButton);
            this.Controls.Add(this.bookListClients);
            this.Name = "ClientsPage";
            this.Text = "ClientsPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView bookListClients;
        private System.Windows.Forms.Button loanButton;
    }
}