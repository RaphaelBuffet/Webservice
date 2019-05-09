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
            this.getusernameByUID = new System.Windows.Forms.Button();
            this.addCHFByUserName = new System.Windows.Forms.Button();
            this.addCHFByUID = new System.Windows.Forms.Button();
            this.usernameResult = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.TextBox();
            this.chf = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.getAccount = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.switchWebService = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.addCHFByUID.Click += new System.EventHandler(this.addCHFByUID_Click);
            // 
            // usernameResult
            // 
            this.usernameResult.AutoSize = true;
            this.usernameResult.Location = new System.Drawing.Point(648, 87);
            this.usernameResult.Name = "usernameResult";
            this.usernameResult.Size = new System.Drawing.Size(77, 17);
            this.usernameResult.TabIndex = 4;
            this.usernameResult.Text = "User name";
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(121, 87);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(100, 22);
            this.userId.TabIndex = 5;
            // 
            // chf
            // 
            this.chf.Location = new System.Drawing.Point(121, 186);
            this.chf.Name = "chf";
            this.chf.Size = new System.Drawing.Size(100, 22);
            this.chf.TabIndex = 6;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(121, 137);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 22);
            this.username.TabIndex = 7;
            // 
            // getAccount
            // 
            this.getAccount.Location = new System.Drawing.Point(368, 242);
            this.getAccount.Name = "getAccount";
            this.getAccount.Size = new System.Drawing.Size(193, 23);
            this.getAccount.TabIndex = 9;
            this.getAccount.Text = "Get Account";
            this.getAccount.UseVisualStyleBackColor = true;
            this.getAccount.Click += new System.EventHandler(this.getAccount_Click);
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Location = new System.Drawing.Point(651, 137);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(59, 17);
            this.Account.TabIndex = 10;
            this.Account.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "CHF";
            // 
            // switchWebService
            // 
            this.switchWebService.AutoSize = true;
            this.switchWebService.Location = new System.Drawing.Point(121, 359);
            this.switchWebService.Name = "switchWebService";
            this.switchWebService.Size = new System.Drawing.Size(67, 21);
            this.switchWebService.TabIndex = 14;
            this.switchWebService.Text = "REST";
            this.switchWebService.UseVisualStyleBackColor = true;
            this.switchWebService.CheckedChanged += new System.EventHandler(this.switchWebService_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.switchWebService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.getAccount);
            this.Controls.Add(this.username);
            this.Controls.Add(this.chf);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.usernameResult);
            this.Controls.Add(this.addCHFByUID);
            this.Controls.Add(this.addCHFByUserName);
            this.Controls.Add(this.getusernameByUID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getusernameByUID;
        private System.Windows.Forms.Button addCHFByUserName;
        private System.Windows.Forms.Button addCHFByUID;
        private System.Windows.Forms.Label usernameResult;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox chf;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button getAccount;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox switchWebService;
    }
}