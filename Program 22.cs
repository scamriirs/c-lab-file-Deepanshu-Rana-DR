// 22. Use ADO.NET to connect the database (Program 19) with the fields of windows form (Program 18) and  populate the form field with the entries of the database.
CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50),
    Age INT,
    RegNo NVARCHAR(20),
    Class NVARCHAR(50)
);


using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentFormApp
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=YourDatabaseName;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string query = "SELECT TOP 1 * FROM Students"; // Load first student

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtName.Text = reader["Name"].ToString();
                        txtAge.Text = reader["Age"].ToString();
                        txtRegNo.Text = reader["RegNo"].ToString();
                        txtClass.Text = reader["Class"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
