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
using System.Text.RegularExpressions;



namespace FormApp_PhoneService
{

    
    public partial class Form_Register : Form
    {
        myLibrary mylib = new myLibrary();

        //On Load
        public Form_Register()
        {
            InitializeComponent();
        }

        //Registration process
        private void Bt_Register_Click(object sender, EventArgs e)
        {          
            if (CheckInputValidity(TxtB_Email.Text, TxtB_Username.Text, TxtB_Password.Text, TxtB_ConfirmPass.Text))
            {
                Random random = new Random();
                int pin = random.Next(10000, 100000); //create a pin number for email registration between 10k and 100k

                try
                {
                    string Subject = "PhoneServices Registration Pin Number";
                    string Body = "This is your pin number : " + pin.ToString();
                    mylib.SendEmail(TxtB_Email.Text, Subject, Body); //send pin code to the user email

                    //hide registration form and open the confirmation form and insert email,username,password,pin
                    this.Hide();
                    Form_RegistrationConfiramtion form_RegistrationConfiramtion = new Form_RegistrationConfiramtion(TxtB_Email.Text, TxtB_Username.Text, TxtB_Password.Text, pin);
                    form_RegistrationConfiramtion.ShowDialog();

                }
                catch (Exception ex) //in case of errors in sending email msgs
                {
                    MessageBox.Show(ex.Message);
                }

            }                    
        }

        //Checking Input Validity for registration
        private bool IsValidEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase); //search for an email pattern via regex while ignoring uppercase letters
            return regex.IsMatch(email); //return 1 if the email matches the pattern
        }
        private bool CheckInputValidity(string email, string username, string password, string confirmationPassword)
        {
            if (!EmailIsRegistered(email))
            { // check is email already registered

                if (IsValidEmail(email))
                {  //check if email and username are correct

                    if (!UsernameIsTaken(username) && username != "")
                    {

                        if (password != "")
                        {  //check if a password is inserted

                            if (password == confirmationPassword)
                            { //check if confirmed pass = pass

                                return true; //everything is valid
                            }
                            else
                            {
                                MessageBox.Show("Your Confirmed password is different than your password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please insert a Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username is taken.");
                    }
                }
                else
                {
                    MessageBox.Show("Please insert a valid email and a username");
                }
            }
            else
            {
                MessageBox.Show("You already have an accout with this email");
            }

            return false;
        }
        private bool EmailIsRegistered(string email)
        {
            DataTable dt = mylib.SelectSqlDataTable("SELECT * FROM TB_Users WHERE Email = '" + email + "'");

            if(dt.Rows.Count > 0) //there already exist a row with this email
            {
                return true;
            }

            return false;
        }
        private bool UsernameIsTaken(string username)
        {        
            DataTable dt = mylib.SelectSqlDataTable("SELECT * FROM TB_Users WHERE Username = '" + username + "' ");

            if (dt.Rows.Count > 0) //there already exist a row with this email
            {
                return true;
            }

            return false;
        }

        //Change forms buttons
        private void Bt_Login_Click(object sender, EventArgs e)
        {
            // open the login form
            this.Hide();
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog();
        }
        private void Bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
