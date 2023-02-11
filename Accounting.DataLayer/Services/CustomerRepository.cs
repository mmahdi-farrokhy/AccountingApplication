using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Context;
using System.Data.Entity;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Accounting_DBEntities db;

        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public IEnumerable<Customers> GetCustomersByFilter(string filter)
        {
            return db.Customers.Where(customer =>
                                        customer.FullName.Contains(filter) ||
                                        customer.Email.Contains(filter) ||
                                        customer.Mobile.Contains(filter))
                                        .ToList();
        }

        public List<CustomersListView> GetCustomersName(string filter = "")
        {
            if (filter == "")
                return db.Customers
                    .Select(customer => new CustomersListView()
                    {
                        CustomerID = customer.CustomerID,
                        CustomerName = customer.FullName
                    }).ToList();

            return db.Customers
                .Where(customer => customer.FullName.Contains(filter))
                .Select(customer => new CustomersListView()
                {
                    CustomerID = customer.CustomerID,
                    CustomerName = customer.FullName
                })
                .ToList();
        }

        public int GetCustomerIdByName(string FullName)
        {
            return db.Customers.First(customer => customer.FullName == FullName).CustomerID;
        }

        public string GetCustomerNameById(int customerId)
        {
            return db.Customers.Find(customerId).FullName;
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                var local = db.Set<Customers>()
                    .Local
                    .FirstOrDefault(f => f.CustomerID == customer.CustomerID);

                if (local != null)
                    db.Entry(local).State = EntityState.Detached;

                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
