namespace RoomateFinder
{
    using System;
    using RoomateFinderEngne;

    public partial class NewProfileFromLoginForm : Form
    {
        public NewProfileFromLoginForm()
        {
            InitializeComponent();
        }

        private void NewProfileFromLoginForm_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler SubmitEvent = (sender, e) => { };

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.SubmitEvent(this, new UserInfoEventArgs(this.UsernameTextBox.Text, this.PasswordTextBox2.Text, this.BioTextbox.Text));
            this.Close();
        }
    }
}
