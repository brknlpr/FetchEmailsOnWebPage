namespace FetchMaillist
{
    partial class Form1
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
            this.btnGetMails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblListResult = new System.Windows.Forms.Label();
            this.mailListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetMails
            // 
            this.btnGetMails.Location = new System.Drawing.Point(16, 398);
            this.btnGetMails.Name = "btnGetMails";
            this.btnGetMails.Size = new System.Drawing.Size(574, 23);
            this.btnGetMails.TabIndex = 0;
            this.btnGetMails.Text = "Get Mail Adresses";
            this.btnGetMails.UseVisualStyleBackColor = true;
            this.btnGetMails.Click += new System.EventHandler(this.btnGetMails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Website : ";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(74, 10);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(516, 20);
            this.txtUrl.TabIndex = 2;
            // 
            // lblListResult
            // 
            this.lblListResult.AutoSize = true;
            this.lblListResult.Location = new System.Drawing.Point(283, 428);
            this.lblListResult.Name = "lblListResult";
            this.lblListResult.Size = new System.Drawing.Size(0, 13);
            this.lblListResult.TabIndex = 4;
            // 
            // mailListBox
            // 
            this.mailListBox.FormattingEnabled = true;
            this.mailListBox.Location = new System.Drawing.Point(16, 42);
            this.mailListBox.Name = "mailListBox";
            this.mailListBox.Size = new System.Drawing.Size(574, 342);
            this.mailListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.mailListBox);
            this.Controls.Add(this.lblListResult);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetMails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetMails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblListResult;
        private System.Windows.Forms.ListBox mailListBox;
    }
}

