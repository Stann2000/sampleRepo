namespace FacialRecognitionServer
{
    partial class ManageFaces
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
            btnAddDetected = new Button();
            pictureBoxDetectFace = new PictureBox();
            btnScanFace = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            panel1 = new Panel();
            rdbtnFemale = new RadioButton();
            rdbtnMale = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            cmbSkinTone = new ComboBox();
            label1 = new Label();
            pictureBoxDetected = new PictureBox();
            label2 = new Label();
            btnCapture = new Button();
            lblCountAllFaces = new Label();
            btnopen = new Button();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetectFace).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetected).BeginInit();
            SuspendLayout();
            // 
            // btnAddDetected
            // 
            btnAddDetected.FlatStyle = FlatStyle.Flat;
            btnAddDetected.Location = new Point(622, 393);
            btnAddDetected.Name = "btnAddDetected";
            btnAddDetected.Size = new Size(95, 43);
            btnAddDetected.TabIndex = 0;
            btnAddDetected.Text = "Add";
            btnAddDetected.UseVisualStyleBackColor = true;
            btnAddDetected.Click += btnAddDetected_Click;
            // 
            // pictureBoxDetectFace
            // 
            pictureBoxDetectFace.BackColor = Color.Gainsboro;
            pictureBoxDetectFace.BackgroundImageLayout = ImageLayout.None;
            pictureBoxDetectFace.Location = new Point(14, 41);
            pictureBoxDetectFace.Name = "pictureBoxDetectFace";
            pictureBoxDetectFace.Size = new Size(286, 333);
            pictureBoxDetectFace.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDetectFace.TabIndex = 1;
            pictureBoxDetectFace.TabStop = false;
            // 
            // btnScanFace
            // 
            btnScanFace.FlatStyle = FlatStyle.Flat;
            btnScanFace.Location = new Point(14, 393);
            btnScanFace.Name = "btnScanFace";
            btnScanFace.Size = new Size(143, 43);
            btnScanFace.TabIndex = 2;
            btnScanFace.Text = "Scan Face";
            btnScanFace.UseVisualStyleBackColor = true;
            btnScanFace.Click += btnScanFace_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(485, 41);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(232, 27);
            txtFirstName.TabIndex = 16;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(485, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(232, 27);
            txtLastName.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(rdbtnFemale);
            panel1.Controls.Add(rdbtnMale);
            panel1.Location = new Point(485, 252);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 75);
            panel1.TabIndex = 17;
            // 
            // rdbtnFemale
            // 
            rdbtnFemale.AutoSize = true;
            rdbtnFemale.Location = new Point(39, 37);
            rdbtnFemale.Name = "rdbtnFemale";
            rdbtnFemale.Size = new Size(78, 24);
            rdbtnFemale.TabIndex = 20;
            rdbtnFemale.TabStop = true;
            rdbtnFemale.Text = "Female";
            rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            rdbtnMale.AutoSize = true;
            rdbtnMale.Location = new Point(39, 7);
            rdbtnMale.Name = "rdbtnMale";
            rdbtnMale.Size = new Size(63, 24);
            rdbtnMale.TabIndex = 0;
            rdbtnMale.TabStop = true;
            rdbtnMale.Text = "Male";
            rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(485, 204);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // cmbSkinTone
            // 
            cmbSkinTone.FlatStyle = FlatStyle.Flat;
            cmbSkinTone.FormattingEnabled = true;
            cmbSkinTone.Items.AddRange(new object[] { "Black", "Brown", "Cream", "White", "Pale White" });
            cmbSkinTone.Location = new Point(485, 344);
            cmbSkinTone.Name = "cmbSkinTone";
            cmbSkinTone.Size = new Size(231, 28);
            cmbSkinTone.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(485, 168);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 20;
            label1.Text = "Date of Birth";
            // 
            // pictureBoxDetected
            // 
            pictureBoxDetected.BackColor = Color.FromArgb(64, 64, 64);
            pictureBoxDetected.Location = new Point(306, 41);
            pictureBoxDetected.Margin = new Padding(3, 4, 3, 4);
            pictureBoxDetected.Name = "pictureBoxDetected";
            pictureBoxDetected.Size = new Size(126, 160);
            pictureBoxDetected.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDetected.TabIndex = 21;
            pictureBoxDetected.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(306, 215);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 22;
            label2.Text = "Detected Face";
            // 
            // btnCapture
            // 
            btnCapture.FlatStyle = FlatStyle.Flat;
            btnCapture.Location = new Point(163, 393);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(136, 43);
            btnCapture.TabIndex = 23;
            btnCapture.Text = "Capture Image";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // lblCountAllFaces
            // 
            lblCountAllFaces.AutoSize = true;
            lblCountAllFaces.Location = new Point(308, 258);
            lblCountAllFaces.Name = "lblCountAllFaces";
            lblCountAllFaces.Size = new Size(55, 20);
            lblCountAllFaces.TabIndex = 24;
            lblCountAllFaces.Text = "count..,";
            // 
            // btnopen
            // 
            btnopen.Location = new Point(376, 393);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(149, 43);
            btnopen.TabIndex = 25;
            btnopen.Text = "open folder";
            btnopen.UseVisualStyleBackColor = true;
            btnopen.Click += btnopen_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(308, 289);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 20);
            lblName.TabIndex = 26;
            lblName.Text = "name";
            // 
            // ManageFaces
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(lblName);
            Controls.Add(btnopen);
            Controls.Add(lblCountAllFaces);
            Controls.Add(btnCapture);
            Controls.Add(label2);
            Controls.Add(pictureBoxDetected);
            Controls.Add(label1);
            Controls.Add(cmbSkinTone);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(btnScanFace);
            Controls.Add(pictureBoxDetectFace);
            Controls.Add(btnAddDetected);
            Name = "ManageFaces";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageFaces";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetectFace).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetected).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddDetected;
        private Button btnScanFace;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Panel panel1;
        private RadioButton rdbtnMale;
        private RadioButton rdbtnFemale;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbSkinTone;
        public PictureBox pictureBoxDetectFace;
        private Label label1;
        private PictureBox pictureBoxDetected;
        private Label label2;
        private Button btnCapture;
        private Label lblCountAllFaces;
        private Button btnopen;
        private Label lblName;
    }
}