namespace FormApp_PhoneService
{
    partial class Form_Admin
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
            this.Bt_Phones = new System.Windows.Forms.Button();
            this.Bt_Close = new System.Windows.Forms.Button();
            this.Bt_Sales = new System.Windows.Forms.Button();
            this.Bt_Users = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_Phones
            // 
            this.Bt_Phones.Location = new System.Drawing.Point(351, 112);
            this.Bt_Phones.Name = "Bt_Phones";
            this.Bt_Phones.Size = new System.Drawing.Size(114, 41);
            this.Bt_Phones.TabIndex = 0;
            this.Bt_Phones.Text = "Edit Phones";
            this.Bt_Phones.UseVisualStyleBackColor = true;
            this.Bt_Phones.Click += new System.EventHandler(this.Bt_Edit_Click);
            // 
            // Bt_Close
            // 
            this.Bt_Close.Location = new System.Drawing.Point(610, 337);
            this.Bt_Close.Name = "Bt_Close";
            this.Bt_Close.Size = new System.Drawing.Size(75, 23);
            this.Bt_Close.TabIndex = 2;
            this.Bt_Close.Text = "Close";
            this.Bt_Close.UseVisualStyleBackColor = true;
            this.Bt_Close.Click += new System.EventHandler(this.Bt_Close_Click);
            // 
            // Bt_Sales
            // 
            this.Bt_Sales.Location = new System.Drawing.Point(351, 170);
            this.Bt_Sales.Name = "Bt_Sales";
            this.Bt_Sales.Size = new System.Drawing.Size(114, 41);
            this.Bt_Sales.TabIndex = 3;
            this.Bt_Sales.Text = "Check Sales";
            this.Bt_Sales.UseVisualStyleBackColor = true;
            // 
            // Bt_Users
            // 
            this.Bt_Users.Location = new System.Drawing.Point(351, 232);
            this.Bt_Users.Name = "Bt_Users";
            this.Bt_Users.Size = new System.Drawing.Size(114, 39);
            this.Bt_Users.TabIndex = 4;
            this.Bt_Users.Text = "Check Users";
            this.Bt_Users.UseVisualStyleBackColor = true;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_Users);
            this.Controls.Add(this.Bt_Sales);
            this.Controls.Add(this.Bt_Close);
            this.Controls.Add(this.Bt_Phones);
            this.Name = "Form_Admin";
            this.Text = "Form_Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_Phones;
        private System.Windows.Forms.Button Bt_Close;
        private System.Windows.Forms.Button Bt_Sales;
        private System.Windows.Forms.Button Bt_Users;
    }
}