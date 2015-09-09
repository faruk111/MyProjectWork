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
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.UI
{
    public partial class AdministratorUI : Form
    {
         AdminBLL adminbll=new AdminBLL();
       
        public AdministratorUI()
        {
            InitializeComponent();
            ShowAll();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            AdminModel admin=new AdminModel();

            admin.Id = Convert.ToInt32(idtextBox.Text);
            admin.Name = nameTextBox.Text;
            admin.Address = addressTextBox.Text;
            admin.Phone = phoneTextBox.Text;
            admin.UserName = usernameTextBox.Text;
            admin.Password = passwordTextBox.Text;

           

            string msg = adminbll.Insert(admin);
            MessageBox.Show(msg);


        }

        public void ShowAll()
        {
            List<AdminModel> adminlist=new List<AdminModel>();
            adminlist = adminbll.GetAllAdmin();
            admindataGridView.DataSource = adminlist;
        }

        private void deleteAdminButton_Click(object sender, EventArgs e)
        {
           
           
        }

      
    }
}
