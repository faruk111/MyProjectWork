﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagement.UI;

namespace ShopManagement
{
    public partial class ApplicationUI : Form
    {
        public ApplicationUI()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private static void ShowAll()
        {
            EmployeeUI anEmployee = new EmployeeUI();
            anEmployee.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionUI transaction=new TransactionUI();
            transaction.ShowDialog();
        }
    }
}
