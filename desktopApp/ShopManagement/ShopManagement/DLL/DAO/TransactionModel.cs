﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.DLL.DAO
{
   public class TransactionModel
    {

       public int  Id { get; set; }
       public DateTime Date { get; set; }
       public string Name { get; set; }
       public double Quantity { get; set; }
       public double TotalPrice { get; set; }
       public double PaidPrice { get; set; }
    }
}
