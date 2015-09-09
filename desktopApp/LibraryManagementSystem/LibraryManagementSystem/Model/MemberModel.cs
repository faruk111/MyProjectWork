﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
   public class MemberModel
    {
       public int Id { set; get; }
       public string Name { set; get; }
       public string Type { set; get; }
       public DateTime EntryDate { set; get; }
       public string Address { set; get; }
       public string Contact { set; get; }
   }
}
