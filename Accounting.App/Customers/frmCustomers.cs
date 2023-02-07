using Accounting.DataLayer.Context;
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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.accounting_DBDataSet.Customers);
            BindGrid();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEditCustomer addOrEditForm = new frmAddOrEditCustomer();
            if (addOrEditForm.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            txtFilter.Text = null;
            BindGrid();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if(dgCustomers.CurrentRow != null)
            {
                using (DBAccess db = new DBAccess())
                {
                    string customerName = dgCustomers.CurrentRow.Cells[1].Value.ToString();

                    if(RtlMessageBox.Show($"آیا از حذف  {customerName} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository.DeleteCustomer(customerId);
                        db.Save();
                        BindGrid();
                    }
                }
                
            }
            else
            {
                RtlMessageBox.Show("لطفا یک سطر را انتخاب کنید");
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                int customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditCustomer addOrEditForm = new frmAddOrEditCustomer();
                addOrEditForm._customerId = customerId;
                if (addOrEditForm.ShowDialog() == DialogResult.OK)
                    BindGrid();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (DBAccess db = new DBAccess())
            {
                dgCustomers.DataSource = db.CustomerRepository.GetCustomersByFilter(txtFilter.Text);
            }
        }

        void BindGrid()
        {
            using (DBAccess db = new DBAccess())
            {
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }
    }
}
