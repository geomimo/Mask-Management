using MaskManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Contracts
{
    public interface IMaskRepository : IRepositoryBase<Mask>
    {
        public Mask FindByFabricId(string fabricId);
    }
}
