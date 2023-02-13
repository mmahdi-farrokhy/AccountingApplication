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
        private DBAccess db = new DBAccess();
        public int _accountId = 0;

        public int AccountId
        {
            get
            {
                return _accountId;
            }
            set
            {
                _accountId = value;
            }
        }

        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            dgCustomers.AutoGenerateColumns = false;
            dgCustomers.DataSource = db.CustomerRepository.GetCustomersName();

            if(_accountId != 0)
            {
                var account = db.AccountingRepository.GetById(_accountId);
                nudAmount.Text = account.Amount.ToString();
                txtDescription.Text = account.Description;
                txtName.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerID);
                rbIncome.Checked = account.TypeID == 1;
                rbOutcome.Checked = account.TypeID == 2;
            }

            this.Text = "ویرایش";
            btnSave.Text = "ویرایش";
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

                    if(AccountId == 0)
                        db.AccountingRepository.Insert(accouting);
                    else
                    {
                        accouting.AccountingID = AccountId;
                        db.AccountingRepository.Update(accouting);
                    }

                    
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
            }
        }
    }
}
