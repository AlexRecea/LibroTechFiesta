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
            this.newFirstNameText.Location = new System.Drawing.Point(319, 86);
            this.newFirstNameText.Name = "newFirstNameText";
            this.newFirstNameText.Size = new System.Drawing.Size(100, 20);
            this.newFirstNameText.TabIndex = 0;
            // 
            // newLastNameText
            // 
            this.newLastNameText.Location = new System.Drawing.Point(319, 147);
            this.newLastNameText.Name = "newLastNameText";
            this.newLastNameText.Size = new System.Drawing.Size(100, 20);
            this.newLastNameText.TabIndex = 1;
            // 
            // newEmailText
            // 
            this.newEmailText.Location = new System.Drawing.Point(319, 216);
            this.newEmailText.Name = "newEmailText";
            this.newEmailText.Size = new System.Drawing.Size(100, 20);
            this.newEmailText.TabIndex = 2;
            // 
            // newPhoneNumberText
            // 
            this.newPhoneNumberText.Location = new System.Drawing.Point(319, 281);
            this.newPhoneNumberText.Name = "newPhoneNumberText";
            this.newPhoneNumberText.Size = new System.Drawing.Size(100, 20);
            this.newPhoneNumberText.TabIndex = 3;
            // 
            // newPasswordText
            // 
            this.newPasswordText.Location = new System.Drawing.Point(319, 343);
            this.newPasswordText.Name = "newPasswordText";
            this.newPasswordText.Size = new System.Drawing.Size(100, 20);
            this.newPasswordText.TabIndex = 4;
            // 
            // createNewAccountButton
            // 
            this.createNewAccountButton.Location = new System.Drawing.Point(606, 260);
            this.createNewAccountButton.Name = "createNewAccountButton";
            this.createNewAccountButton.Size = new System.Drawing.Size(75, 23);
            this.createNewAccountButton.TabIndex = 5;
            this.createNewAccountButton.Text = "button1";
            this.createNewAccountButton.UseVisualStyleBackColor = true;
            this.createNewAccountButton.Click += new System.EventHandler(this.createNewAccountButton_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createNewAccountButton);
            this.Controls.Add(this.newPasswordText);
            this.Controls.Add(this.newPhoneNumberText);
            this.Controls.Add(this.newEmailText);
            this.Controls.Add(this.newLastNameText);
            this.Controls.Add(this.newFirstNameText);
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