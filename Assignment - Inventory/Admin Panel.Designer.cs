namespace Assignment___Inventory
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.userPassTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.userPassTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(393, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Form";
            // 
            // userPassTableLayoutPanel
            // 
            this.userPassTableLayoutPanel.ColumnCount = 2;
            this.userPassTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.userPassTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userPassTableLayoutPanel.Controls.Add(this.passwordLabel, 0, 1);
            this.userPassTableLayoutPanel.Controls.Add(this.usernameLabel, 0, 0);
            this.userPassTableLayoutPanel.Controls.Add(this.usernameTextbox, 1, 0);
            this.userPassTableLayoutPanel.Controls.Add(this.passwordTextbox, 1, 1);
            this.userPassTableLayoutPanel.Location = new System.Drawing.Point(346, 170);
            this.userPassTableLayoutPanel.Name = "userPassTableLayoutPanel";
            this.userPassTableLayoutPanel.RowCount = 2;
            this.userPassTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPassTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPassTableLayoutPanel.Size = new System.Drawing.Size(384, 120);
            this.userPassTableLayoutPanel.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(12, 74);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(144, 31);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password: ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(5, 14);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(151, 31);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username: ";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(162, 13);
            this.usernameTextbox.MaxLength = 20;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(219, 34);
            this.usernameTextbox.TabIndex = 2;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(162, 73);
            this.passwordTextbox.MaxLength = 20;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(219, 34);
            this.passwordTextbox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.loginButton.Location = new System.Drawing.Point(570, 342);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(102, 45);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.exitButton.Location = new System.Drawing.Point(417, 342);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 45);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.pictureBox1);
            this.loginGroupBox.Controls.Add(this.label1);
            this.loginGroupBox.Controls.Add(this.exitButton);
            this.loginGroupBox.Controls.Add(this.userPassTableLayoutPanel);
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Location = new System.Drawing.Point(-4, 5);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(746, 453);
            this.loginGroupBox.TabIndex = 5;
            this.loginGroupBox.TabStop = false;
            // 
            // adminForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(736, 451);
            this.Controls.Add(this.loginGroupBox);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.userPassTableLayoutPanel.ResumeLayout(false);
            this.userPassTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel userPassTableLayoutPanel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox loginGroupBox;
    }
}

