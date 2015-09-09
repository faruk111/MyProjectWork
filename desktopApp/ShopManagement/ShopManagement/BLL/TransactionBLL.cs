using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.DLL.DAO;
using ShopManagement.DLL.GateWay;

namespace ShopManagement.BLL
{
  public  class TransactionBLL
    {
      TransactionGateway gateway=new TransactionGateway();
      public string Save(TransactionModel atransaction)
      {
          if (atransaction.Name == string.Empty || atransaction.Date.ToString() == string.Empty )
          {
              return "Please Fill all field";
          }
          else
          {
              return gateway.Save(atransaction);
          }
      }

      public List<TransactionModel> GetAllTransction()
      {

          return gateway.GetAllTransaction();
      }
    }
}
