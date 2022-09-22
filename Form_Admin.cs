using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_PhoneService
{
    public partial class Form_Admin : Form
    {
        string email;
        public Form_Admin(string st_email)
        {
            InitializeComponent();
            email = st_email;
            
        }
       

        private void Bt_Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Users form_Users = new Form_Users(email);
            form_Users.ShowDialog();
            this.Close();            
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
