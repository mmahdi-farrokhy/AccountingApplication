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
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmLogin : Form
    {
        private bool _isEditable = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        public bool IsEditable
        {
            get
            {
                return _isEditable;
            }
            set
            {
                _isEditable = value;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (DBAccess db = new DBAccess())
                {
                    if(IsEditable)
                    {
                        var login = db.LoginRepository.GetAll().First();
                        login.UserName = txtUserName.Text;
                        login.Password = txtPassword.Text;
                        db.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (db.LoginRepository.GetAll(l => l.UserName == txtUserName.Text && l.Password == txtPassword.Text).Any())
                            DialogResult = DialogResult.OK;
                        else
                            RtlMessageBox.Show("نام کاربری یا رمز عبور اشتباه می باشد.");
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(IsEditable)
            {
                this.Text = "تنظیمات ورود به برنامه";
                btnLogin.Text = "ذخیره تغییرات";
                using (DBAccess db = new DBAccess())
                {
                    var login = db.LoginRepository.GetAll().First();
                    txtUserName.Text = login.UserName;
                    txtPassword.Text = login.Password;
                }
            }
        }
    }
}
