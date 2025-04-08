using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string retypePassword = txtRetypePassword.Text;
            string dob = txtDOB.Text.Trim();
            string reminder = txtReminder.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(retypePassword) || string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(reminder))
            {
                MessageBox.Show("Please fill in all fields.", "Error");
                return;
            }

            if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Password must be alphanumeric.", "Error");
                return;
            }

            if (password != retypePassword)
            {
                MessageBox.Show("Passwords do not match.", "Error");
                return;
            }

            if (!DateTime.TryParse(dob, out _))
            {
                MessageBox.Show("Enter a valid Date of Birth.", "Error");
                return;
            }

            string remember = chkRememberMe.Checked ? "Remembered" : "Not Remembered";
            MessageBox.Show($"Welcome {username}! Login Successful.\nRemember: {remember}", "Success");
        }
    }
}
