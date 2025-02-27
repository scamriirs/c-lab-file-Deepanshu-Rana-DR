using System;
using System.Windows.Forms;

namespace AdmissionEnquiryForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            MessageBox.Show($"Enquiry Submitted! \nName: {name}\nEmail: {email}\nPhone: {phone}");
        }
    }
}
