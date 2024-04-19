using System.Windows.Forms;

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
            this.newBookTitle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.newBookTitle.Location = new System.Drawing.Point(326, 136);
            this.newBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.newBookTitle.Name = "newBookTitle";
            this.newBookTitle.Size = new System.Drawing.Size(236, 22);
            this.newBookTitle.TabIndex = 0;
            this.newBookTitle.Text = "Title";
            this.newBookTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newBookTitle.Enter += new System.EventHandler(this.newBookTitle_Enter);
            this.newBookTitle.Leave += new System.EventHandler(this.newBookTitle_Leave);
            // 
            // newBookAuthor
            // 
            this.newBookAuthor.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.newBookAuthor.Location = new System.Drawing.Point(326, 207);
            this.newBookAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.newBookAuthor.Name = "newBookAuthor";
            this.newBookAuthor.Size = new System.Drawing.Size(236, 22);
            this.newBookAuthor.TabIndex = 1;
            this.newBookAuthor.Text = "Author";
            this.newBookAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newBookAuthor.Enter += new System.EventHandler(this.newBookAuthor_Enter);
            this.newBookAuthor.Leave += new System.EventHandler(this.newBookAuthor_Leave);
            // 
            // newBookQuantity
            // 
            this.newBookQuantity.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.newBookQuantity.Location = new System.Drawing.Point(383, 270);
            this.newBookQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.newBookQuantity.Name = "newBookQuantity";
            this.newBookQuantity.Size = new System.Drawing.Size(115, 22);
            this.newBookQuantity.TabIndex = 2;
            this.newBookQuantity.Text = "Quantity";
            this.newBookQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newBookQuantity.Enter += new System.EventHandler(this.newBookQuantity_Enter);
            this.newBookQuantity.Leave += new System.EventHandler(this.newBookQuantity_Leave);
            // 
            // addNewBookButton
            // 
            this.addNewBookButton.Location = new System.Drawing.Point(402, 350);
            this.addNewBookButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewBookButton.Name = "addNewBookButton";
            this.addNewBookButton.Size = new System.Drawing.Size(79, 28);
            this.addNewBookButton.TabIndex = 3;
            this.addNewBookButton.Text = "Add";
            this.addNewBookButton.UseVisualStyleBackColor = true;
            this.addNewBookButton.Click += new System.EventHandler(this.addNewBookButton_Click);
            // 
            // AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibroTechFiestaV2.Properties.Resources.backgroundAdd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 543);
            this.Controls.Add(this.addNewBookButton);
            this.Controls.Add(this.newBookQuantity);
            this.Controls.Add(this.newBookAuthor);
            this.Controls.Add(this.newBookTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewBook";
            this.Text = "Add a New Book";
            this.Load += new System.EventHandler(this.AddNewBook_Load);
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