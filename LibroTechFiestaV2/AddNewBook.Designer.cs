namespace LibroTechFiestaV2
{
    partial class AddNewBook
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
            this.newBookTitle = new System.Windows.Forms.TextBox();
            this.newBookAuthor = new System.Windows.Forms.TextBox();
            this.newBookQuantity = new System.Windows.Forms.TextBox();
            this.addNewBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newBookTitle
            // 
            this.newBookTitle.Location = new System.Drawing.Point(328, 152);
            this.newBookTitle.Name = "newBookTitle";
            this.newBookTitle.Size = new System.Drawing.Size(178, 20);
            this.newBookTitle.TabIndex = 0;
            // 
            // newBookAuthor
            // 
            this.newBookAuthor.Location = new System.Drawing.Point(343, 224);
            this.newBookAuthor.Name = "newBookAuthor";
            this.newBookAuthor.Size = new System.Drawing.Size(138, 20);
            this.newBookAuthor.TabIndex = 1;
            // 
            // newBookQuantity
            // 
            this.newBookQuantity.Location = new System.Drawing.Point(358, 287);
            this.newBookQuantity.Name = "newBookQuantity";
            this.newBookQuantity.Size = new System.Drawing.Size(100, 20);
            this.newBookQuantity.TabIndex = 2;
            // 
            // addNewBookButton
            // 
            this.addNewBookButton.Location = new System.Drawing.Point(397, 353);
            this.addNewBookButton.Name = "addNewBookButton";
            this.addNewBookButton.Size = new System.Drawing.Size(75, 23);
            this.addNewBookButton.TabIndex = 3;
            this.addNewBookButton.Text = "button1";
            this.addNewBookButton.UseVisualStyleBackColor = true;
            this.addNewBookButton.Click += new System.EventHandler(this.addNewBookButton_Click);
            // 
            // AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewBookButton);
            this.Controls.Add(this.newBookQuantity);
            this.Controls.Add(this.newBookAuthor);
            this.Controls.Add(this.newBookTitle);
            this.Name = "AddNewBook";
            this.Text = "Add a New Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newBookTitle;
        private System.Windows.Forms.TextBox newBookAuthor;
        private System.Windows.Forms.TextBox newBookQuantity;
        private System.Windows.Forms.Button addNewBookButton;
    }
}