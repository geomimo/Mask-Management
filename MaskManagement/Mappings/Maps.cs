using AutoMapper;
using MaskManagement.Data;
using MaskManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {

            CreateMap<Mask, MaskVM>().ReverseMap();

            //CreateMap<Customer, CustomerVM>().ReverseMap();
            CreateMap<Purchase, PurchaseCreateVM>().ReverseMap();
            CreateMap<Purchase, PurchaseDetailsVM>().ReverseMap();
            //CreateMap<PurchasedMasks, PurchasedMasksVM>().ReverseMap();

            CreateMap<Purchase, PurchaseDetailsVM>().ForMember(dest => dest.TotalPrice, opt => opt.MapFrom<PriceResolver>());
            CreateMap<Purchase, PurchaseDetailsVM>().ForMember(dest => dest.TotalQuantity, opt => opt.MapFrom<QuantityResoler>());

        }
    }
}
