using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
    public class DBAccess:IDisposable // Unit Of Work
    {
        private Accounting_DBEntities db = new Accounting_DBEntities();
        private ICustomerRepository _customerRepository;
        private DBFunction<Accounting> _accountingRepository;


        public DBFunction<Accounting> AccountingRepository
        {
            get
            {
                if (_accountingRepository == null)
                    _accountingRepository = new DBFunction<Accounting>(db);

                return _accountingRepository;
            }
        }

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                    _customerRepository = new CustomerRepository(db);

                return _customerRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
