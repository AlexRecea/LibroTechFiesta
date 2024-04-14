namespace LibroTechFiestaV2
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginLibrariansButton = new System.Windows.Forms.Button();
            this.usernameClientText = new System.Windows.Forms.TextBox();
            this.passwordClientText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(480, 249);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 30);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.SystemColors.Window;
            this.usernameText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameText.Location = new System.Drawing.Point(435, 88);
            this.usernameText.Margin = new System.Windows.Forms.Padding(4);
            this.usernameText.MaxLength = 40;
            this.usernameText.Multiline = true;
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(200, 25);
            this.usernameText.TabIndex = 3;
            this.usernameText.Text = "username";
            this.usernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameText.Enter += new System.EventHandler(this.UsernameText_Enter);
            this.usernameText.Leave += new System.EventHandler(this.UsernameText_Leave);
            // 
            // passwordText
            // 
            this.passwordText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.passwordText.Location = new System.Drawing.Point(435, 171);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4);
            this.passwordText.MaxLength = 40;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(200, 25);
            this.passwordText.TabIndex = 4;
            this.passwordText.Text = "password";
            this.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordText.Enter += new System.EventHandler(this.PasswordText_Enter);
            this.passwordText.Leave += new System.EventHandler(this.PasswordText_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(343, 255);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(92, 38);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginLibrariansButton
            // 
            this.loginLibrariansButton.Location = new System.Drawing.Point(894, 400);
            this.loginLibrariansButton.Name = "loginLibrariansButton";
            this.loginLibrariansButton.Size = new System.Drawing.Size(97, 47);
            this.loginLibrariansButton.TabIndex = 7;
            this.loginLibrariansButton.Text = "Login Librarians";
            this.loginLibrariansButton.UseVisualStyleBackColor = true;
            this.loginLibrariansButton.Click += new System.EventHandler(this.loginLibrariansButton_Click);
            // 
            // usernameClientText
            // 
            this.usernameClientText.Location = new System.Drawing.Point(130, 112);
            this.usernameClientText.Name = "usernameClientText";
            this.usernameClientText.Size = new System.Drawing.Size(100, 25);
            this.usernameClientText.TabIndex = 8;
            // 
            // passwordClientText
            // 
            this.passwordClientText.Location = new System.Drawing.Point(163, 198);
            this.passwordClientText.Name = "passwordClientText";
            this.passwordClientText.Size = new System.Drawing.Size(100, 25);
            this.passwordClientText.TabIndex = 9;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::LibroTechFiestaV2.Properties.Resources.backgourndLibrary;
            this.ClientSize = new System.Drawing.Size(1087, 504);
            this.Controls.Add(this.passwordClientText);
            this.Controls.Add(this.usernameClientText);
            this.Controls.Add(this.loginLibrariansButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginLibrariansButton;
        private System.Windows.Forms.TextBox usernameClientText;
        private System.Windows.Forms.TextBox passwordClientText;
    }
}

