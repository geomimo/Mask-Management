using MaskManagement.Contracts;
using MaskManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Repositories
{
    public class PurchasedMasksRepository : IPurchasedMasksRepository
    {
        private readonly MaskManagementContext _db;

        public PurchasedMasksRepository(MaskManagementContext db)
        {
            _db = db;
        }

        public bool Create(PurchasedMasks entity)
        {
            _db.PurchasedMasks.Add(entity);
            return Save();
        }

        public bool Delete(PurchasedMasks entity)
        {
            _db.PurchasedMasks.Remove(entity);
            return Save();
        }

        public ICollection<PurchasedMasks> FindAll()
        {
            var purchasedMasks = _db.PurchasedMasks.ToList();
            return purchasedMasks;
        }

        public PurchasedMasks FindById(int id)
        {
            PurchasedMasks purchasedMasks = _db.PurchasedMasks.Find(id);
            return purchasedMasks;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(PurchasedMasks entity)
        {
            _db.PurchasedMasks.Update(entity);
            return Save();
        }
    }
}
