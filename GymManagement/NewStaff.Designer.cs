namespace GymManagement
{
    partial class NewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStaff));
            DesgcomboBox = new ComboBox();
            txtAddress = new RichTextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePickerJD = new DateTimePicker();
            dateTimePickerDOB = new DateTimePicker();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            MobNo = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Submit = new Button();
            Reset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DesgcomboBox
            // 
            DesgcomboBox.FormattingEnabled = true;
            DesgcomboBox.Items.AddRange(new object[] { "Trainer", "House Keeping", "Admin ", "Accountant", "Marketing", "Receptionist" });
            DesgcomboBox.Location = new Point(675, 377);
            DesgcomboBox.Name = "DesgcomboBox";
            DesgcomboBox.Size = new Size(166, 28);
            DesgcomboBox.TabIndex = 48;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(675, 443);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(166, 108);
            txtAddress.TabIndex = 47;
            txtAddress.Text = "";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(303, 384);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(97, 28);
            radioButton2.TabIndex = 46;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(223, 384);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 28);
            radioButton1.TabIndex = 45;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerJD
            // 
            dateTimePickerJD.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerJD.Format = DateTimePickerFormat.Short;
            dateTimePickerJD.Location = new Point(675, 314);
            dateTimePickerJD.Name = "dateTimePickerJD";
            dateTimePickerJD.Size = new Size(166, 31);
            dateTimePickerJD.TabIndex = 44;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(223, 441);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(155, 31);
            dateTimePickerDOB.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(389, 135);
            label11.Name = "label11";
            label11.Size = new Size(235, 62);
            label11.TabIndex = 42;
            label11.Text = "AJ Fitness";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(430, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 114);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(675, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 27);
            txtEmail.TabIndex = 40;
            // 
            // MobNo
            // 
            MobNo.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            MobNo.Location = new Point(223, 496);
            MobNo.Name = "MobNo";
            MobNo.Size = new Size(155, 31);
            MobNo.TabIndex = 39;
            // 
            // txtLname
            // 
            txtLname.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            txtLname.Location = new Point(223, 314);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(155, 31);
            txtLname.TabIndex = 38;
            // 
            // txtFname
            // 
            txtFname.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            txtFname.Location = new Point(223, 242);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(155, 31);
            txtFname.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(566, 441);
            label9.Name = "label9";
            label9.Size = new Size(82, 24);
            label9.TabIndex = 35;
            label9.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(551, 380);
            label8.Name = "label8";
            label8.Size = new Size(118, 24);
            label8.TabIndex = 34;
            label8.Text = "Designation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(566, 317);
            label7.Name = "label7";
            label7.Size = new Size(99, 24);
            label7.TabIndex = 33;
            label7.Text = "Join Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.IBeam;
            label6.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(566, 249);
            label6.Name = "label6";
            label6.Size = new Size(64, 24);
            label6.TabIndex = 32;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(99, 499);
            label5.Name = "label5";
            label5.Size = new Size(108, 24);
            label5.TabIndex = 31;
            label5.Text = "Mobile No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(99, 441);
            label4.Name = "label4";
            label4.Size = new Size(56, 24);
            label4.TabIndex = 30;
            label4.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(96, 380);
            label3.Name = "label3";
            label3.Size = new Size(74, 24);
            label3.TabIndex = 29;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 317);
            label2.Name = "label2";
            label2.Size = new Size(110, 24);
            label2.TabIndex = 28;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("DeVinne Txt BT", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(96, 249);
            label1.Name = "label1";
            label1.Size = new Size(121, 24);
            label1.TabIndex = 27;
            label1.Text = "First  Name";
            // 
            // Submit
            // 
            Submit.Location = new Point(543, 588);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 50;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(374, 588);
            Reset.Name = "Reset";
            Reset.Size = new Size(94, 29);
            Reset.TabIndex = 49;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // NewStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1002, 697);
            Controls.Add(Submit);
            Controls.Add(Reset);
            Controls.Add(DesgcomboBox);
            Controls.Add(txtAddress);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dateTimePickerJD);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(txtEmail);
            Controls.Add(MobNo);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewStaff";
            Text = "NewStaff";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox DesgcomboBox;
        private RichTextBox txtAddress;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePickerJD;
        private DateTimePicker dateTimePickerDOB;
        private Label label11;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private TextBox MobNo;
        private TextBox txtLname;
        private TextBox txtFname;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Submit;
        private Button Reset;
    }
}