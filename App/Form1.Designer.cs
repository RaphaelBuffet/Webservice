namespace App
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
            this.switchWebService = new System.Windows.Forms.RadioButton();
            this.getusernameByUID = new System.Windows.Forms.Button();
            this.addCHFByUserName = new System.Windows.Forms.Button();
            this.addCHFByUID = new System.Windows.Forms.Button();
            this.usernameResult = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.TextBox();
            this.chf = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // switchWebService
            // 
            this.switchWebService.AutoSize = true;
            this.switchWebService.Location = new System.Drawing.Point(74, 356);
            this.switchWebService.Name = "switchWebService";
            this.switchWebService.Size = new System.Drawing.Size(147, 21);
            this.switchWebService.TabIndex = 0;
            this.switchWebService.TabStop = true;
            this.switchWebService.Text = "Switch web service";
            this.switchWebService.UseVisualStyleBackColor = true;
            this.switchWebService.CheckedChanged += new System.EventHandler(this.switchWebService_CheckedChanged);
            // 
            // getusernameByUID
            // 
            this.getusernameByUID.Location = new System.Drawing.Point(368, 86);
            this.getusernameByUID.Name = "getusernameByUID";
            this.getusernameByUID.Size = new System.Drawing.Size(193, 23);
            this.getusernameByUID.TabIndex = 1;
            this.getusernameByUID.Text = "get username By user ID";
            this.getusernameByUID.UseVisualStyleBackColor = true;
            this.getusernameByUID.Click += new System.EventHandler(this.getusernameByUID_Click);
            // 
            // addCHFByUserName
            // 
            this.addCHFByUserName.Location = new System.Drawing.Point(368, 133);
            this.addCHFByUserName.Name = "addCHFByUserName";
            this.addCHFByUserName.Size = new System.Drawing.Size(193, 23);
            this.addCHFByUserName.TabIndex = 2;
            this.addCHFByUserName.Text = "add CHF By User Name";
            this.addCHFByUserName.UseVisualStyleBackColor = true;
            this.addCHFByUserName.Click += new System.EventHandler(this.addCHFByUserName_Click);
            // 
            // addCHFByUID
            // 
            this.addCHFByUID.Location = new System.Drawing.Point(368, 186);
            this.addCHFByUID.Name = "addCHFByUID";
            this.addCHFByUID.Size = new System.Drawing.Size(193, 23);
            this.addCHFByUID.TabIndex = 3;
            this.addCHFByUID.Text = "add CHF by User ID";
            this.addCHFByUID.UseVisualStyleBackColor = true;
            // 
            // usernameResult
            // 
            this.usernameResult.AutoSize = true;
            this.usernameResult.Location = new System.Drawing.Point(648, 87);
            this.usernameResult.Name = "usernameResult";
            this.usernameResult.Size = new System.Drawing.Size(46, 17);
            this.usernameResult.TabIndex = 4;
            this.usernameResult.Text = "label1";
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(74, 87);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(100, 22);
            this.userId.TabIndex = 5;
            this.userId.TextChanged += new System.EventHandler(this.userId_TextChanged);
            // 
            // chf
            // 
            this.chf.Location = new System.Drawing.Point(74, 187);
            this.chf.Name = "chf";
            this.chf.Size = new System.Drawing.Size(100, 22);
            this.chf.TabIndex = 6;
            this.chf.TextChanged += new System.EventHandler(this.chf_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(74, 133);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 22);
            this.username.TabIndex = 7;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.username);
            this.Controls.Add(this.chf);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.usernameResult);
            this.Controls.Add(this.addCHFByUID);
            this.Controls.Add(this.addCHFByUserName);
            this.Controls.Add(this.getusernameByUID);
            this.Controls.Add(this.switchWebService);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton switchWebService;
        private System.Windows.Forms.Button getusernameByUID;
        private System.Windows.Forms.Button addCHFByUserName;
        private System.Windows.Forms.Button addCHFByUID;
        private System.Windows.Forms.Label usernameResult;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox chf;
        private System.Windows.Forms.TextBox username;
    }
}