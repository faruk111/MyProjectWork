using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.DLL.DAO;
using ShopManagement.DLL.GateWay;

namespace ShopManagement.BLL
{
   public class EmployeeBLL
    {
       EmployeeGateWay gateWay=new EmployeeGateWay();
       public string Save(EmployeeModel anModel)
       {
           if (anModel.Name == string.Empty || anModel.Phone == string.Empty || anModel.Address == string.Empty)
           {
               return "please fill all the field";
           }
           else
           {
               return gateWay.Save(anModel);
           }

       }

       public List<EmployeeModel> GetAllEmployee()
       {
           return gateWay.GetAllEmployee();
       }
    }
}
