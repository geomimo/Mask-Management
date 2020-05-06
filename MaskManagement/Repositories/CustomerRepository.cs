using MaskManagement.Contracts;
using MaskManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MaskManagementContext _db;

        public CustomerRepository(MaskManagementContext db)
        {
            _db = db;
        }

        public bool Create(Customer entity)
        {
            _db.Customers.Add(entity);
            return Save();
        }

        public bool Delete(Customer entity)
        {
            _db.Customers.Remove(entity);
            return Save();
        }

        public ICollection<Customer> FindAll()
        {
            var customers = _db.Customers.ToList();
            return customers;
        }

        public Customer FindById(int id)
        {
            Customer customer = _db.Customers.Find(id);
            return customer;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(Customer entity)
        {
            _db.Customers.Update(entity);
            return Save();
        }
    }
}
