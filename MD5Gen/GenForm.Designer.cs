namespace gen5
{
    partial class GenForm
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
            this.normalTextBox = new System.Windows.Forms.TextBox();
            this.md5ResultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // normalTextBox
            // 
            this.normalTextBox.Location = new System.Drawing.Point(41, 8);
            this.normalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.normalTextBox.MaxLength = 33;
            this.normalTextBox.Multiline = true;
            this.normalTextBox.Name = "normalTextBox";
            this.normalTextBox.Size = new System.Drawing.Size(366, 25);
            this.normalTextBox.TabIndex = 1;
            this.normalTextBox.TextChanged += new System.EventHandler(this.normalTextBox_TextChanged);
            // 
            // md5ResultTextBox
            // 
            this.md5ResultTextBox.Location = new System.Drawing.Point(41, 35);
            this.md5ResultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.md5ResultTextBox.Multiline = true;
            this.md5ResultTextBox.Name = "md5ResultTextBox";
            this.md5ResultTextBox.ReadOnly = true;
            this.md5ResultTextBox.Size = new System.Drawing.Size(366, 25);
            this.md5ResultTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text:";
            // 
            // GenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 67);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.md5ResultTextBox);
            this.Controls.Add(this.normalTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD5Gen";
            this.Load += new System.EventHandler(this.GenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox normalTextBox;
        private System.Windows.Forms.TextBox md5ResultTextBox;
        private System.Windows.Forms.Label label1;
    }
}

