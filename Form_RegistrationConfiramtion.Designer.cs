namespace FormApp_PhoneService
{
    partial class Form_RegistrationConfiramtion
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
            this.Lb_PinNumber = new System.Windows.Forms.Label();
            this.TxtB_PinNumber = new System.Windows.Forms.TextBox();
            this.Bt_SubmitPin = new System.Windows.Forms.Button();
            this.Bt_Close = new System.Windows.Forms.Button();
            this.Bt_Login = new System.Windows.Forms.Button();
            this.Bt_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_PinNumber
            // 
            this.Lb_PinNumber.AutoSize = true;
            this.Lb_PinNumber.Location = new System.Drawing.Point(124, 175);
            this.Lb_PinNumber.Name = "Lb_PinNumber";
            this.Lb_PinNumber.Size = new System.Drawing.Size(144, 13);
            this.Lb_PinNumber.TabIndex = 0;
            this.Lb_PinNumber.Text = "Please enter your pin number";
            // 
            // TxtB_PinNumber
            // 
            this.TxtB_PinNumber.Location = new System.Drawing.Point(315, 175);
            this.TxtB_PinNumber.Name = "TxtB_PinNumber";
            this.TxtB_PinNumber.Size = new System.Drawing.Size(168, 20);
            this.TxtB_PinNumber.TabIndex = 1;
            // 
            // Bt_SubmitPin
            // 
            this.Bt_SubmitPin.Location = new System.Drawing.Point(538, 175);
            this.Bt_SubmitPin.Name = "Bt_SubmitPin";
            this.Bt_SubmitPin.Size = new System.Drawing.Size(81, 21);
            this.Bt_SubmitPin.TabIndex = 2;
            this.Bt_SubmitPin.Text = "Submit";
            this.Bt_SubmitPin.UseVisualStyleBackColor = true;
            this.Bt_SubmitPin.Click += new System.EventHandler(this.Bt_SubmitPin_Click);
            // 
            // Bt_Close
            // 
            this.Bt_Close.Location = new System.Drawing.Point(610, 320);
            this.Bt_Close.Name = "Bt_Close";
            this.Bt_Close.Size = new System.Drawing.Size(63, 36);
            this.Bt_Close.TabIndex = 3;
            this.Bt_Close.Text = "Close";
            this.Bt_Close.UseVisualStyleBackColor = true;
            this.Bt_Close.Click += new System.EventHandler(this.Bt_Close_Click);
            // 
            // Bt_Login
            // 
            this.Bt_Login.Location = new System.Drawing.Point(372, 320);
            this.Bt_Login.Name = "Bt_Login";
            this.Bt_Login.Size = new System.Drawing.Size(80, 36);
            this.Bt_Login.TabIndex = 4;
            this.Bt_Login.Text = "Login";
            this.Bt_Login.UseVisualStyleBackColor = true;
            this.Bt_Login.Click += new System.EventHandler(this.Bt_Login_Click);
            // 
            // Bt_Register
            // 
            this.Bt_Register.Location = new System.Drawing.Point(174, 320);
            this.Bt_Register.Name = "Bt_Register";
            this.Bt_Register.Size = new System.Drawing.Size(80, 36);
            this.Bt_Register.TabIndex = 5;
            this.Bt_Register.Text = "Register";
            this.Bt_Register.UseVisualStyleBackColor = true;
            this.Bt_Register.Click += new System.EventHandler(this.Bt_Register_Click);
            // 
            // Form_RegistrationConfiramtion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_Register);
            this.Controls.Add(this.Bt_Login);
            this.Controls.Add(this.Bt_Close);
            this.Controls.Add(this.Bt_SubmitPin);
            this.Controls.Add(this.TxtB_PinNumber);
            this.Controls.Add(this.Lb_PinNumber);
            this.Name = "Form_RegistrationConfiramtion";
            this.Text = "Form_RegistrationConfiramtion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_PinNumber;
        private System.Windows.Forms.TextBox TxtB_PinNumber;
        private System.Windows.Forms.Button Bt_SubmitPin;
        private System.Windows.Forms.Button Bt_Close;
        private System.Windows.Forms.Button Bt_Login;
        private System.Windows.Forms.Button Bt_Register;
    }
}