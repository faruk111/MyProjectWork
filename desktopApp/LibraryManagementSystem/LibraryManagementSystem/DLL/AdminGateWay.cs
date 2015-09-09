using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.DLL
{
   public class AdminGateWay
    {
       public string Insert(AdminModel admin)
       {
         
           string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
           SqlConnection connection = new SqlConnection(url);

           connection.Open();

           string query = string.Format("insert into admin_table values ('{0}','{1}','{2}','{3}','{4}','{5}')", admin.Id, admin.Name, admin.Address, admin.Phone, admin.UserName, admin.Password);
           SqlCommand command = new SqlCommand(query, connection);


           int affectedrow = command.ExecuteNonQuery();
           if (affectedrow > 0)
               return "successful";
           else
           {
               return "some error";
           }
       }

       public List<AdminModel> GetAllAdmin()
       {
           List<AdminModel> adminlist = new List<AdminModel>();
           string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
           SqlConnection connection = new SqlConnection(url);

           connection.Open();

           string query = "select * from admin_table";
           SqlCommand command = new SqlCommand(query, connection);
           SqlDataReader aReader = command.ExecuteReader();

           int count = 1;
           if (aReader.HasRows)
           {
               while (aReader.Read())
               {
                   AdminModel adminModel = new AdminModel();
                   adminModel.Id = Convert.ToInt32((count++).ToString());
                   adminModel.Name = aReader[1].ToString();
                   adminModel.Address = aReader[2].ToString();
                   adminModel.Phone = aReader[2].ToString();
                   adminModel.UserName = aReader[2].ToString();
                   adminModel.Password = aReader[2].ToString();
                   adminlist.Add(adminModel);
               }

           }
           connection.Close();
           return adminlist;

       }
    }
}
