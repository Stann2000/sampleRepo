namespace FacialRecognitionServer
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnNoAccount = new LinkLabel();
            label1 = new Label();
            txtLogUsername = new TextBox();
            txtLogPass = new TextBox();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(215, 352);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnNoAccount
            // 
            btnNoAccount.AutoSize = true;
            btnNoAccount.Location = new Point(191, 318);
            btnNoAccount.Name = "btnNoAccount";
            btnNoAccount.Size = new Size(137, 20);
            btnNoAccount.TabIndex = 1;
            btnNoAccount.TabStop = true;
            btnNoAccount.Text = "create new account";
            btnNoAccount.VisitedLinkColor = Color.Red;
            btnNoAccount.LinkClicked += btnNoAccount_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 23);
            label1.Name = "label1";
            label1.Size = new Size(238, 46);
            label1.TabIndex = 2;
            label1.Text = "ADMIN LOGIN";
            // 
            // txtLogUsername
            // 
            txtLogUsername.Location = new Point(159, 223);
            txtLogUsername.Name = "txtLogUsername";
            txtLogUsername.PlaceholderText = "Username";
            txtLogUsername.Size = new Size(208, 27);
            txtLogUsername.TabIndex = 3;
            // 
            // txtLogPass
            // 
            txtLogPass.Location = new Point(159, 279);
            txtLogPass.MaxLength = 20;
            txtLogPass.Name = "txtLogPass";
            txtLogPass.PasswordChar = '*';
            txtLogPass.PlaceholderText = "Password";
            txtLogPass.Size = new Size(208, 27);
            txtLogPass.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_customer_skin_type_7_100px;
            pictureBox1.Location = new Point(215, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 499);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            Controls.Add(txtLogPass);
            Controls.Add(txtLogUsername);
            Controls.Add(label1);
            Controls.Add(btnNoAccount);
            Controls.Add(btnLogin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private LinkLabel btnNoAccount;
        private Label label1;
        private TextBox txtLogUsername;
        private TextBox txtLogPass;
        private PictureBox pictureBox1;
        private Button btnExit;
    }
}