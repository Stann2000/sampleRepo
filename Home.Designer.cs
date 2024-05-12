namespace FacialRecognitionServer
{
    partial class Home
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
            btnLogout = new Button();
            panel1 = new Panel();
            btnHistory = new Button();
            btnTracing = new Button();
            btnManageFaces = new Button();
            btnSurviellance = new Button();
            btnAdmin = new Button();
            btnHelp = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.System;
            btnLogout.Location = new Point(6, 28);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(72, 46);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnTracing);
            panel1.Controls.Add(btnManageFaces);
            panel1.Controls.Add(btnSurviellance);
            panel1.Controls.Add(btnAdmin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 561);
            panel1.TabIndex = 1;
            // 
            // btnHistory
            // 
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderColor = Color.Silver;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistory.Image = Properties.Resources.icons8_clock_50px;
            btnHistory.Location = new Point(0, 400);
            btnHistory.Margin = new Padding(3, 2, 3, 2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(100, 100);
            btnHistory.TabIndex = 6;
            btnHistory.Text = "History";
            btnHistory.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnTracing
            // 
            btnTracing.Dock = DockStyle.Top;
            btnTracing.FlatAppearance.BorderColor = Color.Silver;
            btnTracing.FlatStyle = FlatStyle.Flat;
            btnTracing.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTracing.Image = Properties.Resources.icons8_location_50px;
            btnTracing.Location = new Point(0, 300);
            btnTracing.Margin = new Padding(3, 2, 3, 2);
            btnTracing.Name = "btnTracing";
            btnTracing.Size = new Size(100, 100);
            btnTracing.TabIndex = 5;
            btnTracing.Text = "Tracing";
            btnTracing.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTracing.UseVisualStyleBackColor = true;
            // 
            // btnManageFaces
            // 
            btnManageFaces.Dock = DockStyle.Top;
            btnManageFaces.FlatAppearance.BorderColor = Color.Silver;
            btnManageFaces.FlatStyle = FlatStyle.Flat;
            btnManageFaces.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnManageFaces.Image = Properties.Resources.icons8_facial_recognition_50px;
            btnManageFaces.Location = new Point(0, 200);
            btnManageFaces.Margin = new Padding(3, 2, 3, 2);
            btnManageFaces.Name = "btnManageFaces";
            btnManageFaces.Size = new Size(100, 100);
            btnManageFaces.TabIndex = 4;
            btnManageFaces.Text = "Manage Faces";
            btnManageFaces.TextImageRelation = TextImageRelation.ImageAboveText;
            btnManageFaces.UseVisualStyleBackColor = true;
            // 
            // btnSurviellance
            // 
            btnSurviellance.Dock = DockStyle.Top;
            btnSurviellance.FlatAppearance.BorderColor = Color.Silver;
            btnSurviellance.FlatStyle = FlatStyle.Flat;
            btnSurviellance.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSurviellance.Image = Properties.Resources.icons_wall_mount_camera_50px;
            btnSurviellance.Location = new Point(0, 100);
            btnSurviellance.Margin = new Padding(3, 2, 3, 2);
            btnSurviellance.Name = "btnSurviellance";
            btnSurviellance.Size = new Size(100, 100);
            btnSurviellance.TabIndex = 3;
            btnSurviellance.Text = "Surviellance";
            btnSurviellance.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSurviellance.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderColor = Color.Silver;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.Image = Properties.Resources.icons8_test_account_50px_1;
            btnAdmin.Location = new Point(0, 0);
            btnAdmin.Margin = new Padding(3, 2, 3, 2);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(100, 100);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Admin";
            btnAdmin.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHelp.BackColor = Color.Transparent;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHelp.Image = Properties.Resources.icons8_help_40px;
            btnHelp.Location = new Point(651, 15);
            btnHelp.Margin = new Padding(3, 2, 3, 2);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(61, 71);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "Help";
            btnHelp.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHelp.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 244);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(307, 150);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnHelp);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(100, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(724, 100);
            panel2.TabIndex = 9;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(824, 561);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Panel panel1;
        private Button btnAdmin;
        private Button btnHelp;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnManageFaces;
        private Button btnSurviellance;
        private Panel panel2;
        private Button btnHistory;
        private Button btnTracing;
    }
}