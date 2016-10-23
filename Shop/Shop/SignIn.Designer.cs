namespace Shop
{
    partial class SignIn
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
            this.button_signIn = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_signIn
            // 
            this.button_signIn.BackColor = System.Drawing.Color.LightYellow;
            this.button_signIn.Enabled = false;
            this.button_signIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signIn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_signIn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_signIn.Location = new System.Drawing.Point(48, 227);
            this.button_signIn.Name = "button_signIn";
            this.button_signIn.Size = new System.Drawing.Size(95, 38);
            this.button_signIn.TabIndex = 0;
            this.button_signIn.Text = "SignIn";
            this.button_signIn.UseVisualStyleBackColor = false;
            this.button_signIn.Click += new System.EventHandler(this.button_signIn_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.ForeColor = System.Drawing.Color.YellowGreen;
            this.textBox_login.Location = new System.Drawing.Point(70, 100);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(158, 29);
            this.textBox_login.TabIndex = 1;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(70, 172);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(158, 29);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(89, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // comboBox_role
            // 
            this.comboBox_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "касир",
            "адмін"});
            this.comboBox_role.Location = new System.Drawing.Point(71, 34);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(157, 32);
            this.comboBox_role.TabIndex = 5;
            this.comboBox_role.SelectedIndexChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(79, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Who are you?";
            // 
            // button_registration
            // 
            this.button_registration.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registration.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_registration.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_registration.Location = new System.Drawing.Point(149, 227);
            this.button_registration.Name = "button_registration";
            this.button_registration.Size = new System.Drawing.Size(104, 38);
            this.button_registration.TabIndex = 7;
            this.button_registration.Text = "Registration";
            this.button_registration.UseVisualStyleBackColor = false;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // SignIn
            // 
            this.AcceptButton = this.button_signIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.button_registration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_signIn);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_signIn;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_registration;
    }
}

