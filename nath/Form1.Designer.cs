namespace nath
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel3 = new Panel();
            btnclose = new Button();
            btnregister = new Button();
            btnlogin = new Button();
            chShowpass = new CheckBox();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
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
            panel3.Controls.Add(btnclose);
            panel3.Controls.Add(btnregister);
            panel3.Controls.Add(btnlogin);
            panel3.Controls.Add(chShowpass);
            panel3.Controls.Add(txtpassword);
            panel3.Controls.Add(txtusername);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(603, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 454);
            panel3.TabIndex = 4;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(288, 0);
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
            btnregister.Location = new Point(57, 330);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(231, 30);
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
            btnlogin.Location = new Point(57, 285);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(231, 30);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // chShowpass
            // 
            chShowpass.AutoSize = true;
            chShowpass.Location = new Point(48, 219);
            chShowpass.Name = "chShowpass";
            chShowpass.Size = new Size(132, 24);
            chShowpass.TabIndex = 7;
            chShowpass.Text = "Show Password";
            chShowpass.UseVisualStyleBackColor = true;
            chShowpass.CheckedChanged += chShowpass_CheckedChanged;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(48, 180);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(256, 27);
            txtpassword.TabIndex = 6;
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
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Password";
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
            label2.Location = new Point(114, 24);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 2;
            label2.Text = "Log in your account";
            // 
            // panel4
            // 
            panel4.Location = new Point(340, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(343, 454);
            panel4.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(260, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 454);
            panel1.TabIndex = 3;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 684);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnclose;
        private Button btnregister;
        private Button btnlogin;
        private CheckBox chShowpass;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Panel panel1;
        private Label label1;
        private Panel panel5;
        private Panel panel2;
    }
}
