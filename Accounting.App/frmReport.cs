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
using Accounting.Utility.Convertor;
using Accounting.App.Transactions;
using Accounting.ViewModels.Customers;
using AccoutingModel = Accounting.DataLayer.Context.Accounting;
using System.Linq.Expressions;

namespace Accounting.App
{
    public partial class frmReport : Form
    {
        public int TypeID = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (DBAccess db = new DBAccess())
            {
                List<CustomersListViewModel> customerList = new List<CustomersListViewModel>();
                customerList.Add(new CustomersListViewModel()
                {
                    CustomerID = 0,
                    CustomerName = "انتخاب کنید"
                });

                customerList.AddRange(db.CustomerRepository.GetCustomersName());
                cbCustomer.DataSource = customerList;
                cbCustomer.DisplayMember = "CustomerName";
                cbCustomer.ValueMember = "CustomerID";

            }

            if (TypeID == 0)
                this.Text = "گزارش کلی";
            if (TypeID == 1)
                this.Text = "گزارش دریافتی ها";
            if (TypeID == 2)
                this.Text =  "گزارش پرداختی ها";
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            using (DBAccess db = new DBAccess())
            {
                List<AccoutingModel> accountingList = new List<AccoutingModel>();
                DateTime? startDate;
                DateTime? endDate;                

                int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                Expression<Func<AccoutingModel, bool>> filter;
                if (TypeID != 0)
                {
                    if (customerId != 0)
                        filter = a => a.TypeID == TypeID && a.CustomerID == customerId;
                    else
                        filter = a => a.TypeID == TypeID;
                }
                else
                {
                    if (customerId != 0)
                        filter = a => a.CustomerID == customerId;
                    else
                        filter = null;
                }

                accountingList.AddRange(db.AccountingRepository.GetAll(filter));

                if (txtStartDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(txtStartDate.Text);
                    startDate = DateConversion.ToInternationalDate(startDate.Value);
                    accountingList = accountingList.Where(a => a.DateTime >= startDate.Value).ToList();
                }

                if (txtEndDate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txtEndDate.Text);
                    endDate = DateConversion.ToInternationalDate(endDate.Value);
                    accountingList = accountingList.Where(a => a.DateTime <= endDate.Value).ToList();
                }

                dgReport.AutoGenerateColumns = false;
                dgReport.Rows.Clear();
                foreach(var accounting in accountingList)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
                    dgReport.Rows.Add(accounting.AccountingID, customerName, accounting.Amount, accounting.DateTime.ToSolarDate(), accounting.Description, accounting.TypeID);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                if(RtlMessageBox.Show("آیا از حذف مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (DBAccess db = new DBAccess())
                    {
                        db.AccountingRepository.Delete(id);
                        db.Save();
                        Filter();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                frmNewTransaction newTransction = new frmNewTransaction();
                newTransction.AccountId = id;

                if(newTransction.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");
            dtPrint.Columns.Add("Type");
            foreach (DataGridViewRow item in dgReport.Rows)
            {
                dtPrint.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[5].Value.ToString() == "1" ? "درآمد" : "مخارج"
                    );
            }

            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT", dtPrint);
            stiPrint.Print();
        }
    }
}
