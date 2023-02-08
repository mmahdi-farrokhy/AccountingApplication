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
using ValidationComponents;
using System.IO;

namespace Accounting.App
{
    public partial class frmAddOrEditCustomer : Form
    {
        private DBAccess db = new DBAccess();
        public int _customerId = 0;
        private const string DEFAULT_MOBILE = "09_________";
        private const string DEFAULT_EMAIL   = "E-Mail";
        private const string DEFAULT_NAME = "نام و نام خانوادگی";
        private const string DEFAULT_ADDRESS = "آدرس خود را وارد کنید.";

        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            SetDefaultValue(txtName, DEFAULT_NAME);
            SetDefaultValue(txtMobile, DEFAULT_MOBILE);
            SetDefaultValue(txtEmail, DEFAULT_EMAIL);
            SetDefaultValue(txtAddress, DEFAULT_ADDRESS);

            if (_customerId != 0)
            {
                this.Text = "ویرایش شخص";
                btnSaveCustomer.Text = "ویرایش";
                var customer = db.CustomerRepository.GetCustomerById(_customerId);
                txtName.Text = customer.FullName;
                txtMobile.Text = customer.Mobile;
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                pboxPhoto.ImageLocation = Application.StartupPath + @"\Images\" + customer.CustomerImage;
            }            
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            if (browse.ShowDialog() == DialogResult.OK)
                pboxPhoto.ImageLocation = browse.FileName;
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pboxPhoto.ImageLocation);
                string imagePath = Application.StartupPath + "/Images/";

                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                pboxPhoto.Image.Save(imagePath + imageName);

                Customers newCustomer = new Customers()
                {
                    FullName = txtName.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    CustomerImage = imageName
                };

                if (_customerId == 0)
                    db.CustomerRepository.InsertCustomer(newCustomer);
                else
                {
                    newCustomer.CustomerID = _customerId;
                    db.CustomerRepository.UpdateCustomer(newCustomer);
                }

                db.Save();
                DialogResult = DialogResult.OK;
            } 
        }        

        private void SetDefaultValue(TextBox field, string defautValue)
        {
            if(_customerId == 0)
                if (field.Text == null || field.Text == string.Empty)
                {
                    field.Text = defautValue;
                    field.ForeColor = Color.LightGray;
                }
        }

        private void ClearName(object sender, MouseEventArgs e)
        {
            SetDefaultValue(txtMobile, DEFAULT_MOBILE);
            SetDefaultValue(txtEmail, DEFAULT_EMAIL);
            SetDefaultValue(txtAddress, DEFAULT_ADDRESS);

            if (_customerId == 0)
                txtName.Clear();
        }
       
        private void ClearMobile(object sender, MouseEventArgs e)
        {
            SetDefaultValue(txtName, DEFAULT_NAME);
            SetDefaultValue(txtEmail, DEFAULT_EMAIL);
            SetDefaultValue(txtAddress, DEFAULT_ADDRESS);

            if (_customerId == 0)
                txtMobile.Clear();
        }

        private void ClearEmail(object sender, MouseEventArgs e)
        {
            SetDefaultValue(txtName, DEFAULT_NAME);
            SetDefaultValue(txtMobile, DEFAULT_MOBILE);
            SetDefaultValue(txtAddress, DEFAULT_ADDRESS);

            if (_customerId == 0)
                txtEmail.Clear();
        }

        private void ClearAddress(object sender, MouseEventArgs e)
        {
            SetDefaultValue(txtName, DEFAULT_NAME);
            SetDefaultValue(txtEmail, DEFAULT_EMAIL);
            SetDefaultValue(txtMobile, DEFAULT_MOBILE);

            if (_customerId == 0)
                txtAddress.Clear();
        }
    }
}
