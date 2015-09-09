using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
   public class AdminModel
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Address { get; set; }
       public string Phone { get; set; }

       public string UserName { get; set; }
       public string Password { get; set; }

    }
}
