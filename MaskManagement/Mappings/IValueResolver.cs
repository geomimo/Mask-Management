using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Mappings
{
    public interface IValueResolver<in TSource, in TDestination, TDestMember>
    {
        	TDestMember Resolve(TSource source, TDestination destination, TDestMember destMember, ResolutionContext context);
    }
}
