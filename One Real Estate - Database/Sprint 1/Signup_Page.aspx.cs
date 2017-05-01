using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace One_Real_Estate___Database.Sprint_1
{
    public partial class Signup_Page : System.Web.UI.Page
    {
        MySqlConnection connection;
        MySqlCommand command;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signup_Button_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                insertData();
            }
            else
            {
                MessageBox.Show ("Signup Failed. Please fill the required fields.");
            }
        }

        private void insertData()
        {
            try
            {    
                String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Successfully connected to database");
                String queryString = "insert into signup_table(first_name,surname,mobile_number,email_address,salt,password) " +
                                     "values (@F_Name, @S_Name, @M_Number, @E_Address, @Salt, @Password)";
                command = new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@F_Name", FirstN_TextBox.Text);
                command.Parameters.AddWithValue("@S_Name", SurN_TextBox.Text);
                command.Parameters.AddWithValue("@M_Number", MobileN_TextBox.Text);
                command.Parameters.AddWithValue("@E_Address", EmailA_TextBox.Text);
                SHA256_Encryption encryption = new SHA256_Encryption();
                String salt = encryption.CreateSalt(10);
                command.Parameters.AddWithValue("@Salt", salt);
                String hashedpassword =  encryption.GenerateSHA256Hash(Password_TextBox.Text, salt);
                command.Parameters.AddWithValue("@Password", hashedpassword);
                command.ExecuteReader();
                connection.Close();
                MessageBox.Show("Password encrypted successfully");
                MessageBox.Show("Data inserted successfully");
                Response.BufferOutput = true;
                Response.Redirect("Login_Page.aspx", false);
            }
            catch (MySqlException ex)
            {
                String mobileNumberUniqueness = MobileN_TextBox.Text;
                String emailAddressUniqueness = EmailA_TextBox.Text;
                String emailAddressAuthentication = "Duplicate entry"+" '"+emailAddressUniqueness+"' "+"for key "+"'email_address_UNIQUE'";
                String mobileNumberAuthentication = "Duplicate entry"+" '"+mobileNumberUniqueness+"' "+"for key "+"'mobile_number_UNIQUE'";
                if (ex.Message.Equals(emailAddressAuthentication))
                {
                    MessageBox.Show("User already registered. Please enter another email address.");
                }
                else if(ex.Message.Equals(mobileNumberAuthentication))
                {
                    MessageBox.Show("Mobile number already regestered. Please enter another mobile number.");
                }
                else
                {
                    MessageBox.Show("Signup Failed. Please try again." +ex);
                }
                connection.Close();
                throw;
            }
            catch(Exception ex)
            {
                connection.Close();
                MessageBox.Show("Signup Failed. Please try again. " + ex);
                throw;
            }
        }

        protected void FirstN_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= 65 && e.KeyValue <= 90) || (e.KeyValue >= 97 && e.KeyValue <= 122) || e.KeyCode != Keys.Delete || e.KeyCode != Keys.Back || e.KeyCode != Keys.Space)
            {
                MessageBox.Show("Inside If");
                e.SuppressKeyPress = true;
            }
        }
    }
}