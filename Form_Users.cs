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
using System.Web;
using System.Net;
using System.Net.Mail;

namespace FormApp_PhoneService
{
    public partial class Form_Users : Form
    {
       
        bool IsAdmin = false;
        string Email;
        string Username;
        myLibrary mylib = new myLibrary();

        //At Form Load
        public Form_Users(string username)
        {         
            InitializeComponent();

            Username = username;
            Email = mylib.GetUserEmail(username); //get email of the user
            IsAdmin = mylib.IsAdmin(username); //get if admin        
        }
        private void Form_Users_Load(object sender, EventArgs e)
        {
            ShowPhoneGrid_and_Username(); //show the data in a grid and the welcoming user label

            GetDropBoxForBrand(); //fill the drop box for simpler search brand
        }
        private void GetDropBoxForBrand()
        {
            // Searching for values to put in the drop box Brand Search          
            DataTable dt = mylib.SelectSqlDataTable("SELECT DISTINCT Brand FROM TB_Phones");
            CB_Brand.DataSource = dt;
            CB_Brand.DisplayMember = "Brand"; //the displayed values
            CB_Brand.ValueMember = "Brand"; //the actual value of the box , here they are the same
        }
        private void ShowPhoneGrid_and_Username()  
        {
            // if the user is an admin, make the grid editable and hide the buy button, if only user, hide the phoneID column
            if (IsAdmin)
            {
                DtGrid_Phone.ReadOnly = false;
                Bt_Buy.Hide();
                Lb_WelcomeUser.Text = "Welcome Admin " + Username + " "; //Welcoming the user with the name
            }
            else
            {
                DtGrid_Phone.ReadOnly = true;
                DtGrid_Phone.AllowUserToDeleteRows = false;
                Lb_WelcomeUser.Text = "Welcome user " + Username + " "; //Welcoming the user with the name
            }

            //display the grid 
            UpdateTable("FROM TB_Phones ORDER BY PhoneID");
            
            // change the style of the PhoneSpecs Column so the user know its a link
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            System.Drawing.Font font = new System.Drawing.Font(FontFamily.GenericSerif, 8, FontStyle.Underline);
            dataGridViewCellStyle.Font = font;
            dataGridViewCellStyle.ForeColor = Color.Blue;

            DtGrid_Phone.Columns["PhoneSpecs"].DefaultCellStyle = dataGridViewCellStyle;

        }
      
        //Searching algorithms
        private void Bt_Search_Click(object sender, EventArgs e)
        {
            // check the brand Search and change it so it fits the sql query
            string brand = CB_Brand.Text;  
            string str_brandQuery = GetBrandQueryString(brand); //variable used in the SqlQuery
                      
            // check the price Search and change it so it fits the sql query            
            string price1 = TxtB_Price1.Text;
            string price2 = TxtB_Price2.Text;
            string str_priceQuery = GetPriceQueryString(price1, price2); ; //variable used in the SqlQuery         

            // check the production year Search and change it so it fits the sql query
            string ProductionYear = TxtB_ProductionYear.Text;
            string str_ProductionYear = GetProductionYearQueryString(ProductionYear); //Variable used in the SqlQuery

            ExecuteSearch(str_brandQuery, str_priceQuery, str_ProductionYear);


        }
        private string GetBrandQueryString(string brand) {

            if (brand != "") { return "Brand = '" + brand + "'"; }
            else { return "1 = 1"; } //ignore Brand in the Select Query if the user did not suggest a brand name   
        }
        private string GetPriceQueryString(string StrPrice1,string StrPrice2) {

            if (StrPrice1 != "" & StrPrice2 != "") //ignore the prices if one of the inputed prices is null
            {
                int price1 = int.Parse(StrPrice1);
                int price2 = int.Parse(StrPrice2);

                if (price1 > price2) { (price2, price1) = (price1, price2); } //switches prices txt box to get price1 < price2
           
                return "Price > " + price1 + " AND Price < " + price2 + "";
            }
            else { return "1 = 1"; }

        }
        private string GetProductionYearQueryString(string StrProductionYear) {

            if (StrProductionYear != "")
            {
                int productionyear = int.Parse(TxtB_ProductionYear.Text);
                return "ProductionYear >= " + productionyear + "";
            }
            else { return "1 = 1"; }
        
        }
        private void ExecuteSearch(string str_brandQuery,string str_priceQuery, string str_ProductionYear) 
        {
            UpdateTable("FROM TB_Phones  WHERE " + str_brandQuery + " AND " + str_priceQuery + " AND " + str_ProductionYear + " ORDER BY PhoneID");
        }

