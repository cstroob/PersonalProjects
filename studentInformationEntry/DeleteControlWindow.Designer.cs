namespace studentInformationEntry
{
    partial class DeleteControlWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            studentIDTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            studentIDLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(85, 24);
            label1.Name = "label1";
            label1.Size = new Size(409, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter First and Last Name       or       Student's ID to delete:";
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.Location = new Point(394, 85);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.Size = new Size(100, 23);
            studentIDTextBox.TabIndex = 1;
            studentIDTextBox.TextChanged += studentIDTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(85, 140);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(183, 23);
            lastNameTextBox.TabIndex = 2;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(85, 85);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(183, 23);
            firstNameTextBox.TabIndex = 3;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new Point(323, 88);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new Size(65, 15);
            studentIDLabel.TabIndex = 4;
            studentIDLabel.Text = "Student ID:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(13, 140);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(66, 15);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(13, 88);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(67, 15);
            firstNameLabel.TabIndex = 6;
            firstNameLabel.Text = "First Name:";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(242, 286);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(132, 47);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // DeleteControlWindow
            // 
            AccessibleName = "DeleteControlWindow";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteButton);
            Controls.Add(firstNameLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(studentIDLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(studentIDTextBox);
            Controls.Add(label1);
            Name = "DeleteControlWindow";
            Size = new Size(620, 426);
            Load += DeleteControlWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox studentIDTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label studentIDLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Button deleteButton;
    }
}
