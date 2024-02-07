namespace studentInformationEntry
{
    partial class AddControlWindow
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            majorLabel = new Label();
            enrollmentDateLabel = new Label();
            firstNameBox = new TextBox();
            lastNameBox = new TextBox();
            majorBox = new TextBox();
            saveButton = new Button();
            enrollmentDatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(534, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter Student Information: ( * indicates required field.)";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F);
            firstNameLabel.Location = new Point(48, 76);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(100, 21);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name: *";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F);
            lastNameLabel.Location = new Point(50, 128);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(98, 21);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name: *";
            // 
            // majorLabel
            // 
            majorLabel.AutoSize = true;
            majorLabel.Font = new Font("Segoe UI", 12F);
            majorLabel.Location = new Point(83, 183);
            majorLabel.Name = "majorLabel";
            majorLabel.Size = new Size(54, 21);
            majorLabel.TabIndex = 3;
            majorLabel.Text = "Major:";
            // 
            // enrollmentDateLabel
            // 
            enrollmentDateLabel.AutoSize = true;
            enrollmentDateLabel.Font = new Font("Segoe UI", 12F);
            enrollmentDateLabel.Location = new Point(12, 237);
            enrollmentDateLabel.Name = "enrollmentDateLabel";
            enrollmentDateLabel.Size = new Size(136, 21);
            enrollmentDateLabel.TabIndex = 4;
            enrollmentDateLabel.Text = "Enrollment Date: *";
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(143, 78);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(400, 23);
            firstNameBox.TabIndex = 5;
            firstNameBox.TextChanged += firstNameBox_TextChanged;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(143, 130);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(400, 23);
            lastNameBox.TabIndex = 6;
            lastNameBox.TextChanged += lastNameBox_TextChanged;
            // 
            // majorBox
            // 
            majorBox.Location = new Point(143, 185);
            majorBox.Name = "majorBox";
            majorBox.Size = new Size(400, 23);
            majorBox.TabIndex = 7;
            majorBox.TextChanged += majorBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.Control;
            saveButton.Location = new Point(205, 312);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(255, 36);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // enrollmentDatePicker
            // 
            enrollmentDatePicker.CalendarFont = new Font("Segoe UI", 12F);
            enrollmentDatePicker.Font = new Font("Segoe UI", 12F);
            enrollmentDatePicker.Location = new Point(143, 231);
            enrollmentDatePicker.Name = "enrollmentDatePicker";
            enrollmentDatePicker.Size = new Size(400, 29);
            enrollmentDatePicker.TabIndex = 10;
            enrollmentDatePicker.ValueChanged += enrollmentDatePicker_ValueChanged;
            // 
            // AddControlWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(enrollmentDatePicker);
            Controls.Add(saveButton);
            Controls.Add(majorBox);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Controls.Add(enrollmentDateLabel);
            Controls.Add(majorLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(label1);
            Name = "AddControlWindow";
            Size = new Size(620, 426);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label majorLabel;
        private Label enrollmentDateLabel;
        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private TextBox majorBox;
        private Button saveButton;
        private DateTimePicker enrollmentDatePicker;
    }
}
