using System;
using System.Windows.Forms;
using todoPlanner.Abstract.models;

namespace MALIIDINOJWOČOKOLINO.Forms
{
    public partial class MainForm : Form
    {
        private User loggedInUser;

        public MainForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        
        }
    }
}
