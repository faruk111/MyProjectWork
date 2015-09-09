using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagement.BLL;
using ShopManagement.DLL.DAO;

namespace ShopManagement.UI
{
    public partial class TransactionUI : Form
    {
        TransactionBLL transactionBll=new TransactionBLL();
        public TransactionUI()
        {
            InitializeComponent();
            SeeAll();
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TransactionModel atransaction=new TransactionModel();
            atransaction.Name = nameTextBox.Text;
            atransaction.Date = dateTimePicker.Value;
            atransaction.Quantity = Convert.ToDouble(quantityTextBox.Text);
            atransaction.TotalPrice = Convert.ToDouble(totalPrice.Text);
            atransaction.PaidPrice = Convert.ToDouble(paidPrice.Text);
            string msg = transactionBll.Save(atransaction);
            MessageBox.Show(msg);

            SeeAll();
        }

        private void SeeAll()
        {
            List<TransactionModel> transaction = new List<TransactionModel>();
            transaction = transactionBll.GetAllTransction();
            transactiondataGridView.DataSource = transaction;
        }
    }
}
