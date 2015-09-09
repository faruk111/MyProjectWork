using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.UI
{
    public partial class BookUI : Form 
    {
        BookBLL bookBll=new BookBLL();
         BindingList<BookModel> booklist;
         SqlCommandBuilder scb;
         SqlDataAdapter sda;
        private DataTable dt;

        public BookUI()
        {
            InitializeComponent();
            GetValue();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            BookModel book = new BookModel();

            book.Id = Convert.ToInt32(idtextBox.Text);
            book.Title = titletextBox.Text;
            book.SubjectCode = subjectCodetextBox.Text;
            book.Author = authortextBox.Text;
            book.Publisher = publishertextBox.Text;
            book.RackNo = rackNotextBox.Text;
            book.Price = pricetextBox.Text;



            string msg = bookBll.Insert(book);
           

            MessageBox.Show(msg);


          
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            idtextBox.Text = "";
            titletextBox.Text = "";
            subjectCodetextBox.Text = "";
            authortextBox.Text = "";
            publishertextBox.Text = "";
            rackNotextBox.Text = "";
            pricetextBox.Text = "";
           
        }

        public void ShowAll()
        {
            booklist = new BindingList<BookModel>();
            booklist = bookBll.GetAllBook();
            bookRecordsdataGridView.DataSource = booklist;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idShowtextBox.Text);
            bookBll.DeleteRecord(id);
            MessageBox.Show("Deleted");
        }

        private void GetValue()
        {
            dt = new DataTable();
            dt = bookBll.ShowBook();
            bookRecordsdataGridView.DataSource = dt;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

           string  url= @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();

            SqlDataAdapter sda = new SqlDataAdapter(@"select * from book_table", connection);
           scb=new SqlCommandBuilder(sda);
            sda.Update(dt);
            
        }

        private void bookRecordsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bookRecordsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = bookBll.RunQuery();
            DataRow row = dt1.Rows[bookRecordsdataGridView.CurrentRow.Index];
            idShowtextBox.Text = row[0].ToString();
            titleShowtextBox.Text = row[1].ToString();
            codeShowtextBox.Text = row[2].ToString();
            authorShowtextBox.Text = row[3].ToString();
            publisherShowtextBox.Text = row[4].ToString();
            priceShowtextBox.Text = row[6].ToString();
        }
    }
}
