// 23. Prepare a ASP-NET page to fill student details. any of the compondlts available as deemed fit for the requirements. on the press of save button user should be able to save the form data in a mysqltable.

CREATE TABLE Students (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100),
    Age INT,
    RegNo VARCHAR(20),
    Class VARCHAR(50),
    Email VARCHAR(100)
);


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="StudentFormApp.StudentForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:400px; margin:auto; padding:20px;">
            <h2>Student Details Form</h2>
            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label><br />
            <asp:TextBox ID="txtName" runat="server" /><br /><br />

            <asp:Label ID="lblAge" runat="server" Text="Age:"></asp:Label><br />
            <asp:TextBox ID="txtAge" runat="server" /><br /><br />

            <asp:Label ID="lblRegNo" runat="server" Text="Registration No:"></asp:Label><br />
            <asp:TextBox ID="txtRegNo" runat="server" /><br /><br />

            <asp:Label ID="lblClass" runat="server" Text="Class:"></asp:Label><br />
            <asp:TextBox ID="txtClass" runat="server" /><br /><br />

            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label><br />
            <asp:TextBox ID="txtEmail" runat="server" /><br /><br />

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <br /><br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />
        </div>
    </form>
</body>
</html>



using System;
using MySql.Data.MySqlClient;

namespace StudentFormApp
{
    public partial class StudentForm : System.Web.UI.Page
    {
        string connectionString = "server=localhost;user id=root;password=yourpassword;database=yourdbname;";

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string regNo = txtRegNo.Text;
            string sclass = txtClass.Text;
            string email = txtEmail.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Students (Name, Age, RegNo, Class, Email) VALUES (@Name, @Age, @RegNo, @Class, @Email)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@RegNo", regNo);
                cmd.Parameters.AddWithValue("@Class", sclass);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    lblMessage.Text = "Student record saved successfully!";
                }
                catch (Exception ex)
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Error: " + ex.Message;
                }
            }
        }
    }
}
