// 24. Develop an ASP page to display the data of studenE entered in the previous form in tabular format using any of the grids .use Dataset to populate the grid.

CREATE TABLE Students (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100),
    Age INT,
    RegNo VARCHAR(20),
    Class VARCHAR(50),
    Email VARCHAR(100)
);


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStudents.aspx.cs" Inherits="StudentFormApp.ViewStudents" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View All Student Records</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:90%; margin:auto; padding:20px;">
            <h2>Student Records</h2>
            <asp:GridView ID="GridViewStudents" runat="server" AutoGenerateColumns="true" BorderWidth="1px" 
                GridLines="Both" HeaderStyle-BackColor="#CCCCCC" />
        </div>
    </form>
</body>
</html>



using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace StudentFormApp
{
    public partial class ViewStudents : System.Web.UI.Page
    {
        string connectionString = "server=localhost;user id=root;password=yourpassword;database=yourdbname;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudentData();
            }
        }

        private void LoadStudentData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();

                try
                {
                    adapter.Fill(ds);
                    GridViewStudents.DataSource = ds
