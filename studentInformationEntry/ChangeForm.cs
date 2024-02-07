using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentInformationEntry
{
    public partial class ChangeForm : Form
    {
        public SqlConnection connection;
        public string connectionString;
        public ChangeForm()
        {
            connection = new SqlConnection();
            connectionString = "";
            InitializeComponent();
            editControlWindow1.Hide();
            addControlWindow1.Hide();
            deleteControlWindow1.Hide();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            // TODO - Add view student info window
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            deleteControlWindow1.Hide();
            addControlWindow1.Hide();
            editControlWindow1.Show();
            editControlWindow1.BringToFront();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            deleteControlWindow1.Hide();
            editControlWindow1.Hide();
            addControlWindow1.Show();
            addControlWindow1.BringToFront();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            addControlWindow1.Hide();
            editControlWindow1.Hide();
            deleteControlWindow1.Show();
            deleteControlWindow1.BringToFront();
        }

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            editButton.BackColor = SystemColors.ButtonHighlight;
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            editButton.BackColor = SystemColors.ButtonFace;
        }

        private void OnMouseEnterButton2(object sender, EventArgs e)
        {
            addButton.BackColor = SystemColors.ButtonHighlight;
        }
        private void OnMouseLeaveButton2(object sender, EventArgs e)
        {
            addButton.BackColor = SystemColors.ButtonFace;
        }

        private void OnMouseEnterButton3(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.ButtonHighlight;
        }
        private void OnMouseLeaveButton3(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.ButtonFace;
        }

        private void OnMouseEnterButton4(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.ButtonHighlight;
        }
        private void OnMouseLeaveButton4(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.ButtonFace;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteControlWindow1_Load(object sender, EventArgs e)
        {

        }
    }
}
