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
    public partial class DeleteControlWindow : UserControl
    {
        private string firstName;
        private string lastName;
        private int studentID;
        public DeleteControlWindow()
        {
            InitializeComponent();
            firstName = string.Empty;
            lastName = string.Empty;
            studentID = 0;
        }

        private void DeleteControlWindow_Load(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            lastName = lastNameTextBox.Text;
        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            studentID = Int32.Parse(studentIDTextBox.Text);
        }

        private void OnMouseEnterDeleteButton(object sender, EventArgs e)
        {
            deleteButton.BackColor = SystemColors.ButtonHighlight;
        }
        private void OnMouseLeaveDeleteButton(object sender, EventArgs e)
        {
            deleteButton.BackColor = SystemColors.ButtonFace;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (firstName != string.Empty && lastName != string.Empty)
            {
                ConnectionController.NonQuery("DELETE FROM StudentInformation " +
                    "WHERE (FirstName = '" + firstName + "') AND (LastName = '" +
                    lastName + "');");

                MessageBox.Show("Student deleted.");
            } else if (studentID != 0)
            {
                ConnectionController.NonQuery("DELETE FROM StudentInformation " +
                    "WHERE ID ='" + studentID + "';");
                MessageBox.Show("Student deleted.");
            } else
            {
                MessageBox.Show("Operation not completed: You must enter " +
                    "either first and last name OR student ID.");
            }
        }
    }
}
