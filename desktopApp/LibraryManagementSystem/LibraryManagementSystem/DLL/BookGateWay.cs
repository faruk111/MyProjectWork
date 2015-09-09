using System;

using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.DLL
{
   public class BookGateWay
    {
       private SqlConnection connection;
       private string url;

       public string Insert(BookModel book)
       {
           string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
           SqlConnection connection = new SqlConnection(url);

           connection.Open();

           string query = string.Format("insert into book_table values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", book.Id, book.Title, book.SubjectCode, book.Author, book.Publisher, book.RackNo,book.Price);
           SqlCommand command = new SqlCommand(query, connection);


           int affectedrow = command.ExecuteNonQuery();
           if (affectedrow > 0)
               return "successful";
           else
           {
               return "some error";
           }
       }

       public BindingList<BookModel> GetAllBook()
       {
            BindingList<BookModel> booklist = new BindingList<BookModel>();
           url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
           connection = new SqlConnection(url);

           connection.Open();

           string query = "select * from book_table";
           SqlCommand command = new SqlCommand(query, connection);
           SqlDataReader aReader = command.ExecuteReader();

           int count = 1;
           if (aReader.HasRows)
           {
               while (aReader.Read())
               {
                   BookModel bookModel = new BookModel();
                   bookModel.Id = Convert.ToInt32((count++).ToString());
                   bookModel.Title = aReader[1].ToString();
                   bookModel.SubjectCode = aReader[2].ToString();
                   bookModel.Author = aReader[3].ToString();
                   bookModel.Publisher = aReader[4].ToString();
                   bookModel.RackNo = aReader[5].ToString();
                    bookModel.Price = aReader[6].ToString();
                   booklist.Add(bookModel);
               }

           }
           connection.Close();
           return booklist;

       }

      

       public DataTable ShowBook()
       {

           url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
           connection = new SqlConnection(url);

           connection.Open();
            DataTable data=new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from book_table", connection);
           sda.Fill(data);
           return data;
       }

       public DataTable RunQuery()
       {
           url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
           connection = new SqlConnection(url);

           connection.Open();
           DataTable data = new DataTable();
           SqlDataAdapter sda = new SqlDataAdapter(@"select * from book_table", connection);
           sda.Fill(data);
           return data;
       }

       public void DeleteRecord(int id)
       {
           url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
           connection = new SqlConnection(url);

           connection.Open();

           string query = "delete   from book_table where id='"+id+"'";
           SqlCommand command = new SqlCommand(query, connection);
           command.ExecuteNonQuery();

       }
    }
    }

