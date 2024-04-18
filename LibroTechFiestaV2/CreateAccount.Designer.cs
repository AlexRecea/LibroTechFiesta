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
            this.BackgroundImage = global::LibroTechFiestaV2.Properties.Resources.backgroundReg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
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
            this.newFirstNameText.Location = new System.Drawing.Point(249, 93);
            this.newFirstNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newFirstNameText.Name = "newFirstNameText";
            this.newFirstNameText.Size = new System.Drawing.Size(132, 22);
            this.newFirstNameText.TabIndex = 0;
            // 
            // newLastNameText
            // 
            this.newLastNameText.Location = new System.Drawing.Point(249, 162);
            this.newLastNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newLastNameText.Name = "newLastNameText";
            this.newLastNameText.Size = new System.Drawing.Size(132, 22);
            this.newLastNameText.TabIndex = 1;
            // 
            // newEmailText
            // 
            this.newEmailText.Location = new System.Drawing.Point(249, 230);
            this.newEmailText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newEmailText.Name = "newEmailText";
            this.newEmailText.Size = new System.Drawing.Size(132, 22);
            this.newEmailText.TabIndex = 2;
            // 
            // newPhoneNumberText
            // 
            this.newPhoneNumberText.Location = new System.Drawing.Point(249, 281);
            this.newPhoneNumberText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newPhoneNumberText.Name = "newPhoneNumberText";
            this.newPhoneNumberText.Size = new System.Drawing.Size(132, 22);
            this.newPhoneNumberText.TabIndex = 3;
            // 
            // newPasswordText
            // 
            this.newPasswordText.Location = new System.Drawing.Point(249, 347);
            this.newPasswordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newPasswordText.Name = "newPasswordText";
            this.newPasswordText.Size = new System.Drawing.Size(132, 22);
            this.newPasswordText.TabIndex = 4;
            // 
            // createNewAccountButton
            // 
            this.createNewAccountButton.Location = new System.Drawing.Point(249, 432);
            this.createNewAccountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createNewAccountButton.Name = "createNewAccountButton";
            this.createNewAccountButton.Size = new System.Drawing.Size(100, 28);
            this.createNewAccountButton.TabIndex = 5;
            this.createNewAccountButton.Text = "button1";
            this.createNewAccountButton.UseVisualStyleBackColor = true;
            this.createNewAccountButton.Click += new System.EventHandler(this.createNewAccountButton_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 637);
            this.Controls.Add(this.createNewAccountButton);
            this.Controls.Add(this.newPasswordText);
            this.Controls.Add(this.newPhoneNumberText);
            this.Controls.Add(this.newEmailText);
            this.Controls.Add(this.newLastNameText);
            this.Controls.Add(this.newFirstNameText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateAccount";
            this.Text = "Create a New Account";
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