namespace nath
{
    partial class registerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            txtpassword = new TextBox();
            txtmiddlename = new TextBox();
            bday = new DateTimePicker();
            txtlastname = new TextBox();
            btnclose = new Button();
            btnregister = new Button();
            btnlogin = new Button();
            chShowpass = new CheckBox();
            txtfirstname = new TextBox();
            txtusername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(txtpassword);
            panel3.Controls.Add(txtmiddlename);
            panel3.Controls.Add(bday);
            panel3.Controls.Add(txtlastname);
            panel3.Controls.Add(btnclose);
            panel3.Controls.Add(btnregister);
            panel3.Controls.Add(btnlogin);
            panel3.Controls.Add(chShowpass);
            panel3.Controls.Add(txtfirstname);
            panel3.Controls.Add(txtusername);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(376, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(730, 527);
            panel3.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(389, 311);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 22;
            label9.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 311);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 21;
            label8.Text = "Section";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(387, 239);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 20;
            label7.Text = "Course";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 239);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 19;
            label6.Text = "Middle name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 84);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 18;
            label5.Text = "Lastname";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ACT", "HM", "BSOA" });
            comboBox2.Location = new Point(387, 265);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(256, 28);
            comboBox2.TabIndex = 17;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.KeyPress += comboBox2_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(48, 334);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(256, 28);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.KeyPress += comboBox1_KeyPress;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(387, 334);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(256, 27);
            txtpassword.TabIndex = 15;
            // 
            // txtmiddlename
            // 
            txtmiddlename.Location = new Point(48, 262);
            txtmiddlename.Name = "txtmiddlename";
            txtmiddlename.Size = new Size(256, 27);
            txtmiddlename.TabIndex = 14;
            // 
            // bday
            // 
            bday.Location = new Point(389, 178);
            bday.Name = "bday";
            bday.Size = new Size(254, 27);
            bday.TabIndex = 12;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(387, 107);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(256, 27);
            txtlastname.TabIndex = 11;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(670, 3);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(54, 29);
            btnclose.TabIndex = 3;
            btnclose.Text = "x";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // btnregister
            // 
            btnregister.BackColor = SystemColors.ButtonFace;
            btnregister.FlatStyle = FlatStyle.Flat;
            btnregister.ForeColor = SystemColors.ActiveCaptionText;
            btnregister.Location = new Point(48, 409);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(595, 42);
            btnregister.TabIndex = 9;
            btnregister.Text = "Register Account";
            btnregister.UseVisualStyleBackColor = false;
            btnregister.Click += btnregister_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.Highlight;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = SystemColors.ButtonFace;
            btnlogin.Location = new Point(48, 460);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(595, 47);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // chShowpass
            // 
            chShowpass.AutoSize = true;
            chShowpass.Location = new Point(387, 367);
            chShowpass.Name = "chShowpass";
            chShowpass.Size = new Size(132, 24);
            chShowpass.TabIndex = 7;
            chShowpass.Text = "Show Password";
            chShowpass.UseVisualStyleBackColor = true;
            chShowpass.CheckedChanged += chShowpass_CheckedChanged;
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(48, 180);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(256, 27);
            txtfirstname.TabIndex = 6;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(48, 107);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(256, 27);
            txtusername.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 157);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Firstname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 84);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 3;
            label3.Text = "Username/Student Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(295, 20);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 2;
            label2.Text = "Registration";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(33, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 524);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(88, 265);
            label1.Name = "label1";
            label1.Size = new Size(161, 80);
            label1.TabIndex = 3;
            label1.Text = "Welcome to the \r\nCLARK COLLEGE\r\nStudent Management\r\nSystem\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(77, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(187, 168);
            panel5.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(340, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 454);
            panel2.TabIndex = 1;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1138, 598);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "registerForm";
            Text = "registerForm";
            Load += registerForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox txtpassword;
        private TextBox txtmiddlename;
        private DateTimePicker bday;
        private TextBox txtlastname;
        private Button btnclose;
        private Button btnregister;
        private Button btnlogin;
        private CheckBox chShowpass;
        private TextBox txtfirstname;
        private TextBox txtusername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Panel panel5;
        private Panel panel2;
    }
}