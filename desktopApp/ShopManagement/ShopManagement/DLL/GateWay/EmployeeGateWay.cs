using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.DLL.DAO;

namespace ShopManagement.DLL.GateWay
{
    class EmployeeGateWay
    {
        public string Save(EmployeeModel anModel)
        {
            string url = @"server=faruk\SQLEXPRESS; database=ShopManagement; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();

            string query = string.Format("insert into t_employee values ('{0}','{1}','{2}')", anModel.Name, anModel.Phone, anModel.Address);
            SqlCommand command = new SqlCommand(query, connection);


            int affectedrow = command.ExecuteNonQuery();

            if (affectedrow > 0)
                return "Data inserted";
            return "Some Error";
        }

        public List<EmployeeModel> GetAllEmployee()
        {
           
            List<EmployeeModel> empoList=new List<EmployeeModel>();
            string url = @"server=faruk\SQLEXPRESS; database=ShopManagement; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();

            string query = "select * from t_employee";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            int count = 1;
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    EmployeeModel employee = new EmployeeModel();
                    employee.Id = (count++).ToString();
                    employee.Name = aReader[1].ToString();
                    employee.Phone = aReader[2].ToString();
                    employee.Address = aReader[3].ToString();

                    empoList.Add(employee);
                }
              
            }
            connection.Close();
            return empoList;

        }
    }
}
