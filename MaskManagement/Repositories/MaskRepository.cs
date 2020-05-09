using MaskManagement.Contracts;
using MaskManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Repositories
{
    public class MaskRepository : IMaskRepository
    {
        private readonly MaskManagementContext _db;

        public MaskRepository(MaskManagementContext db)
        {
            _db = db;
        }

        public bool Create(Mask entity)
        {
            _db.Masks.Add(entity);
            return Save();
        }

        public bool Delete(Mask entity)
        {
            _db.Masks.Remove(entity);
            return Save();
        }

        public ICollection<Mask> FindAll()
        {
            var masks = _db.Masks.ToList();
            return masks;
        }

        public Mask FindById(int id)
        {
            Mask mask = _db.Masks.Find(id);
            return mask;
        }

        public Mask FindByFabricId(string fabricId)
        {
            Mask mask = _db.Masks.ToList().Where(m => m.FabricId == fabricId).FirstOrDefault();
            return mask;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(Mask entity)
        {
            _db.Masks.Update(entity);
            return Save();
        }
    }
}
