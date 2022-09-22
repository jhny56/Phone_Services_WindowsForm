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
    public partial class Form_RegistrationConfiramtion : Form
    {
        string Email, Username, Password;
        int Pin;

        //On Load
        public Form_RegistrationConfiramtion(string email, string username, string password, int pin)
        {
            InitializeComponent();

            //Get email, username, password at initiation in the Registration Form
            Email = email;
            Username =  username;
            Password = password;
            Pin = pin;  

        }

        //Registering User
        private void Bt_SubmitPin_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtB_PinNumber.Text == Pin.ToString()){

                    RegisteringUserInTable(Email, Username, Password); //adding info to sql table
                    MessageBox.Show("Registration \n Email : " + Email + "\n Username : " + Username + "\n Password : " + Password + "\n Succesfull");
                }
                else{

                    MessageBox.Show("Wrong Pin number");
                }
            }
            catch{ MessageBox.Show("The email already registered! Could not insert email."); }
        }
        private void RegisteringUserInTable(string email, string username, string password)
        {
            //opening connection to database
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-G616HPC; Initial Catalog = DB_PhoneService; Integrated Security = True; Pooling = False");
            con.Open();

            //wrting command
            SqlCommand cmd = new SqlCommand("INSERT INTO TB_Users VALUES(@Email,@Username,@Password,0)", con);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.ExecuteNonQuery(); //command execution and inserting the values

            con.Close(); //closing connection

        }
      
        //Changing Forms Buttons
        private void Bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Bt_Login_Click(object sender, EventArgs e)
        {
            //open login form
            this.Hide();
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog();
            this.Close();
        }
        private void Bt_Register_Click(object sender, EventArgs e)
        {
            //open registration form
            this.Hide();
            Form_Register form_Register = new Form_Register();
            form_Register.ShowDialog();
            this.Close();
        }

    }
}
