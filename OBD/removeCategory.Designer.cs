namespace OBD
{
    partial class removeCategory
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
            this.removeButton = new System.Windows.Forms.Button();
            this.textBoxRemove = new System.Windows.Forms.TextBox();
            this.labelRemove = new System.Windows.Forms.Label();
            this.oldRemove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(112, 202);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(109, 28);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "rename";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // textBoxRemove
            // 
            this.textBoxRemove.Location = new System.Drawing.Point(112, 123);
            this.textBoxRemove.Name = "textBoxRemove";
            this.textBoxRemove.Size = new System.Drawing.Size(109, 22);
            this.textBoxRemove.TabIndex = 23;
            // 
            // labelRemove
            // 
            this.labelRemove.AutoSize = true;
            this.labelRemove.ForeColor = System.Drawing.Color.Lime;
            this.labelRemove.Location = new System.Drawing.Point(177, 70);
            this.labelRemove.Name = "labelRemove";
            this.labelRemove.Size = new System.Drawing.Size(44, 16);
            this.labelRemove.TabIndex = 24;
            this.labelRemove.Text = "label1";
            // 
            // oldRemove
            // 
            this.oldRemove.AutoSize = true;
            this.oldRemove.ForeColor = System.Drawing.Color.Lime;
            this.oldRemove.Location = new System.Drawing.Point(109, 70);
            this.oldRemove.Name = "oldRemove";
            this.oldRemove.Size = new System.Drawing.Size(68, 16);
            this.oldRemove.TabIndex = 25;
            this.oldRemove.Text = "Old name:";
            // 
            // removeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(326, 242);
            this.Controls.Add(this.oldRemove);
            this.Controls.Add(this.labelRemove);
            this.Controls.Add(this.textBoxRemove);
            this.Controls.Add(this.removeButton);
            this.MaximizeBox = false;
            this.Name = "removeCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove category";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.removeCategory_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox textBoxRemove;
        private System.Windows.Forms.Label labelRemove;
        private System.Windows.Forms.Label oldRemove;
    }
}