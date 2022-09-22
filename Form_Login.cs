using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_PhoneService
{
    public partial class Form_Login : Form
    {
        myLibrary mylib = new myLibrary();

        // On Load
        public Form_Login()
        {
            InitializeComponent();
        }
        
        //Login into account
        private void Bt_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = TxtB_Username.Text;
                string password = TxtB_Password.Text;

                Form_Users form_Users = new Form_Users(username);
                Form_Admin form_Admin = new Form_Admin(username);

                if (UsernameandPasswordValid(username, password)) //check if username and password are correct
                {                                      
                    if (mylib.IsAdmin(username)) //check if the user is an admin, open admin form if admin
                    {
                        this.Hide();
                        form_Admin.ShowDialog();
                        this.Close();
                    }
                    else //open user form if user
                    {
                        this.Hide();                        
                        form_Users.ShowDialog();
                        this.Close();
                    }
                }
                else // there is no email and password in the table
                {
                    MessageBox.Show("Invalid Username or Password ");
                }
            }
            catch
            {
                MessageBox.Show("Error With Login Values");
            }
        }

        //Check acccount validity
        private bool UsernameandPasswordValid(string username,string password)
        {        
            DataTable dt = mylib.SelectSqlDataTable("SELECT * FROM TB_Users WHERE Username = '" + username + "' AND Password = '" + password + "' ");

            if (dt.Rows.Count > 0) //there exist a username and password 
            {
                return true;
            }

            return false;
        }

        //Change Forms Buttons
        private void Bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Bt_Registration_Click(object sender, EventArgs e)
        {

            //open register form
            this.Hide();
            Form_Register form_Register = new Form_Register();
            form_Register.ShowDialog();
            this.Close();
        }

    }
}
