using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DLL;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.BLL
{
   
   public class AdminBLL
       
    {
       AdminGateWay gateway=new AdminGateWay();
       public string Insert(AdminModel admin)
       {
           return gateway.Insert(admin);
       }

       public List<AdminModel> GetAllAdmin()
       {
           return gateway.GetAllAdmin();
       }
    }
}
