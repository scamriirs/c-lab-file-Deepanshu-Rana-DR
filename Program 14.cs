using System;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string regNo = txtRegNo.Text;
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string studentClass = txtClass.Text;

            MessageBox.Show($"Registered Successfully!\nReg No: {regNo}\nName: {name}\nAge: {age}\nClass: {studentClass}");
        }
    }
}
