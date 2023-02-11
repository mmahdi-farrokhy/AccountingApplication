using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using Accounting.DataLayer;
using ValidationComponents;

namespace Accounting.App.Transactions
{
    public partial class frmNewTransaction : Form
    {
        DBAccess db = new DBAccess();

        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            dgCustomers.AutoGenerateColumns = false;
            dgCustomers.DataSource = db.CustomerRepository.GetCustomersName();
        }

        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgCustomers.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(BaseValidator.IsFormValid(this.components))
            {
                if (rbIncome.Checked || rbOutcome.Checked)
                {
                    DataLayer.Context.Accounting accouting = new DataLayer.Context.Accounting()
                    {
                        Amount = int.Parse(nudAmount.Value.ToString()),
                        CustomerID = db.CustomerRepository.GetCustomerIdByName(txtName.Text),
                        TypeID = rbIncome.Checked ? 1 : 2,
                        DateTime = DateTime.Now,
                        Description = txtDescription.Text
                    };

                    db.AccountingRepository.Insert(accouting);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
            }
        }
    }
}
