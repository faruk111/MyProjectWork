using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DLL;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.BLL
{
    
   public class MemberBLL
    {

       MemberGateWay gateway=new MemberGateWay();
       public string Insert(MemberModel member)
       {
           return gateway.Insert(member);
       }
    }
}
