using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using todoPlanner.Abstract.models;
using todoPlanner.DB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MALIIDINOJWOČOKOLINO.Forms
{
    public partial class MainForm : Form
    {
        private User loggedInUser;
        private SqlConnectionFactory connectionFactory;
        private List<string> data;
        public MainForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            connectionFactory = new SqlConnectionFactory();
            data = getObveza();

            dataGridObaveze.DataSource = data;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private List<string> getObveza()
        {
            List<string> obveze = new List<string>();
            using (MySqlConnection connection = connectionFactory.GetNewConnection())
            {
                string query = "SELECT Obveza FROM obveze WHERE id_user=@id_user";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@id_user",loggedInUser.Id);
                   


                    using (var reader = command.ExecuteReader())
                    {
                       
                        while (reader.Read())
                        {
                            string obveza=reader.GetString("Obveza").ToString();
                            obveze.Add(obveza);
                   
                        }
                           
                    }
                      
                }
            }
            return obveze;


        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string obveza=txBoxObveze.Text;
            using(MySqlConnection connection = connectionFactory.GetNewConnection())
            {
                string query = "INSERT INTO obveze (Obveza,id_user) " +
                               "VALUES (@Obveza,@id_user)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Obveza", obveza);
                
                    command.Parameters.AddWithValue("@id_user", loggedInUser.Id);
                    command.ExecuteNonQuery();
                }
                
            }
        }
    }
    }

