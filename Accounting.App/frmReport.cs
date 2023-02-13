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
                var result = TypeID != 0
                    ? db.AccountingRepository.GetAll(accounting => accounting.TypeID == TypeID)
                    : db.AccountingRepository.GetAll();
                dgReport.AutoGenerateColumns = false;

                dgReport.Rows.Clear();
                foreach(var accounting in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
                    dgReport.Rows.Add(accounting.AccountingID, customerName, accounting.Amount, accounting.DateTime.ToSolarDate(), accounting.Description);
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
    }
}
