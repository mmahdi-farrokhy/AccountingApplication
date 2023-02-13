using Accounting.App.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers customersForm = new frmCustomers();
            customersForm.ShowDialog();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            frmNewTransaction newTransactionForm = new frmNewTransaction();
            newTransactionForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport reportForm = new frmReport();
            reportForm.TypeID = 2;
            reportForm.ShowDialog();
        }

        private void btnReportIncome_Click(object sender, EventArgs e)
        {
            frmReport reportForm = new frmReport();
            reportForm.TypeID = 1;
            reportForm.ShowDialog();
        }

        private void btnReportAll_Click(object sender, EventArgs e)
        {
            frmReport reportForm = new frmReport();
            reportForm.TypeID = 0;
            reportForm.ShowDialog();
        }
    }
}
