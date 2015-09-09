using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.UI
{
    public partial class adminVarification : Form
    {
        public adminVarification()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            

            string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();

            string query = "select * from admin_table";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            AdminModel admin = new AdminModel();
            string username = nameTextBox.Text;
            string pass = passwordTextBox.Text;
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                   
                    admin.Name = aReader[1].ToString();
                    admin.Password = aReader[5].ToString();

                   
                }
               
               

            }
            if (admin.Name == username && admin.Password == pass)
            {
                AdministratorUI a = new AdministratorUI();

                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("wrong username or password");
            }
            connection.Close();
        }
    }
}
