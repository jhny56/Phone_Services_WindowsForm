namespace FormApp_PhoneService
{
    partial class Form_Register
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
            this.Lb_Email = new System.Windows.Forms.Label();
            this.Lb_Username = new System.Windows.Forms.Label();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.TxtB_Email = new System.Windows.Forms.TextBox();
            this.TxtB_Password = new System.Windows.Forms.TextBox();
            this.TxtB_Username = new System.Windows.Forms.TextBox();
            this.Bt_Login = new System.Windows.Forms.Button();
            this.Lb_Login = new System.Windows.Forms.Label();
            this.Lb_ConfirmPass = new System.Windows.Forms.Label();
            this.TxtB_ConfirmPass = new System.Windows.Forms.TextBox();
            this.Bt_Close = new System.Windows.Forms.Button();
            this.Bt_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Email
            // 
            this.Lb_Email.AutoSize = true;
            this.Lb_Email.Location = new System.Drawing.Point(200, 81);
            this.Lb_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Email.Name = "Lb_Email";
            this.Lb_Email.Size = new System.Drawing.Size(37, 13);
            this.Lb_Email.TabIndex = 0;
            this.Lb_Email.Text = "Email";
            // 
            // Lb_Username
            // 
            this.Lb_Username.AutoSize = true;
            this.Lb_Username.Location = new System.Drawing.Point(200, 117);
            this.Lb_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Username.Name = "Lb_Username";
            this.Lb_Username.Size = new System.Drawing.Size(63, 13);
            this.Lb_Username.TabIndex = 1;
            this.Lb_Username.Text = "Username";
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Location = new System.Drawing.Point(200, 156);
            this.Lb_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(61, 13);
            this.Lb_Password.TabIndex = 2;
            this.Lb_Password.Text = "Password";
            // 
            // TxtB_Email
            // 
            this.TxtB_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB_Email.Location = new System.Drawing.Point(325, 81);
            this.TxtB_Email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtB_Email.Name = "TxtB_Email";
            this.TxtB_Email.Size = new System.Drawing.Size(258, 20);
            this.TxtB_Email.TabIndex = 3;
            // 
            // TxtB_Password
            // 
            this.TxtB_Password.Location = new System.Drawing.Point(325, 156);
            this.TxtB_Password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtB_Password.Name = "TxtB_Password";
            this.TxtB_Password.Size = new System.Drawing.Size(258, 20);
            this.TxtB_Password.TabIndex = 4;
            // 
            // TxtB_Username
            // 
            this.TxtB_Username.Location = new System.Drawing.Point(325, 117);
            this.TxtB_Username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtB_Username.Name = "TxtB_Username";
            this.TxtB_Username.Size = new System.Drawing.Size(258, 20);
            this.TxtB_Username.TabIndex = 5;
            // 
            // Bt_Login
            // 
            this.Bt_Login.Location = new System.Drawing.Point(53, 334);
            this.Bt_Login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bt_Login.Name = "Bt_Login";
            this.Bt_Login.Size = new System.Drawing.Size(154, 23);
            this.Bt_Login.TabIndex = 7;
            this.Bt_Login.Text = "Login";
            this.Bt_Login.UseVisualStyleBackColor = true;
            this.Bt_Login.Click += new System.EventHandler(this.Bt_Login_Click);
            // 
            // Lb_Login
            // 
            this.Lb_Login.AutoSize = true;
            this.Lb_Login.Location = new System.Drawing.Point(50, 308);
            this.Lb_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Login.Name = "Lb_Login";
            this.Lb_Login.Size = new System.Drawing.Size(160, 13);
            this.Lb_Login.TabIndex = 8;
            this.Lb_Login.Text = "Already have an account ?";
            // 
            // Lb_ConfirmPass
            // 
            this.Lb_ConfirmPass.AutoSize = true;
            this.Lb_ConfirmPass.Location = new System.Drawing.Point(200, 194);
            this.Lb_ConfirmPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_ConfirmPass.Name = "Lb_ConfirmPass";
            this.Lb_ConfirmPass.Size = new System.Drawing.Size(107, 13);
            this.Lb_ConfirmPass.TabIndex = 9;
            this.Lb_ConfirmPass.Text = "Confirm Password";
            // 
            // TxtB_ConfirmPass
            // 
            this.TxtB_ConfirmPass.Location = new System.Drawing.Point(325, 194);
            this.TxtB_ConfirmPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtB_ConfirmPass.Name = "TxtB_ConfirmPass";
            this.TxtB_ConfirmPass.Size = new System.Drawing.Size(258, 20);
            this.TxtB_ConfirmPass.TabIndex = 10;
            // 
            // Bt_Close
            // 
            this.Bt_Close.Location = new System.Drawing.Point(690, 328);
            this.Bt_Close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bt_Close.Name = "Bt_Close";
            this.Bt_Close.Size = new System.Drawing.Size(100, 35);
            this.Bt_Close.TabIndex = 11;
            this.Bt_Close.Text = "Close App";
            this.Bt_Close.UseVisualStyleBackColor = true;
            this.Bt_Close.Click += new System.EventHandler(this.Bt_Close_Click);
            // 
            // Bt_Register
            // 
            this.Bt_Register.Location = new System.Drawing.Point(325, 231);
            this.Bt_Register.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bt_Register.Name = "Bt_Register";
            this.Bt_Register.Size = new System.Drawing.Size(259, 47);
            this.Bt_Register.TabIndex = 6;
            this.Bt_Register.Text = "Register";
            this.Bt_Register.UseVisualStyleBackColor = true;
            this.Bt_Register.Click += new System.EventHandler(this.Bt_Register_Click);
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 424);
            this.Controls.Add(this.Bt_Close);
            this.Controls.Add(this.TxtB_ConfirmPass);
            this.Controls.Add(this.Lb_ConfirmPass);
            this.Controls.Add(this.Lb_Login);
            this.Controls.Add(this.Bt_Login);
            this.Controls.Add(this.Bt_Register);
            this.Controls.Add(this.TxtB_Username);
            this.Controls.Add(this.TxtB_Password);
            this.Controls.Add(this.TxtB_Email);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Lb_Username);
            this.Controls.Add(this.Lb_Email);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Register";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Email;
        private System.Windows.Forms.Label Lb_Username;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.TextBox TxtB_Email;
        private System.Windows.Forms.TextBox TxtB_Password;
        private System.Windows.Forms.TextBox TxtB_Username;
        private System.Windows.Forms.Button Bt_Register;
        private System.Windows.Forms.Button Bt_Login;
        private System.Windows.Forms.Label Lb_Login;
        private System.Windows.Forms.Label Lb_ConfirmPass;
        private System.Windows.Forms.TextBox TxtB_ConfirmPass;
        private System.Windows.Forms.Button Bt_Close;
    }
}