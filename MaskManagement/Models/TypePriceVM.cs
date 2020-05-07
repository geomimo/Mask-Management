using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Models
{
    public class TypePriceVM
    {
        [Range(0,int.MaxValue)]
        public float Retail { get; set; }

        [Range(0, int.MaxValue)]
        public float Wholesale { get; set; }
    }
}
