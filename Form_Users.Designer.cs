namespace FormApp_PhoneService
{
    partial class Form_Users
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
            this.Bt_Close = new System.Windows.Forms.Button();
            this.Lb_WelcomeUser = new System.Windows.Forms.Label();
            this.Lb_Brand = new System.Windows.Forms.Label();
            this.DtGrid_Phone = new System.Windows.Forms.DataGridView();
            this.Lb_Price = new System.Windows.Forms.Label();
            this.Lb_ProductionYear = new System.Windows.Forms.Label();
            this.TxtB_Price1 = new System.Windows.Forms.TextBox();
            this.TxtB_ProductionYear = new System.Windows.Forms.TextBox();
            this.Lb_And = new System.Windows.Forms.Label();
            this.TxtB_Price2 = new System.Windows.Forms.TextBox();
            this.Bt_Buy = new System.Windows.Forms.Button();
            this.Bt_Search = new System.Windows.Forms.Button();
            this.Bt_LogOut = new System.Windows.Forms.Button();
            this.CB_Brand = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrid_Phone)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_Close
            // 
            this.Bt_Close.Location = new System.Drawing.Point(844, 373);
            this.Bt_Close.Name = "Bt_Close";
            this.Bt_Close.Size = new System.Drawing.Size(76, 35);
            this.Bt_Close.TabIndex = 0;
            this.Bt_Close.Text = "Close App";
            this.Bt_Close.UseVisualStyleBackColor = true;
            this.Bt_Close.Click += new System.EventHandler(this.Bt_Close_Click);
            // 
            // Lb_WelcomeUser
            // 
            this.Lb_WelcomeUser.AutoSize = true;
            this.Lb_WelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_WelcomeUser.Location = new System.Drawing.Point(246, 9);
            this.Lb_WelcomeUser.Name = "Lb_WelcomeUser";
            this.Lb_WelcomeUser.Size = new System.Drawing.Size(338, 31);
            this.Lb_WelcomeUser.TabIndex = 1;
            this.Lb_WelcomeUser.Text = "Welcome user \"Username\"";
            // 
            // Lb_Brand
            // 
            this.Lb_Brand.AutoSize = true;
            this.Lb_Brand.Location = new System.Drawing.Point(125, 79);
            this.Lb_Brand.Name = "Lb_Brand";
            this.Lb_Brand.Size = new System.Drawing.Size(86, 13);
            this.Lb_Brand.TabIndex = 2;
            this.Lb_Brand.Text = "Search by Brand";
            // 
            // DtGrid_Phone
            // 
            this.DtGrid_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrid_Phone.Location = new System.Drawing.Point(12, 183);
            this.DtGrid_Phone.Name = "DtGrid_Phone";
            this.DtGrid_Phone.ReadOnly = true;
            this.DtGrid_Phone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGrid_Phone.Size = new System.Drawing.Size(826, 282);
            this.DtGrid_Phone.TabIndex = 3;
            this.DtGrid_Phone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrid_Phone_CellContentClick);
            this.DtGrid_Phone.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrid_Phone_CellValueChanged);
            this.DtGrid_Phone.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DtGrid_Phone_UserDeletingRow);
            // 
            // Lb_Price
            // 
            this.Lb_Price.AutoSize = true;
            this.Lb_Price.Location = new System.Drawing.Point(125, 110);
            this.Lb_Price.Name = "Lb_Price";
            this.Lb_Price.Size = new System.Drawing.Size(127, 13);
            this.Lb_Price.TabIndex = 4;
            this.Lb_Price.Text = "Search by Price Between";
            // 
            // Lb_ProductionYear
            // 
            this.Lb_ProductionYear.AutoSize = true;
            this.Lb_ProductionYear.Location = new System.Drawing.Point(125, 142);
            this.Lb_ProductionYear.Name = "Lb_ProductionYear";
            this.Lb_ProductionYear.Size = new System.Drawing.Size(141, 13);
            this.Lb_ProductionYear.TabIndex = 5;
            this.Lb_ProductionYear.Text = "Search by Production year >";
            // 
            // TxtB_Price1
            // 
            this.TxtB_Price1.Location = new System.Drawing.Point(301, 103);
            this.TxtB_Price1.Name = "TxtB_Price1";
            this.TxtB_Price1.Size = new System.Drawing.Size(98, 20);
            this.TxtB_Price1.TabIndex = 7;
            this.TxtB_Price1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_Price1_KeyPress);
            // 
            // TxtB_ProductionYear
            // 
            this.TxtB_ProductionYear.Location = new System.Drawing.Point(301, 135);
            this.TxtB_ProductionYear.Name = "TxtB_ProductionYear";
            this.TxtB_ProductionYear.Size = new System.Drawing.Size(242, 20);
            this.TxtB_ProductionYear.TabIndex = 8;
            this.TxtB_ProductionYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_ProductionYear_KeyPress);
            // 
            // Lb_And
            // 
            this.Lb_And.AutoSize = true;
            this.Lb_And.Location = new System.Drawing.Point(405, 106);
            this.Lb_And.Name = "Lb_And";
            this.Lb_And.Size = new System.Drawing.Size(26, 13);
            this.Lb_And.TabIndex = 9;
            this.Lb_And.Text = "And";
            // 
            // TxtB_Price2
            // 
            this.TxtB_Price2.Location = new System.Drawing.Point(437, 103);
            this.TxtB_Price2.Name = "TxtB_Price2";
            this.TxtB_Price2.Size = new System.Drawing.Size(106, 20);
            this.TxtB_Price2.TabIndex = 10;
            this.TxtB_Price2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_Price2_KeyPress);
            // 
            // Bt_Buy
            // 
            this.Bt_Buy.Location = new System.Drawing.Point(844, 215);
            this.Bt_Buy.Name = "Bt_Buy";
            this.Bt_Buy.Size = new System.Drawing.Size(75, 36);
            this.Bt_Buy.TabIndex = 11;
            this.Bt_Buy.Text = "BUY";
            this.Bt_Buy.UseVisualStyleBackColor = true;
            this.Bt_Buy.Click += new System.EventHandler(this.Bt_Buy_Click);
            // 
            // Bt_Search
            // 
            this.Bt_Search.Location = new System.Drawing.Point(585, 92);
            this.Bt_Search.Name = "Bt_Search";
            this.Bt_Search.Size = new System.Drawing.Size(75, 42);
            this.Bt_Search.TabIndex = 12;
            this.Bt_Search.Text = "Search";
            this.Bt_Search.UseVisualStyleBackColor = true;
            this.Bt_Search.Click += new System.EventHandler(this.Bt_Search_Click);
            // 
            // Bt_LogOut
            // 
            this.Bt_LogOut.Location = new System.Drawing.Point(844, 295);
            this.Bt_LogOut.Name = "Bt_LogOut";
            this.Bt_LogOut.Size = new System.Drawing.Size(75, 38);
            this.Bt_LogOut.TabIndex = 13;
            this.Bt_LogOut.Text = "Log Out";
            this.Bt_LogOut.UseVisualStyleBackColor = true;
            this.Bt_LogOut.Click += new System.EventHandler(this.Bt_LogOut_Click);
            // 
            // CB_Brand
            // 
            this.CB_Brand.FormattingEnabled = true;
            this.CB_Brand.Location = new System.Drawing.Point(301, 71);
            this.CB_Brand.Name = "CB_Brand";
            this.CB_Brand.Size = new System.Drawing.Size(242, 21);
            this.CB_Brand.TabIndex = 14;
            // 
            // Form_Users
            // 
            this.AcceptButton = this.Bt_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 477);
            this.Controls.Add(this.CB_Brand);
            this.Controls.Add(this.Bt_LogOut);
            this.Controls.Add(this.Bt_Search);
            this.Controls.Add(this.Bt_Buy);
            this.Controls.Add(this.TxtB_Price2);
            this.Controls.Add(this.Lb_And);
            this.Controls.Add(this.TxtB_ProductionYear);
            this.Controls.Add(this.TxtB_Price1);
            this.Controls.Add(this.Lb_ProductionYear);
            this.Controls.Add(this.Lb_Price);
            this.Controls.Add(this.DtGrid_Phone);
            this.Controls.Add(this.Lb_Brand);
            this.Controls.Add(this.Lb_WelcomeUser);
            this.Controls.Add(this.Bt_Close);
            this.Name = "Form_Users";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrid_Phone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Close;
        private System.Windows.Forms.Label Lb_WelcomeUser;
        private System.Windows.Forms.Label Lb_Brand;
        private System.Windows.Forms.DataGridView DtGrid_Phone;
        private System.Windows.Forms.Label Lb_Price;
        private System.Windows.Forms.Label Lb_ProductionYear;
        private System.Windows.Forms.TextBox TxtB_Price1;
        private System.Windows.Forms.TextBox TxtB_ProductionYear;
        private System.Windows.Forms.Label Lb_And;
        private System.Windows.Forms.TextBox TxtB_Price2;
        private System.Windows.Forms.Button Bt_Buy;
        private System.Windows.Forms.Button Bt_Search;
        private System.Windows.Forms.Button Bt_LogOut;
        private System.Windows.Forms.ComboBox CB_Brand;
    }
}

