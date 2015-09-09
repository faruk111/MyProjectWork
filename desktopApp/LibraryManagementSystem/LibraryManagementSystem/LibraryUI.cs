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
using LibraryManagementSystem.Model;
using LibraryManagementSystem.UI;


namespace LibraryManagementSystem
{
    public partial class LibraryUI : Form
    {
        public LibraryUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminVarification a = new adminVarification();

            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MembersUI mui=new MembersUI();
            mui.ShowDialog();
        }

        private void bookBurtton_Click(object sender, EventArgs e)
        {
            BookUI bUI=new BookUI();
            bUI.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchUI sUi=new SearchUI();
            sUi.ShowDialog();
        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            IssueOrAcceptUI ui=new IssueOrAcceptUI();
            ui.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Md.Faruk Hossain\nCSE\nJahangirnagar University");
        }

       
    }
}
