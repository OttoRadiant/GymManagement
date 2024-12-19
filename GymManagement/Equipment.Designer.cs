namespace GymManagement
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            EqpName = new TextBox();
            txtDesc = new RichTextBox();
            txtMuscle = new TextBox();
            dateTimePickerDD = new DateTimePicker();
            txtCost = new TextBox();
            Submit = new Button();
            Reset = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Monotype Corsiva", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(214, 217);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Equipment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Monotype Corsiva", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(214, 267);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Description ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Monotype Corsiva", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(214, 340);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Muscle Used";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Monotype Corsiva", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(214, 393);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Delivery Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Monotype Corsiva", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(214, 439);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 4;
            label5.Text = "Cost";
            // 
            // EqpName
            // 
            EqpName.Location = new Point(366, 213);
            EqpName.Name = "EqpName";
            EqpName.Size = new Size(196, 27);
            EqpName.TabIndex = 5;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(366, 263);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(196, 56);
            txtDesc.TabIndex = 48;
            txtDesc.Text = "";
            // 
            // txtMuscle
            // 
            txtMuscle.Location = new Point(366, 340);
            txtMuscle.Name = "txtMuscle";
            txtMuscle.Size = new Size(196, 27);
            txtMuscle.TabIndex = 49;
            // 
            // dateTimePickerDD
            // 
            dateTimePickerDD.Location = new Point(366, 393);
            dateTimePickerDD.Name = "dateTimePickerDD";
            dateTimePickerDD.Size = new Size(196, 27);
            dateTimePickerDD.TabIndex = 50;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(366, 441);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(196, 27);
            txtCost.TabIndex = 51;
            // 
            // Submit
            // 
            Submit.Location = new Point(275, 487);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 53;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(408, 487);
            Reset.Name = "Reset";
            Reset.Size = new Size(94, 29);
            Reset.TabIndex = 52;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // button1
            // 
            button1.Location = new Point(532, 487);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 54;
            button1.Text = "View Equipments";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1002, 697);
            Controls.Add(button1);
            Controls.Add(Submit);
            Controls.Add(Reset);
            Controls.Add(txtCost);
            Controls.Add(dateTimePickerDD);
            Controls.Add(txtMuscle);
            Controls.Add(txtDesc);
            Controls.Add(EqpName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Equipment";
            Text = "Equipment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox EqpName;
        private RichTextBox txtDesc;
        private TextBox txtMuscle;
        private DateTimePicker dateTimePickerDD;
        private TextBox txtCost;
        private Button Submit;
        private Button Reset;
        private Button button1;
    }
}