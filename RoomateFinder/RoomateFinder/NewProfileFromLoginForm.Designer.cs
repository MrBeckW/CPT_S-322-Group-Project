namespace RoomateFinder
{
    partial class NewProfileFromLoginForm
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
            UsernameTextBox = new TextBox();
            PasswordTextBox2 = new TextBox();
            BioTextbox = new TextBox();
            Username = new Label();
            PasswordLabel = new Label();
            BioLabel = new Label();
            CancelButton = new Button();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(146, 121);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(100, 23);
            UsernameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox2
            // 
            PasswordTextBox2.Location = new Point(146, 164);
            PasswordTextBox2.Name = "PasswordTextBox2";
            PasswordTextBox2.Size = new Size(100, 23);
            PasswordTextBox2.TabIndex = 1;
            // 
            // BioTextbox
            // 
            BioTextbox.Location = new Point(375, 121);
            BioTextbox.Multiline = true;
            BioTextbox.Name = "BioTextbox";
            BioTextbox.Size = new Size(259, 139);
            BioTextbox.TabIndex = 2;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(147, 103);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(146, 147);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            // 
            // BioLabel
            // 
            BioLabel.AutoSize = true;
            BioLabel.Location = new Point(376, 100);
            BioLabel.Name = "BioLabel";
            BioLabel.Size = new Size(91, 15);
            BioLabel.TabIndex = 5;
            BioLabel.Text = "Add a short bio!";
            BioLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(713, 12);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(295, 320);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(172, 23);
            SubmitButton.TabIndex = 7;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // NewProfileFromLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubmitButton);
            Controls.Add(CancelButton);
            Controls.Add(BioLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(Username);
            Controls.Add(BioTextbox);
            Controls.Add(PasswordTextBox2);
            Controls.Add(UsernameTextBox);
            Name = "NewProfileFromLoginForm";
            Text = "NewProfileFromLoginForm";
            Load += NewProfileFromLoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox2;
        private TextBox BioTextbox;
        private Label Username;
        private Label PasswordLabel;
        private Label BioLabel;
        private Button CancelButton;
        private Button SubmitButton;
    }
}