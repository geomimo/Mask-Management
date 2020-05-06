using MaskManagement.Contracts;
using MaskManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Repositories
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly MaskManagementContext _db;

        public PurchaseRepository(MaskManagementContext db)
        {
            _db = db;
        }

        public bool Create(Purchase entity)
        {
            _db.Purchases.Add(entity);
            return Save();
        }

        public bool Delete(Purchase entity)
        {
            _db.Purchases.Remove(entity);
            return Save();
        }

        public ICollection<Purchase> FindAll()
        {
            var purchases = _db.Purchases.ToList();
            return purchases;
        }

        public Purchase FindById(int id)
        {
            Purchase purchase = _db.Purchases.Find(id);
            return purchase;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(Purchase entity)
        {
            _db.Purchases.Update(entity);
            return Save();
        }
    }
}
