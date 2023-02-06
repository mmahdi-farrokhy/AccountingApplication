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
        DBAccess db = new DBAccess();

        public frmAddOrEditCustomer()
        {
            InitializeComponent();
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
                string imagePath = Application.StartupPath + "Images/";

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

                db.CustomerRepository.InsertCustomer(newCustomer);
                db.Save();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
