namespace OBD
{
    partial class LogIn
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
            this.LogInButton = new System.Windows.Forms.Button();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.passwordSingUp = new System.Windows.Forms.Label();
            this.singUpName = new System.Windows.Forms.Label();
            this.passwordLIBox = new System.Windows.Forms.TextBox();
            this.LogInBox = new System.Windows.Forms.TextBox();
            this.linkLogIn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(143, 354);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(198, 57);
            this.LogInButton.TabIndex = 23;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.ForeColor = System.Drawing.Color.Lime;
            this.LogInLabel.Location = new System.Drawing.Point(208, 75);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(43, 16);
            this.LogInLabel.TabIndex = 22;
            this.LogInLabel.Text = "Log In";
            // 
            // passwordSingUp
            // 
            this.passwordSingUp.AutoSize = true;
            this.passwordSingUp.ForeColor = System.Drawing.Color.Lime;
            this.passwordSingUp.Location = new System.Drawing.Point(67, 256);
            this.passwordSingUp.Name = "passwordSingUp";
            this.passwordSingUp.Size = new System.Drawing.Size(70, 16);
            this.passwordSingUp.TabIndex = 21;
            this.passwordSingUp.Text = "Password:";
            // 
            // singUpName
            // 
            this.singUpName.AutoSize = true;
            this.singUpName.ForeColor = System.Drawing.Color.Lime;
            this.singUpName.Location = new System.Drawing.Point(90, 188);
            this.singUpName.Name = "singUpName";
            this.singUpName.Size = new System.Drawing.Size(47, 16);
            this.singUpName.TabIndex = 20;
            this.singUpName.Text = "Name:";
            // 
            // passwordLIBox
            // 
            this.passwordLIBox.Location = new System.Drawing.Point(143, 248);
            this.passwordLIBox.Multiline = true;
            this.passwordLIBox.Name = "passwordLIBox";
            this.passwordLIBox.Size = new System.Drawing.Size(198, 24);
            this.passwordLIBox.TabIndex = 19;
            // 
            // LogInBox
            // 
            this.LogInBox.Location = new System.Drawing.Point(143, 182);
            this.LogInBox.Multiline = true;
            this.LogInBox.Name = "LogInBox";
            this.LogInBox.Size = new System.Drawing.Size(198, 22);
            this.LogInBox.TabIndex = 18;
            // 
            // linkLogIn
            // 
            this.linkLogIn.AutoSize = true;
            this.linkLogIn.LinkColor = System.Drawing.Color.Lime;
            this.linkLogIn.Location = new System.Drawing.Point(156, 442);
            this.linkLogIn.Name = "linkLogIn";
            this.linkLogIn.Size = new System.Drawing.Size(171, 16);
            this.linkLogIn.TabIndex = 24;
            this.linkLogIn.TabStop = true;
            this.linkLogIn.Text = "You don\'t have an account?";
            this.linkLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogIn_LinkClicked);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(482, 520);
            this.Controls.Add(this.linkLogIn);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.LogInLabel);
            this.Controls.Add(this.passwordSingUp);
            this.Controls.Add(this.singUpName);
            this.Controls.Add(this.passwordLIBox);
            this.Controls.Add(this.LogInBox);
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Label passwordSingUp;
        private System.Windows.Forms.Label singUpName;
        private System.Windows.Forms.TextBox passwordLIBox;
        private System.Windows.Forms.TextBox LogInBox;
        private System.Windows.Forms.LinkLabel linkLogIn;
    }
}