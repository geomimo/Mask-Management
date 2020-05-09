using AutoMapper;
using MaskManagement.Data;
using MaskManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Mappings
{
    public class QuantityResoler : IValueResolver<Purchase, PurchaseDetailsVM, int>
    {
        public int Resolve(Purchase source, PurchaseDetailsVM destination, int destMember, ResolutionContext context)
        {
            int q = 0;
            foreach(PurchasedMasks m in source.Masks)
            {
                q += m.Quantity;
            }

            return q;
        }
    }
}
