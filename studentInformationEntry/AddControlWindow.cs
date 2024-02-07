using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentInformationEntry
{
    public partial class AddControlWindow : UserControl
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string major { get; set; }
        private DateTime enrollmentDate { get; set; }

        public AddControlWindow()
        {
            InitializeComponent();
            firstName = "";
            lastName = "";
            major = "";
            enrollmentDate = new DateTime();
            //connection = new SqlConnection();
            //connectionString = "";
        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {
            firstName = firstNameBox.Text;
        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
            lastName = lastNameBox.Text;
        }

        private void majorBox_TextChanged(Object sender, EventArgs e)
        {
            major = majorBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (major == "")
            {
                major = "Undecided";
            }

            if (firstName == "" && lastName == "")
            {
                MessageBox.Show("Please enter the students first and last name");
            } else if (lastName == "")
            {
                MessageBox.Show("Please enter the students last name");
            } else if (firstName == "")
            {
                MessageBox.Show("Please enter the students first name");
            } else
            {
                // Get the last value from ID column in table and increment by one
                int studentID = ConnectionController.GetLastID("SELECT ID FROM StudentInformation") + 1;
                // Create the statement to pass to ConnectionController to execute NonQuery
                string statement = "INSERT INTO StudentInformation VALUES ('" + firstName + "', '" + lastName
                    + "', " + studentID + ", '" + major + "', '" + enrollmentDate.ToString() + "');";
                ConnectionController.NonQuery(statement);

                MessageBox.Show("Student: " + firstName + " " + lastName + " added with ID: " + studentID);
            }
        }  // Ending bracket of method saveButton_Click

        private void OnMouseEntersaveButton(object sender, EventArgs e)
        {
            saveButton.BackColor = SystemColors.ButtonHighlight;
        }
        private void OnMouseLeavesaveButton(object sender, EventArgs e)
        {
            saveButton.BackColor = SystemColors.ButtonFace;
        }

        private void enrollmentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            enrollmentDate = enrollmentDatePicker.Value;
        }

    }  // Ending bracket of class AddControlWindow
}  // namespace studentInformationEntry