        //User Interaction
        private void DtGrid_Phone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //send the user to the phonespecs link if the user clicked on the phonespecs colums, does not send if admin
            if (IsAdmin == false)
            {
                if (!String.IsNullOrWhiteSpace(DtGrid_Phone.CurrentCell.EditedFormattedValue.ToString()))
                {
                    if (DtGrid_Phone.CurrentCell.ColumnIndex == DtGrid_Phone.Columns["PhoneSpecs"].Index)
                    {
                        System.Diagnostics.Process.Start("http://" + DtGrid_Phone.CurrentCell.EditedFormattedValue);
                    }
                }
            }

        }
        private void Bt_Buy_Click(object sender, EventArgs e)
        {
            if (DtGrid_Phone.CurrentRow.Cells[0].Value != DBNull.Value && DtGrid_Phone.CurrentRow.Cells["PhonesAvailable"].Value.ToString() != "0")
            {
                if (MessageBox.Show("Are you sure you want to Buy " + DtGrid_Phone.CurrentRow.Cells["PhoneName"].Value.ToString() + " ? ", "Buying Phone", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //sending an email for sold item
                        string Subject = "PhoneService purchased Phone";
                        string Body = "you purchased this item : " + DtGrid_Phone.CurrentRow.Cells["PhoneName"].Value.ToString();
                        mylib.SendEmail(Email, Subject, Body);

                        DiminishPhoneAvailabality_By1();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else { MessageBox.Show("Item not bought"); } //if the admin pressed no, cancel the delete event
            }
            else { MessageBox.Show("Phone does not exist right now"); }

        }
        private void DiminishPhoneAvailabality_By1()  
        {
            //opening sql connection

            SqlConnection con = new SqlConnection(mylib.ConnectionString);
            con.Open();

            //Running Stored sql procedures based on the PhoneID to make either an edit or an add

            DataGridViewRow DG_Row = DtGrid_Phone.CurrentRow; // we get the selected row of a grid
            SqlCommand cmd = new SqlCommand("ControlPhoneAvailability_PhoneTable", con); //the command is a sql procedure called EDitaddphonetable we created
            cmd.CommandType = CommandType.StoredProcedure; // change command type
            cmd.Parameters.AddWithValue("@phoneavailable", Convert.ToInt32(DG_Row.Cells["PhonesAvailable"].Value == DBNull.Value ? "0" : DG_Row.Cells["PhonesAvailable"].Value.ToString()));
            cmd.Parameters.AddWithValue("@phonename", DG_Row.Cells["PhoneName"].Value == DBNull.Value ? "" : DG_Row.Cells["PhoneName"].Value.ToString());
            cmd.ExecuteNonQuery();

            //Updating Grid Values
            UpdateTable("FROM TB_Phones ORDER BY PhoneID");
           

        }
                //only permits the user to enter numbers in the price and production year txt box
        private void TxtB_Price1_KeyPress(object sender, KeyPressEventArgs e)
        {
            mylib.OnlyEnablesNumberKeys(e);
        }
        private void TxtB_Price2_KeyPress(object sender, KeyPressEventArgs e)
        {
            mylib.OnlyEnablesNumberKeys(e);
        }
        private void TxtB_ProductionYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            mylib.OnlyEnablesNumberKeys(e);
        }

        //Admin Editing Data from Grid
        private void DtGrid_Phone_CellValueChanged(object sender, DataGridViewCellEventArgs e) 
        {
            if (DtGrid_Phone.CurrentRow != null) //if we are selecting a row
            {
                try
                {
                    EditAdd_Row();                                    
                }
                catch{ MessageBox.Show("This Phone is already included in the table"); }
            }

            //Showing the grid after the tables has been edited
            UpdateTable("FROM TB_Phones ORDER BY PhoneID");
        }
        private void EditAdd_Row()
        {
            //opening sql connection
            SqlConnection con = new SqlConnection(mylib.ConnectionString);
            con.Open();

            //Running Stored sql procedures based on the PhoneID to make either an edit or an add

            DataGridViewRow DG_Row = DtGrid_Phone.CurrentRow; // we get the selected row of a grid

            SqlCommand cmd = new SqlCommand("EditAdd_PhoneTable", con); //the command is a sql stored procedure called EDitaddphonetable we created
            cmd.CommandType = CommandType.StoredProcedure; // change command type to stored procedure

            cmd.Parameters.AddWithValue("@phoneID", Convert.ToInt32(DG_Row.Cells["PhoneID"].Value == DBNull.Value ? "0" : DG_Row.Cells["PhoneID"].Value.ToString()));
            cmd.Parameters.AddWithValue("@phonename", DG_Row.Cells["PhoneName"].Value == DBNull.Value ? "" : DG_Row.Cells["PhoneName"].Value.ToString());
            cmd.Parameters.AddWithValue("@brand", DG_Row.Cells["Brand"].Value == DBNull.Value ? "" : DG_Row.Cells["Brand"].Value.ToString());
            cmd.Parameters.AddWithValue("@price", Convert.ToInt32(DG_Row.Cells["Price"].Value == DBNull.Value ? "0" : DG_Row.Cells["Price"].Value.ToString()));
            cmd.Parameters.AddWithValue("@productionyear", Convert.ToInt32(DG_Row.Cells["ProductionYear"].Value == DBNull.Value ? "0" : DG_Row.Cells["ProductionYear"].Value.ToString()));
            cmd.Parameters.AddWithValue("@phonespecs", DG_Row.Cells["PhoneSpecs"].Value == DBNull.Value ? "" : DG_Row.Cells["PhoneSpecs"].Value.ToString());
            cmd.Parameters.AddWithValue("@phoneavailable", Convert.ToInt32(DG_Row.Cells["PhonesAvailable"].Value == DBNull.Value ? "0" : DG_Row.Cells["PhonesAvailable"].Value.ToString()));
            cmd.ExecuteNonQuery();

           
        }
        private void DtGrid_Phone_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (DtGrid_Phone.CurrentRow.Cells["PhoneID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure you want to delete this row ? ", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //run stored procedural
                    SqlConnection con = new SqlConnection(mylib.ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete_PhoneTable", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@phoneID", Convert.ToInt32(DtGrid_Phone.CurrentRow.Cells["PhoneID"].Value == DBNull.Value ? "0" : DtGrid_Phone.CurrentRow.Cells["PhoneID"].Value.ToString()));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else { e.Cancel = true; } //if the admin pressed no, cancel the delete event
            }
            else { e.Cancel = true; } //if the row does not have data, cancel the delete event
        }
    
        //Change Form buttons
        private void Bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Bt_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog();
            this.Close();
        }

        //Updating Table Based on if Admin
        private void UpdateTable(string query)
        {
            DataTable dt;

            if (IsAdmin)
            {
                dt = mylib.SelectSqlDataTable("SELECT * " + query + "");              
            }
            else
            {
                dt = mylib.SelectSqlDataTable("SELECT PhoneName, Brand, Price, ProductionYear, PhoneSpecs, PhonesAvailable " + query + "");
            }
            DtGrid_Phone.DataSource = dt;
        }

        
    }
}
