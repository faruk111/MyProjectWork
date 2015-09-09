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

namespace LibraryManagementSystem.UI
{
    public partial class SearchUI : Form
    {
        private string idForDelete;
        private SqlCommandBuilder scb;
        private DataTable data;


        public SearchUI()
        {

           
            InitializeComponent();
            AutoComplte();
        }

        private void bookradioButton_CheckedChanged(object sender, EventArgs e)
        {
          string  url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
          SqlConnection  connection = new SqlConnection(url);

            connection.Open();
            data = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from book_table", connection);
            sda.Fill(data);
            searchRecordsdataGridView.DataSource = data;
        }

        private void memberradioButton_CheckedChanged(object sender, EventArgs e)
        {
            string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();
            DataTable data = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from member_table", connection);
            sda.Fill(data);
            searchRecordsdataGridView.DataSource = data;
        }

        private void idradioButton_CheckedChanged(object sender, EventArgs e)
        {
            string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();
            DataTable data = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(@"select id,book_name from book_table", connection);
            sda.Fill(data);
            searchRecordsdataGridView.DataSource = data;
        }

        private void rackradioButton_CheckedChanged(object sender, EventArgs e)
        {
            string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();
            DataTable data = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(@"select id,author_name from book_table", connection);
            sda.Fill(data);
            searchRecordsdataGridView.DataSource = data;
        }

        private void titleradioButton_CheckedChanged(object sender, EventArgs e)
        {
            string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();
            DataTable data = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(@"select book_name from book_table", connection);
            sda.Fill(data);
            searchRecordsdataGridView.DataSource = data;
        }

        private void authorradioButton_CheckedChanged(object sender, EventArgs e)
        {
            string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();
            DataTable data = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(@"select id,author_name from book_table", connection);
            sda.Fill(data);
            searchRecordsdataGridView.DataSource = data;
        }

        private void searchRecordsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         string   url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
          SqlConnection  connection = new SqlConnection(url);

            connection.Open();
            DataTable data = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from book_table", connection);
            sda.Fill(data);
            DataRow row = data.Rows[searchRecordsdataGridView.CurrentRow.Index];
             idForDelete = row[0].ToString();
           
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idForDelete);
          
           
          string  url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
           SqlConnection connection = new SqlConnection(url);

            connection.Open();

            string query = "delete   from book_table where id='" + id + "'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Deleted");

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();
           
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from book_table", connection);
            sda.Fill(data);
           
           scb = new SqlCommandBuilder(sda);
          
           
            sda.Update(data);
            MessageBox.Show("Updated");
            
        }

        void AutoComplte()
        {

          searchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll=new AutoCompleteStringCollection();

          string  url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
          SqlConnection  connection = new SqlConnection(url);

            connection.Open();

            string query = "select * from book_table";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

           
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    string sname = aReader[1].ToString();
                    coll.Add(sname);
                }

            }

            searchTextBox.AutoCompleteCustomSource= coll;
            connection.Close();
          
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();
            DataTable data = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from book_table", connection);
            sda.Fill(data);
            DataView  dv=new DataView(data);
            dv.RowFilter = string.Format("book_name LIKE '%{0}%'", searchTextBox.Text);
            searchRecordsdataGridView.DataSource = dv;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchRecordsdataGridView.DataSource = "";
        }
    }
}
