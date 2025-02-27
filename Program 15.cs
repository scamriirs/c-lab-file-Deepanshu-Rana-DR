using System;
using System.Windows.Forms;
using System.Xml;

namespace XMLFileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadXMLData();
        }

        private void LoadXMLData()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("students.xml");

            XmlNode student = doc.SelectSingleNode("/Students/Student");

            lblRegNo.Text = "Reg No: " + student["RegNo"].InnerText;
            lblName.Text = "Name: " + student["Name"].InnerText;
            lblAge.Text = "Age: " + student["Age"].InnerText;
            lblClass.Text = "Class: " + student["Class"].InnerText;
        }
    }
}
