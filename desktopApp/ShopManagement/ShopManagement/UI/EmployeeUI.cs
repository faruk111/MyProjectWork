using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagement.BLL;
using ShopManagement.DLL.DAO;

namespace ShopManagement.UI
{
    public partial class EmployeeUI : Form
    {
        EmployeeBLL anEmployeeBll=new EmployeeBLL();
        public EmployeeUI()
        {
            InitializeComponent();
            SeeAll();
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            EmployeeModel anModel=new EmployeeModel();
            anModel.Name = nameTextBox.Text;
            anModel.Phone = mobileTextBox.Text;
            anModel.Address = addressTextBox.Text;
            string msg = anEmployeeBll.Save(anModel);
            MessageBox.Show(msg);
            SeeAll();
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            SeeAll();
        }

        private void SeeAll()
        {
            List<EmployeeModel> employees = anEmployeeBll.GetAllEmployee();
            employeedataGridView.DataSource = employees;
        }
    }
}
