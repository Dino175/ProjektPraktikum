using MySqlConnector;
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
using todoPlanner.Abstract.models;
using todoPlanner.DB;

namespace MALIIDINOJWOČOKOLINO.Forms
{
    public partial class RegistrationForm : Form
    {
        private SqlConnectionFactory connectionFactory;
        public RegistrationForm()
        {
            InitializeComponent();
            connectionFactory = new SqlConnectionFactory();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtPrezime.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            User user = new User();

          
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

       

            
            using (MySqlConnection connection = connectionFactory.GetNewConnection())
            {
                string query = "INSERT INTO users (firstname, lastname, email, password) " +
                               "VALUES (@FirstName, @LastName, @Email, @Password)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User registered successfully.");
                      
                        loginForm loginForm1 = new loginForm();
                        loginForm1.ShowDialog();
                      
                    }
                    else
                    {
                        MessageBox.Show("Failed to register user.");
                        return;
                    }
                }
                loginForm loginForm = new loginForm();
                loginForm.Show();
            }
        }

        private void lnklabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
