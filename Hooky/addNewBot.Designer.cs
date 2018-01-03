namespace Hooky
{
    partial class addNewBot
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
            this.hookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.postURL = new System.Windows.Forms.Label();
            this.URLinput = new System.Windows.Forms.TextBox();
            this.sendClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hookName
            // 
            this.hookName.Location = new System.Drawing.Point(12, 26);
            this.hookName.MaxLength = 32;
            this.hookName.Name = "hookName";
            this.hookName.Size = new System.Drawing.Size(285, 20);
            this.hookName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Webhook Name";
            // 
            // postURL
            // 
            this.postURL.AutoSize = true;
            this.postURL.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postURL.Location = new System.Drawing.Point(12, 49);
            this.postURL.Name = "postURL";
            this.postURL.Size = new System.Drawing.Size(79, 15);
            this.postURL.TabIndex = 1;
            this.postURL.Text = "Webhook URL";
            // 
            // URLinput
            // 
            this.URLinput.Location = new System.Drawing.Point(12, 67);
            this.URLinput.MaxLength = 32;
            this.URLinput.Name = "URLinput";
            this.URLinput.Size = new System.Drawing.Size(285, 20);
            this.URLinput.TabIndex = 0;
            // 
            // sendClose
            // 
            this.sendClose.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.sendClose.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendClose.Location = new System.Drawing.Point(12, 94);
            this.sendClose.Name = "sendClose";
            this.sendClose.Size = new System.Drawing.Size(285, 52);
            this.sendClose.TabIndex = 2;
            this.sendClose.Text = "Add Webhook";
            this.sendClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 158);
            this.Controls.Add(this.sendClose);
            this.Controls.Add(this.postURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URLinput);
            this.Controls.Add(this.hookName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Add New Webhook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label postURL;
        private System.Windows.Forms.TextBox URLinput;
        private System.Windows.Forms.Button sendClose;
    }
}