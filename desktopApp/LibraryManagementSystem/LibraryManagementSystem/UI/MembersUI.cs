using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.UI
{
    public partial class MembersUI : Form
    {

        MemberBLL memberbll=new MemberBLL();
        public MembersUI()
        {
            InitializeComponent();
        }

        private void MembersUI_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MemberModel member = new MemberModel();

            member.Id = Convert.ToInt32(idTextBox.Text);
            member.Name = nameTextBox.Text;
            member.Type = memberTypeTextBox.Text;
            member.EntryDate = Convert.ToDateTime(entryDate.Text);
            member.Address = addressTextBox.Text;
            member.Contact = contactTextBox.Text;
          



            string msg = memberbll.Insert(member);


            MessageBox.Show(msg);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
