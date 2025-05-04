namespace OBD
{
    partial class SingUp
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
            this.singUpBox = new System.Windows.Forms.TextBox();
            this.passwordSUBox = new System.Windows.Forms.TextBox();
            this.singUpName = new System.Windows.Forms.Label();
            this.passwordSingUp = new System.Windows.Forms.Label();
            this.singUpLabel = new System.Windows.Forms.Label();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singUpBox
            // 
            this.singUpBox.Location = new System.Drawing.Point(144, 183);
            this.singUpBox.Multiline = true;
            this.singUpBox.Name = "singUpBox";
            this.singUpBox.Size = new System.Drawing.Size(198, 23);
            this.singUpBox.TabIndex = 12;
            // 
            // passwordSUBox
            // 
            this.passwordSUBox.Location = new System.Drawing.Point(144, 250);
            this.passwordSUBox.Multiline = true;
            this.passwordSUBox.Name = "passwordSUBox";
            this.passwordSUBox.Size = new System.Drawing.Size(198, 24);
            this.passwordSUBox.TabIndex = 13;
            // 
            // singUpName
            // 
            this.singUpName.AutoSize = true;
            this.singUpName.ForeColor = System.Drawing.Color.Lime;
            this.singUpName.Location = new System.Drawing.Point(94, 190);
            this.singUpName.Name = "singUpName";
            this.singUpName.Size = new System.Drawing.Size(47, 16);
            this.singUpName.TabIndex = 14;
            this.singUpName.Text = "Name:";
            // 
            // passwordSingUp
            // 
            this.passwordSingUp.AutoSize = true;
            this.passwordSingUp.ForeColor = System.Drawing.Color.Lime;
            this.passwordSingUp.Location = new System.Drawing.Point(70, 258);
            this.passwordSingUp.Name = "passwordSingUp";
            this.passwordSingUp.Size = new System.Drawing.Size(70, 16);
            this.passwordSingUp.TabIndex = 15;
            this.passwordSingUp.Text = "Password:";
            // 
            // singUpLabel
            // 
            this.singUpLabel.AutoSize = true;
            this.singUpLabel.ForeColor = System.Drawing.Color.Lime;
            this.singUpLabel.Location = new System.Drawing.Point(209, 77);
            this.singUpLabel.Name = "singUpLabel";
            this.singUpLabel.Size = new System.Drawing.Size(55, 16);
            this.singUpLabel.TabIndex = 16;
            this.singUpLabel.Text = "Sing Up";
            // 
            // CreateAccount
            // 
            this.CreateAccount.Location = new System.Drawing.Point(144, 356);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(198, 57);
            this.CreateAccount.TabIndex = 17;
            this.CreateAccount.Text = "Create account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(482, 520);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.singUpLabel);
            this.Controls.Add(this.passwordSingUp);
            this.Controls.Add(this.singUpName);
            this.Controls.Add(this.passwordSUBox);
            this.Controls.Add(this.singUpBox);
            this.MaximizeBox = false;
            this.Name = "SingUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SingUp_FormClosed);
            this.Load += new System.EventHandler(this.SingUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox singUpBox;
        private System.Windows.Forms.TextBox passwordSUBox;
        private System.Windows.Forms.Label singUpName;
        private System.Windows.Forms.Label passwordSingUp;
        private System.Windows.Forms.Label singUpLabel;
        private System.Windows.Forms.Button CreateAccount;
    }
}