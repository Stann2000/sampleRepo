namespace FacialRecognitionServer
{
    partial class Register
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
            btnCreateAcc = new Button();
            txtRegId = new TextBox();
            txtRegUsername = new TextBox();
            txtRegPass = new TextBox();
            txtRegPosition = new TextBox();
            txtRegEmail = new TextBox();
            txtRegFName = new TextBox();
            label1 = new Label();
            btnBackReg = new Button();
            txtRegCPass = new TextBox();
            SuspendLayout();
            // 
            // btnCreateAcc
            // 
            btnCreateAcc.Location = new Point(244, 466);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.Size = new Size(135, 29);
            btnCreateAcc.TabIndex = 0;
            btnCreateAcc.Text = "Create Account";
            btnCreateAcc.UseVisualStyleBackColor = true;
            btnCreateAcc.Click += btnCreateAcc_Click;
            // 
            // txtRegId
            // 
            txtRegId.Location = new Point(193, 129);
            txtRegId.Name = "txtRegId";
            txtRegId.PlaceholderText = "Work Identification Number";
            txtRegId.Size = new Size(231, 27);
            txtRegId.TabIndex = 2;
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(193, 315);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.PlaceholderText = "Username";
            txtRegUsername.Size = new Size(231, 27);
            txtRegUsername.TabIndex = 3;
            // 
            // txtRegPass
            // 
            txtRegPass.Location = new Point(193, 361);
            txtRegPass.MaxLength = 20;
            txtRegPass.Name = "txtRegPass";
            txtRegPass.PasswordChar = '*';
            txtRegPass.PlaceholderText = "Password";
            txtRegPass.Size = new Size(231, 27);
            txtRegPass.TabIndex = 4;
            // 
            // txtRegPosition
            // 
            txtRegPosition.Location = new Point(193, 269);
            txtRegPosition.Name = "txtRegPosition";
            txtRegPosition.PlaceholderText = "Position";
            txtRegPosition.Size = new Size(231, 27);
            txtRegPosition.TabIndex = 5;
            // 
            // txtRegEmail
            // 
            txtRegEmail.Location = new Point(193, 222);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.PlaceholderText = "Email";
            txtRegEmail.Size = new Size(231, 27);
            txtRegEmail.TabIndex = 6;
            // 
            // txtRegFName
            // 
            txtRegFName.Location = new Point(193, 174);
            txtRegFName.Name = "txtRegFName";
            txtRegFName.PlaceholderText = "Full Name";
            txtRegFName.Size = new Size(231, 27);
            txtRegFName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(226, 39);
            label1.Name = "label1";
            label1.Size = new Size(162, 46);
            label1.TabIndex = 8;
            label1.Text = "REGISTER";
            // 
            // btnBackReg
            // 
            btnBackReg.Location = new Point(43, 17);
            btnBackReg.Name = "btnBackReg";
            btnBackReg.Size = new Size(94, 29);
            btnBackReg.TabIndex = 9;
            btnBackReg.Text = "Back";
            btnBackReg.UseVisualStyleBackColor = true;
            btnBackReg.Click += btnBackReg_Click;
            // 
            // txtRegCPass
            // 
            txtRegCPass.Location = new Point(193, 408);
            txtRegCPass.MaxLength = 20;
            txtRegCPass.Name = "txtRegCPass";
            txtRegCPass.PasswordChar = '*';
            txtRegCPass.PlaceholderText = "Confirm Password";
            txtRegCPass.Size = new Size(231, 27);
            txtRegCPass.TabIndex = 10;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 610);
            Controls.Add(txtRegCPass);
            Controls.Add(btnBackReg);
            Controls.Add(label1);
            Controls.Add(txtRegFName);
            Controls.Add(txtRegEmail);
            Controls.Add(txtRegPosition);
            Controls.Add(txtRegPass);
            Controls.Add(txtRegUsername);
            Controls.Add(txtRegId);
            Controls.Add(btnCreateAcc);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateAcc;
        private TextBox txtRegId;
        private TextBox txtRegUsername;
        private TextBox txtRegPass;
        private TextBox txtRegPosition;
        private TextBox txtRegEmail;
        private TextBox txtRegFName;
        private Label label1;
        private Button btnBackReg;
        private TextBox txtRegCPass;
    }
}