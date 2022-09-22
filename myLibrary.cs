using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FormApp_PhoneService
{
    internal class myLibrary
    {
        public string ConnectionString = "Data Source = DESKTOP-G616HPC; Initial Catalog = DB_PhoneService; Integrated Security = True; Pooling = False";
        public void SendEmail(string ToEmail, string Subject, string Body)
        {
            //sending a pin number for register validation

            MailMessage msg = new MailMessage(); //creating an mail object
            msg.From = new MailAddress("CompaniesEmail"); // from the companies email
            msg.To.Add(ToEmail); // to the inputed email
            msg.Subject = Subject; //subject of the mail
            msg.Body = Body; //body of the mail

            SmtpClient smt = new SmtpClient(); //creating smtp object, here we are working with emails only (smtp : simple mail transfer protocol)
            smt.Host = "smtp.gmail.com"; //gmail smtp (the host is a gmail)
            System.Net.NetworkCredential ntcd = new NetworkCredential(); //the companie's email informations to connect the app with the companie's email so it can send an email
            ntcd.UserName = "CompaniesEmail"; //companies email
            ntcd.Password = "ComapniesPassword"; //companies gmail password , we created a application password in the google account(its not the password that we signed in with)
            smt.Credentials = ntcd; //Credentials refer to the verification of identity or tools for authentication.
            smt.EnableSsl = true; // SSL : Secured socket layer, SSL/TLS is a security system that combines authentication and encryption. The identification procedure includes an encryption key, which is used to protect all transmissions once the connection has been established.
            smt.Port = 587; //SMTP ports serve as communication endpoints that handle information transfers from one server to another.(587 is the port for emails), A port is a virtual point where network connections start and end. Ports are software-based and managed by a computer's operating system.
            smt.Send(msg); //send the msg

            MessageBox.Show("Mail sent");
        }

        public bool IsAdmin(string username)
        {
            //opening database connection
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            //writing command
            SqlCommand cmd = new SqlCommand("SELECT IsAdmin FROM TB_Users WHERE Username = '" + username + "' ", con);

            //reading from the cmd execution reader
            SqlDataReader sqlDataReader = cmd.ExecuteReader(); //reading from a row in the sql table we selected with command
            sqlDataReader.Read();
            bool IsAdmin = sqlDataReader.GetBoolean(0);//reads the firsts (0) column of the commanded row, here its the IsAdmin Column 
            sqlDataReader.Close();

            return IsAdmin;
        }

        public string GetUserEmail(string username)
        {
            // opening connection
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            //sql commands to get the email of the user
            SqlCommand cmd = new SqlCommand("SELECT Email FROM TB_Users WHERE Username = '" + username + "' ", con);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.HasRows) // if there exist a username
            {
                while (sqlDataReader.Read())
                {
                    return sqlDataReader.GetString(0);    //reads the first column of the commanded row, here we only have 1 column (username) and 1 row  
                }
                sqlDataReader.Close();
            }
            else
            {
                MessageBox.Show("No username can be found");
            }

            con.Close();

            return "Email Invalid";
        }

        public DataTable SelectSqlDataTable(string query)
        {
            //sql command to Get the phone table in a data table
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            // closing connection
            con.Close();

            return dt;
        }

        public void OnlyEnablesNumberKeys(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b') // if the enterd key is not a number and is not a backspace
            {
                e.Handled = true; // indicates that the event handler has already processed the event and dealt with it, so it doesn't need to be processed any further. In other words, please don't take any further action.(the event was handeled)
            }
        }
    }
}
