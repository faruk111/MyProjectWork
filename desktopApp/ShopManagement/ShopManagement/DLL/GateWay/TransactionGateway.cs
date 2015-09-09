using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.DLL.DAO;

namespace ShopManagement.DLL.GateWay
{
  public  class TransactionGateway
    {
      public string Save(TransactionModel atransaction)
      {
          string url = @"server=faruk\SQLEXPRESS; database=ShopManagement; integrated security=true";
          SqlConnection connection = new SqlConnection(url);

          connection.Open();

          string query = string.Format("insert into t_transaction values ('{0}','{1}','{2}','{3}','{4}')",
              atransaction.Name, atransaction.Date, atransaction.Quantity,atransaction.TotalPrice,atransaction.PaidPrice);
          SqlCommand command = new SqlCommand(query, connection);


          int affectedrow = command.ExecuteNonQuery();

          if (affectedrow > 0)
              return "Data inserted";
          return "Some Error";
      }

      public List<TransactionModel> GetAllTransaction()
      {


          List<TransactionModel> transactionlList =new List<TransactionModel>();
          string url = @"server=faruk\SQLEXPRESS; database=ShopManagement; integrated security=true";
          SqlConnection connection = new SqlConnection(url);

          connection.Open();

          string query = "select * from t_transaction";
          SqlCommand command = new SqlCommand(query, connection);
          SqlDataReader aReader = command.ExecuteReader();

          int count = 1;
          if (aReader.HasRows)
          {
              while (aReader.Read())
              {
                  TransactionModel transaction = new TransactionModel();
                  transaction.Id = Convert.ToInt32((count++).ToString());
                  transaction.Name = aReader[1].ToString();
                  transaction.Date = Convert.ToDateTime(aReader[2].ToString());
                  transaction.Quantity= Convert.ToDouble((string)aReader[3]);
                  transaction.TotalPrice =  Convert.ToDouble(aReader[4].ToString());
                  transaction.PaidPrice =  Convert.ToDouble(aReader[5].ToString());
                  transactionlList.Add(transaction);
              }

          }
          connection.Close();
          return transactionlList;

      }
    }
}
