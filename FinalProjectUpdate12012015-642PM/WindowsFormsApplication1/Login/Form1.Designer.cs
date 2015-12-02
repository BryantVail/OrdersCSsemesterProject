namespace OrderEmployeedManagementWindowsNative
{
    partial class defaultLoginForm
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.PasswordLablel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginMenuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LoginMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.Location = new System.Drawing.Point(492, 64);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(492, 89);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(411, 64);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(75, 17);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Username :";
            // 
            // PasswordLablel
            // 
            this.PasswordLablel.AutoSize = true;
            this.PasswordLablel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLablel.Location = new System.Drawing.Point(414, 89);
            this.PasswordLablel.Name = "PasswordLablel";
            this.PasswordLablel.Size = new System.Drawing.Size(72, 17);
            this.PasswordLablel.TabIndex = 1;
            this.PasswordLablel.Text = "Password :";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(136)))), ((int)(((byte)(73)))));
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(470, 145);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(122, 36);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginMenuStrip
            // 
            this.LoginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.LoginMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.LoginMenuStrip.Name = "LoginMenuStrip";
            this.LoginMenuStrip.Size = new System.Drawing.Size(649, 24);
            this.LoginMenuStrip.TabIndex = 3;
            this.LoginMenuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignInMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // SignInMenuItem
            // 
            this.SignInMenuItem.Name = "SignInMenuItem";
            this.SignInMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SignInMenuItem.Text = "Sign In help";
            this.SignInMenuItem.Click += new System.EventHandler(this.SignInMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(476, 118);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Credentials";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // defaultLoginForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(649, 311);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLablel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.LoginMenuStrip);
            this.MainMenuStrip = this.LoginMenuStrip;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "defaultLoginForm";
            this.Text = "Eat Sleep Print";
            this.Load += new System.EventHandler(this.defaultLoginForm_Load);
            this.LoginMenuStrip.ResumeLayout(false);
            this.LoginMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label PasswordLablel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.MenuStrip LoginMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignInMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

