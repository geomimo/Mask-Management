using AutoMapper;
using MaskManagement.Data;
using MaskManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Mappings
{
    public class PurchaseResolver : IValueResolver<Purchase, PurchaseDetailsVM, int>
    {
        public int Resolve(Purchase source, PurchaseDetailsVM destination, int destMember, ResolutionContext context)
        {
            return 0;
        }
    }
}
