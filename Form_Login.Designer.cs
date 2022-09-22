namespace FormApp_PhoneService
{
    partial class Form_Login
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
            this.Lb_Registration = new System.Windows.Forms.Label();
            this.Bt_Registration = new System.Windows.Forms.Button();
            this.Lb_Username = new System.Windows.Forms.Label();
            this.TxtB_Username = new System.Windows.Forms.TextBox();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.TxtB_Password = new System.Windows.Forms.TextBox();
            this.Bt_Login = new System.Windows.Forms.Button();
            this.Bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Registration
            // 
            this.Lb_Registration.AutoSize = true;
            this.Lb_Registration.Location = new System.Drawing.Point(69, 305);
            this.Lb_Registration.Name = "Lb_Registration";
            this.Lb_Registration.Size = new System.Drawing.Size(127, 13);
            this.Lb_Registration.TabIndex = 0;
            this.Lb_Registration.Text = "Don\'t Have an account ?";
            // 
            // Bt_Registration
            // 
            this.Bt_Registration.Location = new System.Drawing.Point(89, 321);
            this.Bt_Registration.Name = "Bt_Registration";
            this.Bt_Registration.Size = new System.Drawing.Size(75, 23);
            this.Bt_Registration.TabIndex = 1;
            this.Bt_Registration.Text = "Register";
            this.Bt_Registration.UseVisualStyleBackColor = true;
            this.Bt_Registration.Click += new System.EventHandler(this.Bt_Registration_Click);
            // 
            // Lb_Username
            // 
            this.Lb_Username.AutoSize = true;
            this.Lb_Username.Location = new System.Drawing.Point(132, 77);
            this.Lb_Username.Name = "Lb_Username";
            this.Lb_Username.Size = new System.Drawing.Size(55, 13);
            this.Lb_Username.TabIndex = 2;
            this.Lb_Username.Text = "Username";
            // 
            // TxtB_Username
            // 
            this.TxtB_Username.Location = new System.Drawing.Point(256, 77);
            this.TxtB_Username.Name = "TxtB_Username";
            this.TxtB_Username.Size = new System.Drawing.Size(220, 20);
            this.TxtB_Username.TabIndex = 3;
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Location = new System.Drawing.Point(132, 138);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(53, 13);
            this.Lb_Password.TabIndex = 5;
            this.Lb_Password.Text = "Password";
            // 
            // TxtB_Password
            // 
            this.TxtB_Password.Location = new System.Drawing.Point(256, 131);
            this.TxtB_Password.Name = "TxtB_Password";
            this.TxtB_Password.Size = new System.Drawing.Size(222, 20);
            this.TxtB_Password.TabIndex = 7;
            // 
            // Bt_Login
            // 
            this.Bt_Login.Location = new System.Drawing.Point(256, 195);
            this.Bt_Login.Name = "Bt_Login";
            this.Bt_Login.Size = new System.Drawing.Size(220, 37);
            this.Bt_Login.TabIndex = 8;
            this.Bt_Login.Text = "Login";
            this.Bt_Login.UseVisualStyleBackColor = true;
            this.Bt_Login.Click += new System.EventHandler(this.Bt_Login_Click);
            // 
            // Bt_Close
            // 
            this.Bt_Close.Location = new System.Drawing.Point(664, 309);
            this.Bt_Close.Name = "Bt_Close";
            this.Bt_Close.Size = new System.Drawing.Size(76, 35);
            this.Bt_Close.TabIndex = 12;
            this.Bt_Close.Text = "Close App";
            this.Bt_Close.UseVisualStyleBackColor = true;
            this.Bt_Close.Click += new System.EventHandler(this.Bt_Close_Click);
            // 
            // Form_Login
            // 
            this.AcceptButton = this.Bt_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_Close);
            this.Controls.Add(this.Bt_Login);
            this.Controls.Add(this.TxtB_Password);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.TxtB_Username);
            this.Controls.Add(this.Lb_Username);
            this.Controls.Add(this.Bt_Registration);
            this.Controls.Add(this.Lb_Registration);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Registration;
        private System.Windows.Forms.Button Bt_Registration;
        private System.Windows.Forms.Label Lb_Username;
        private System.Windows.Forms.TextBox TxtB_Username;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.TextBox TxtB_Password;
        private System.Windows.Forms.Button Bt_Login;
        private System.Windows.Forms.Button Bt_Close;
    }
}