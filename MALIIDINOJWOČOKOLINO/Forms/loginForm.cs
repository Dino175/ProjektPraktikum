using MySqlConnector;
using System;
using System.Windows.Forms;
using todoPlanner.Abstract.models;
using todoPlanner.DB;

namespace MALIIDINOJWOČOKOLINO.Forms
{
    public partial class loginForm : Form
    {
        private SqlConnectionFactory connectionFactory;
        public loginForm()
        {
            InitializeComponent();
            connectionFactory = new SqlConnectionFactory();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            User user = new User();
            using (MySqlConnection connection = connectionFactory.GetNewConnection())
            {
                string query = "SELECT * FROM users WHERE email = @username AND password = @password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);


                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user.Email = reader.GetString("email");
                            user.Password = reader.GetString("password");
                        }
                        else
                        {
                            MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
                            return;
                        }
                    }
                }
            }

            MainForm mainForm = new MainForm(user);
            mainForm.Show();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
