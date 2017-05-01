using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace One_Real_Estate___Database.Sprint_1
{
    public partial class Login_Page : System.Web.UI.Page
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        String userName;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login_Button_Click(object sender, EventArgs e)
        {
            //if (Page.IsValid)
            //{
            //    Blacklist_Check inputCheck = new Blacklist_Check();
            //    if(inputCheck.blacklistCheck(UserN_TextBox.Text) == true && inputCheck.blacklistCheck(Password_TextBox.Text) == true )
            //    {
            //        loginValidationCheck();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Inside Main ifelse");
            //        MessageBox.Show("Invalid input. Please try again.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Login Failed. Please fill the required fields.");
            //}

            if (Page.IsValid)
            {
                    loginValidationCheck();
            }
            else
            {
                MessageBox.Show("Login Failed. Please fill the required fields.");
            }
        }

        private void loginValidationCheck()
        {
            try
            {
                String retrivedSalt, retrivedHashedPassword, regeneratedHashedPassword;
                String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Successfully connected to database");
                String queryString = "select * from one_real_estate.signup_table where email_address = @U_Name";
                command = new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@U_Name", UserN_TextBox.Text);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    retrivedHashedPassword = reader["password"].ToString();
                    SHA256_Encryption encryption = new SHA256_Encryption();
                    retrivedSalt = reader["salt"].ToString();
                    String passwordEntered = Password_TextBox.Text;
                    regeneratedHashedPassword = encryption.GenerateSHA256Hash(passwordEntered, retrivedSalt);
                    if (retrivedHashedPassword == regeneratedHashedPassword)
                    {
                        userName = reader["first_name"].ToString()+" "+ reader["surname"].ToString() ;
                        Session["userNameFetched"] = userName;
                        MessageBox.Show("Login Sucessful");
                        Response.BufferOutput = true;
                        Response.Redirect("Login_Successful_Page.aspx", false);
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.");
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                reader.Close();
                connection.Close();
                MessageBox.Show("Login Failed. Please try again. " + ex);
            }
        }
    }
}