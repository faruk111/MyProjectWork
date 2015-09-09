using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DLL;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.BLL
{
    
   public class BookBLL
   {
        BookGateWay gateway = new BookGateWay();

       public string Insert(BookModel book)
       {

               return gateway.Insert(book);
 
          
       }

       public BindingList<BookModel> GetAllBook()
       {
           return gateway.GetAllBook();
       }

       
       public DataTable ShowBook()
       {
           return gateway.ShowBook();
       }

       public DataTable RunQuery()
       {
           return gateway.RunQuery();
       }

       public void DeleteRecord(int id)
       {
           gateway.DeleteRecord(id);
       }
   }
}
