namespace LFA.Forum.WinForm.App
{
    partial class Form1
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_UsernameS = new System.Windows.Forms.Label();
            this.lb_FirstNameS = new System.Windows.Forms.Label();
            this.lb_LastNameS = new System.Windows.Forms.Label();
            this.lb_EmailS = new System.Windows.Forms.Label();
            this.lb_PasswordS = new System.Windows.Forms.Label();
            this.lb_RePasswordS = new System.Windows.Forms.Label();
            this.txt_UserNameS = new System.Windows.Forms.TextBox();
            this.txt_FirstNameS = new System.Windows.Forms.TextBox();
            this.txt_LastNameS = new System.Windows.Forms.TextBox();
            this.txt_EmailS = new System.Windows.Forms.TextBox();
            this.txt_pswdS = new System.Windows.Forms.TextBox();
            this.txt_RePswdS = new System.Windows.Forms.TextBox();
            this.btn_Signup = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(2, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(963, 449);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Submit);
            this.tabPage1.Controls.Add(this.txt_Password);
            this.tabPage1.Controls.Add(this.txt_Username);
            this.tabPage1.Controls.Add(this.lb_Password);
            this.tabPage1.Controls.Add(this.lb_Username);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(955, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.Location = new System.Drawing.Point(145, 79);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(111, 25);
            this.lb_Username.TabIndex = 1;
            this.lb_Username.Text = "UserName:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(145, 123);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(104, 25);
            this.lb_Password.TabIndex = 1;
            this.lb_Password.Text = "Password:";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(262, 79);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(202, 26);
            this.txt_Username.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(262, 123);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(202, 26);
            this.txt_Password.TabIndex = 2;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(308, 163);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(89, 29);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Signup);
            this.tabPage2.Controls.Add(this.txt_RePswdS);
            this.tabPage2.Controls.Add(this.txt_pswdS);
            this.tabPage2.Controls.Add(this.txt_EmailS);
            this.tabPage2.Controls.Add(this.txt_LastNameS);
            this.tabPage2.Controls.Add(this.txt_FirstNameS);
            this.tabPage2.Controls.Add(this.txt_UserNameS);
            this.tabPage2.Controls.Add(this.lb_RePasswordS);
            this.tabPage2.Controls.Add(this.lb_PasswordS);
            this.tabPage2.Controls.Add(this.lb_EmailS);
            this.tabPage2.Controls.Add(this.lb_LastNameS);
            this.tabPage2.Controls.Add(this.lb_FirstNameS);
            this.tabPage2.Controls.Add(this.lb_UsernameS);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(955, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SignUp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_UsernameS
            // 
            this.lb_UsernameS.AutoSize = true;
            this.lb_UsernameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UsernameS.Location = new System.Drawing.Point(50, 43);
            this.lb_UsernameS.Name = "lb_UsernameS";
            this.lb_UsernameS.Size = new System.Drawing.Size(111, 25);
            this.lb_UsernameS.TabIndex = 0;
            this.lb_UsernameS.Text = "UserName:";
            // 
            // lb_FirstNameS
            // 
            this.lb_FirstNameS.AutoSize = true;
            this.lb_FirstNameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FirstNameS.Location = new System.Drawing.Point(49, 96);
            this.lb_FirstNameS.Name = "lb_FirstNameS";
            this.lb_FirstNameS.Size = new System.Drawing.Size(112, 25);
            this.lb_FirstNameS.TabIndex = 0;
            this.lb_FirstNameS.Text = "First Name:";
            // 
            // lb_LastNameS
            // 
            this.lb_LastNameS.AutoSize = true;
            this.lb_LastNameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LastNameS.Location = new System.Drawing.Point(50, 142);
            this.lb_LastNameS.Name = "lb_LastNameS";
            this.lb_LastNameS.Size = new System.Drawing.Size(112, 25);
            this.lb_LastNameS.TabIndex = 0;
            this.lb_LastNameS.Text = "Last Name:";
            // 
            // lb_EmailS
            // 
            this.lb_EmailS.AutoSize = true;
            this.lb_EmailS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmailS.Location = new System.Drawing.Point(50, 184);
            this.lb_EmailS.Name = "lb_EmailS";
            this.lb_EmailS.Size = new System.Drawing.Size(87, 25);
            this.lb_EmailS.TabIndex = 0;
            this.lb_EmailS.Text = "Email Id:";
            // 
            // lb_PasswordS
            // 
            this.lb_PasswordS.AutoSize = true;
            this.lb_PasswordS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasswordS.Location = new System.Drawing.Point(50, 243);
            this.lb_PasswordS.Name = "lb_PasswordS";
            this.lb_PasswordS.Size = new System.Drawing.Size(104, 25);
            this.lb_PasswordS.TabIndex = 0;
            this.lb_PasswordS.Text = "Password:";
            // 
            // lb_RePasswordS
            // 
            this.lb_RePasswordS.AutoSize = true;
            this.lb_RePasswordS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RePasswordS.Location = new System.Drawing.Point(50, 286);
            this.lb_RePasswordS.Name = "lb_RePasswordS";
            this.lb_RePasswordS.Size = new System.Drawing.Size(135, 25);
            this.lb_RePasswordS.TabIndex = 0;
            this.lb_RePasswordS.Text = "Re-Password:";
            // 
            // txt_UserNameS
            // 
            this.txt_UserNameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserNameS.Location = new System.Drawing.Point(224, 43);
            this.txt_UserNameS.Multiline = true;
            this.txt_UserNameS.Name = "txt_UserNameS";
            this.txt_UserNameS.Size = new System.Drawing.Size(182, 24);
            this.txt_UserNameS.TabIndex = 1;
            // 
            // txt_FirstNameS
            // 
            this.txt_FirstNameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstNameS.Location = new System.Drawing.Point(224, 96);
            this.txt_FirstNameS.Multiline = true;
            this.txt_FirstNameS.Name = "txt_FirstNameS";
            this.txt_FirstNameS.Size = new System.Drawing.Size(182, 24);
            this.txt_FirstNameS.TabIndex = 1;
            // 
            // txt_LastNameS
            // 
            this.txt_LastNameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastNameS.Location = new System.Drawing.Point(224, 142);
            this.txt_LastNameS.Multiline = true;
            this.txt_LastNameS.Name = "txt_LastNameS";
            this.txt_LastNameS.Size = new System.Drawing.Size(182, 24);
            this.txt_LastNameS.TabIndex = 1;
            // 
            // txt_EmailS
            // 
            this.txt_EmailS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmailS.Location = new System.Drawing.Point(224, 184);
            this.txt_EmailS.Multiline = true;
            this.txt_EmailS.Name = "txt_EmailS";
            this.txt_EmailS.Size = new System.Drawing.Size(182, 24);
            this.txt_EmailS.TabIndex = 1;
            // 
            // txt_pswdS
            // 
            this.txt_pswdS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pswdS.Location = new System.Drawing.Point(224, 243);
            this.txt_pswdS.Multiline = true;
            this.txt_pswdS.Name = "txt_pswdS";
            this.txt_pswdS.Size = new System.Drawing.Size(182, 24);
            this.txt_pswdS.TabIndex = 1;
            // 
            // txt_RePswdS
            // 
            this.txt_RePswdS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RePswdS.Location = new System.Drawing.Point(224, 286);
            this.txt_RePswdS.Multiline = true;
            this.txt_RePswdS.Name = "txt_RePswdS";
            this.txt_RePswdS.Size = new System.Drawing.Size(182, 24);
            this.txt_RePswdS.TabIndex = 1;
            // 
            // btn_Signup
            // 
            this.btn_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signup.Location = new System.Drawing.Point(203, 353);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(83, 31);
            this.btn_Signup.TabIndex = 2;
            this.btn_Signup.Text = "Sign up";
            this.btn_Signup.UseVisualStyleBackColor = true;
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 446);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "LFA_Forum";
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_RePswdS;
        private System.Windows.Forms.TextBox txt_pswdS;
        private System.Windows.Forms.TextBox txt_EmailS;
        private System.Windows.Forms.TextBox txt_LastNameS;
        private System.Windows.Forms.TextBox txt_FirstNameS;
        private System.Windows.Forms.TextBox txt_UserNameS;
        private System.Windows.Forms.Label lb_RePasswordS;
        private System.Windows.Forms.Label lb_PasswordS;
        private System.Windows.Forms.Label lb_EmailS;
        private System.Windows.Forms.Label lb_LastNameS;
        private System.Windows.Forms.Label lb_FirstNameS;
        private System.Windows.Forms.Label lb_UsernameS;
        private System.Windows.Forms.Button btn_Signup;
    }
}

