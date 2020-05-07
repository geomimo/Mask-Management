using AutoMapper;
using MaskManagement.Data;
using MaskManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Mappings
{
    public class PriceResolver : IValueResolver<Purchase, PurchaseDetailsVM, float>
    {
        public float Resolve(Purchase source, PurchaseDetailsVM destination, float destMember, ResolutionContext context)
        {
            float? price = null;
            switch (source.PurchaseType)
            {
                case PurchaseType.RETAIL:
                    price = TypePrice.Retail;
                    break;
                case PurchaseType.WHOLESALE:
                    price = TypePrice.Wholesale;
                    break;
            }

            if (price == null) throw new NullReferenceException("Null price!");

            return source.Masks.Count * (float)price;
        }
    }
}
