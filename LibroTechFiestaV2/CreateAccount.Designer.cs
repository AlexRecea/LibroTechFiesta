using System.Windows.Forms;

namespace LibroTechFiestaV2
{
    partial class CreateAccount
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
            this.newFirstNameText = new System.Windows.Forms.TextBox();
            this.newLastNameText = new System.Windows.Forms.TextBox();
            this.newEmailText = new System.Windows.Forms.TextBox();
            this.newPhoneNumberText = new System.Windows.Forms.TextBox();
            this.newPasswordText = new System.Windows.Forms.TextBox();
            this.createNewAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newFirstNameText
            // 
            this.newFirstNameText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.newFirstNameText.Location = new System.Drawing.Point(240, 93);
            this.newFirstNameText.Margin = new System.Windows.Forms.Padding(4);
            this.newFirstNameText.Name = "newFirstNameText";
            this.newFirstNameText.Size = new System.Drawing.Size(132, 22);
            this.newFirstNameText.TabIndex = 0;
            this.newFirstNameText.Text = "First Name";
            this.newFirstNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newFirstNameText.Enter += new System.EventHandler(this.newFirstNameText_Enter);
            this.newFirstNameText.Leave += new System.EventHandler(this.newFirstNameText_Leave);
            // 
            // newLastNameText
            // 
            this.newLastNameText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.newLastNameText.Location = new System.Drawing.Point(240, 161);
            this.newLastNameText.Margin = new System.Windows.Forms.Padding(4);
            this.newLastNameText.Name = "newLastNameText";
            this.newLastNameText.Size = new System.Drawing.Size(132, 22);
            this.newLastNameText.TabIndex = 1;
            this.newLastNameText.Text = "Last Name";
            this.newLastNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newLastNameText.Enter += new System.EventHandler(this.newLastNameText_Enter);
            this.newLastNameText.Leave += new System.EventHandler(this.newLastNameText_Leave);
            // 
            // newEmailText
            // 
            this.newEmailText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.newEmailText.Location = new System.Drawing.Point(240, 229);
            this.newEmailText.Margin = new System.Windows.Forms.Padding(4);
            this.newEmailText.Name = "newEmailText";
            this.newEmailText.Size = new System.Drawing.Size(132, 22);
            this.newEmailText.TabIndex = 2;
            this.newEmailText.Text = "email";
            this.newEmailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newEmailText.Enter += new System.EventHandler(this.newEmailText_Enter);
            this.newEmailText.Leave += new System.EventHandler(this.newEmailText_Leave);
            // 
            // newPhoneNumberText
            // 
            this.newPhoneNumberText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.newPhoneNumberText.Location = new System.Drawing.Point(240, 281);
            this.newPhoneNumberText.Margin = new System.Windows.Forms.Padding(4);
            this.newPhoneNumberText.Name = "newPhoneNumberText";
            this.newPhoneNumberText.Size = new System.Drawing.Size(132, 22);
            this.newPhoneNumberText.TabIndex = 3;
            this.newPhoneNumberText.Text = "Phone number";
            this.newPhoneNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPhoneNumberText.Enter += new System.EventHandler(this.newPhoneNumberText_Enter);
            this.newPhoneNumberText.Leave += new System.EventHandler(this.newPhoneNumberText_Leave);
            // 
            // newPasswordText
            // 
            this.newPasswordText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.newPasswordText.Location = new System.Drawing.Point(240, 343);
            this.newPasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.newPasswordText.Name = "newPasswordText";
            this.newPasswordText.Size = new System.Drawing.Size(132, 22);
            this.newPasswordText.TabIndex = 4;
            this.newPasswordText.Text = "Password";
            this.newPasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPasswordText.Enter += new System.EventHandler(this.newPasswordText_Enter);
            this.newPasswordText.Leave += new System.EventHandler(this.newPasswordText_Leave);
            // 
            // createNewAccountButton
            // 
            this.createNewAccountButton.Location = new System.Drawing.Point(240, 417);
            this.createNewAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.createNewAccountButton.Name = "createNewAccountButton";
            this.createNewAccountButton.Size = new System.Drawing.Size(132, 28);
            this.createNewAccountButton.TabIndex = 5;
            this.createNewAccountButton.Text = "Create Account";
            this.createNewAccountButton.UseVisualStyleBackColor = true;
            this.createNewAccountButton.Click += new System.EventHandler(this.createNewAccountButton_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibroTechFiestaV2.Properties.Resources.backgroundReg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 637);
            this.Controls.Add(this.createNewAccountButton);
            this.Controls.Add(this.newPasswordText);
            this.Controls.Add(this.newPhoneNumberText);
            this.Controls.Add(this.newEmailText);
            this.Controls.Add(this.newLastNameText);
            this.Controls.Add(this.newFirstNameText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateAccount";
            this.Text = "Create a New Account";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newFirstNameText;
        private System.Windows.Forms.TextBox newLastNameText;
        private System.Windows.Forms.TextBox newEmailText;
        private System.Windows.Forms.TextBox newPhoneNumberText;
        private System.Windows.Forms.TextBox newPasswordText;
        private System.Windows.Forms.Button createNewAccountButton;
    }
}