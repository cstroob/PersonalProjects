using Microsoft.Data.SqlClient;

namespace studentInformationEntry
{
    partial class ChangeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            editButton = new Button();
            addButton = new Button();
            button3 = new Button();
            button4 = new Button();
            viewButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            editControlWindow1 = new EditControlWindow();
            addControlWindow1 = new AddControlWindow();
            deleteButton = new Button();
            deleteControlWindow1 = new DeleteControlWindow();
            SuspendLayout();
            // 
            // editButton
            // 
            editButton.Location = new Point(12, 51);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 33);
            editButton.TabIndex = 1;
            editButton.Text = "Edit Existing Student";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 90);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 33);
            addButton.TabIndex = 2;
            addButton.Text = "Add New Student";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 386);
            button3.Name = "button3";
            button3.Size = new Size(150, 23);
            button3.TabIndex = 3;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 415);
            button4.Name = "button4";
            button4.Size = new Size(150, 23);
            button4.TabIndex = 4;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(12, 12);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(150, 33);
            viewButton.TabIndex = 7;
            viewButton.Text = "View Student Info";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // editControlWindow1
            // 
            editControlWindow1.BackColor = Color.White;
            editControlWindow1.Location = new Point(168, 12);
            editControlWindow1.Name = "editControlWindow1";
            editControlWindow1.Size = new Size(620, 426);
            editControlWindow1.TabIndex = 9;
            // 
            // addControlWindow1
            // 
            addControlWindow1.BackColor = Color.White;
            addControlWindow1.Location = new Point(168, 12);
            addControlWindow1.Name = "addControlWindow1";
            addControlWindow1.Size = new Size(620, 426);
            addControlWindow1.TabIndex = 10;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(12, 129);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 33);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Delete Student";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // deleteControlWindow1
            // 
            deleteControlWindow1.AccessibleName = "DeleteControlWindow";
            deleteControlWindow1.BackColor = Color.White;
            deleteControlWindow1.Location = new Point(168, 12);
            deleteControlWindow1.Name = "deleteControlWindow1";
            deleteControlWindow1.Size = new Size(620, 426);
            deleteControlWindow1.TabIndex = 12;
            deleteControlWindow1.Load += deleteControlWindow1_Load;
            // 
            // ChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteControlWindow1);
            Controls.Add(deleteButton);
            Controls.Add(addControlWindow1);
            Controls.Add(editControlWindow1);
            Controls.Add(viewButton);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(addButton);
            Controls.Add(editButton);
            Name = "ChangeForm";
            Text = "Form1";
            Load += ChangeForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button editButton;
        private Button addButton;
        private Button button3;
        private Button button4;
        private Button viewButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private EditControlWindow editControlWindow1;
        private AddControlWindow addControlWindow1;
        private Button deleteButton;
        private DeleteControlWindow deleteControlWindow1;
    }
}