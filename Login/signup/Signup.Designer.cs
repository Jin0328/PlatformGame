namespace Login
{
    partial class Username_lbl
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
            signup_label = new Label();
            password_txtbox = new TextBox();
            username_txtbox = new TextBox();
            password_label = new Label();
            label1 = new Label();
            firstname_label = new Label();
            textBox1 = new TextBox();
            password_lbl = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            comfirmPassword_lbl = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            email_lbl = new Label();
            label8 = new Label();
            signup_rbtn = new Roundbtn();
            SuspendLayout();
            // 
            // signup_label
            // 
            signup_label.AutoSize = true;
            signup_label.Font = new Font("Segoe UI", 30F);
            signup_label.Location = new Point(42, 86);
            signup_label.Name = "signup_label";
            signup_label.Size = new Size(163, 54);
            signup_label.TabIndex = 1;
            signup_label.Text = "Sign Up";
            // 
            // password_txtbox
            // 
            password_txtbox.Location = new Point(52, 222);
            password_txtbox.Name = "password_txtbox";
            password_txtbox.Size = new Size(256, 23);
            password_txtbox.TabIndex = 10;
            // 
            // username_txtbox
            // 
            username_txtbox.Location = new Point(52, 174);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Size = new Size(256, 23);
            username_txtbox.TabIndex = 9;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe UI", 10F);
            password_label.Location = new Point(51, 200);
            password_label.Name = "password_label";
            password_label.Size = new Size(74, 19);
            password_label.TabIndex = 8;
            password_label.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(52, 225);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 7;
            // 
            // firstname_label
            // 
            firstname_label.AutoSize = true;
            firstname_label.Font = new Font("Segoe UI", 10F);
            firstname_label.Location = new Point(51, 152);
            firstname_label.Name = "firstname_label";
            firstname_label.Size = new Size(75, 19);
            firstname_label.TabIndex = 6;
            firstname_label.Text = "First Name";
            firstname_label.Click += username_label_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(339, 222);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(256, 23);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.Font = new Font("Segoe UI", 10F);
            password_lbl.Location = new Point(338, 198);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(67, 19);
            password_lbl.TabIndex = 12;
            password_lbl.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(346, 232);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(338, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(337, 150);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 15;
            label2.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(566, 180);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(566, 231);
            label5.Name = "label5";
            label5.Size = new Size(0, 19);
            label5.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(339, 273);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(256, 23);
            textBox3.TabIndex = 19;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // comfirmPassword_lbl
            // 
            comfirmPassword_lbl.AutoSize = true;
            comfirmPassword_lbl.Font = new Font("Segoe UI", 10F);
            comfirmPassword_lbl.Location = new Point(338, 249);
            comfirmPassword_lbl.Name = "comfirmPassword_lbl";
            comfirmPassword_lbl.Size = new Size(120, 19);
            comfirmPassword_lbl.TabIndex = 18;
            comfirmPassword_lbl.Text = "Confirm Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(346, 283);
            label7.Name = "label7";
            label7.Size = new Size(0, 19);
            label7.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(52, 273);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(256, 23);
            textBox4.TabIndex = 24;
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Font = new Font("Segoe UI", 10F);
            email_lbl.Location = new Point(51, 249);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(41, 19);
            email_lbl.TabIndex = 23;
            email_lbl.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(280, 279);
            label8.Name = "label8";
            label8.Size = new Size(0, 19);
            label8.TabIndex = 22;
            // 
            // signup_rbtn
            // 
            signup_rbtn.BackColor = Color.DarkBlue;
            signup_rbtn.FlatAppearance.BorderSize = 0;
            signup_rbtn.FlatStyle = FlatStyle.Flat;
            signup_rbtn.Font = new Font("Segoe UI", 15F);
            signup_rbtn.ForeColor = Color.White;
            signup_rbtn.Location = new Point(186, 326);
            signup_rbtn.Name = "signup_rbtn";
            signup_rbtn.Size = new Size(285, 40);
            signup_rbtn.TabIndex = 25;
            signup_rbtn.Text = "Sign Up";
            signup_rbtn.UseVisualStyleBackColor = false;
            signup_rbtn.Click += signup_rbtn_Click;
            // 
            // Username_lbl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signup_rbtn);
            Controls.Add(textBox4);
            Controls.Add(email_lbl);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(comfirmPassword_lbl);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(password_lbl);
            Controls.Add(label3);
            Controls.Add(password_txtbox);
            Controls.Add(username_txtbox);
            Controls.Add(password_label);
            Controls.Add(label1);
            Controls.Add(firstname_label);
            Controls.Add(signup_label);
            Name = "Username_lbl";
            Text = "Signup";
            Load += Signup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signup_label;
        private TextBox password_txtbox;
        private TextBox username_txtbox;
        private Label password_label;
        private Label label1;
        private Label firstname_label;
        private TextBox textBox1;
        private Label password_lbl;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label comfirmPassword_lbl;
        private Label label7;
        private TextBox textBox4;
        private Label email_lbl;
        private Label label8;
        private Roundbtn signup_rbtn;
    }
}