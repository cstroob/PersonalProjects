using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace studentInformationEntry
{
    public partial class LoginForm : Form
    {
        private string userID;
        private string password;
        public string connectionString;
        private const string table = "dbo.Student Information";

        public LoginForm()
        {
            InitializeComponent();
            userID = "";
            password = "";
            connectionString = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connect with windows auth turned off, must enter Database credentials
            connectionString = "Integrated Security=False;TrustServerCertificate=True;" +
                "Persist Security Info=False;User ID=" + userID + ";Password=" + password +
                ";Initial Catalog=studentinfo;Data Source=STRUBBE-HOMESER\\STUDENTDATABASE;Encrypt=True";

            ConnectionController.connection = new SqlConnection(connectionString);
            ConnectionController.connectionString = connectionString;
            ChangeForm cf = new ChangeForm();

            try
            {
                ConnectionController.connection.Open();
                MessageBox.Show("Login Successful");
                this.Hide();
                
                cf.FormClosed += (s, args) => this.Close();
                cf.Show();
                cf.Focus();
                ConnectionController.connection.Close();
            } catch(Exception ex)
            {
                MessageBox.Show("Invalid Credentials");
            }  // Ending bracket of try catch block          
        }  // Ending bracket of method button1_Click

        private void userBox_TextChanged(object sender, EventArgs e)
        {
            userID = userBox.Text;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            password = passwordBox.Text;
        }

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ButtonHighlight;
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ButtonFace;
        }
    }  // Ending bracket of class Form1
}  // namespace studentInformationEntry
