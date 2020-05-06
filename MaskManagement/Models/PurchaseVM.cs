using MaskManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MaskManagement.Models
{
    public class PurchaseVM
    {
        public string Name { get; set; }

        [Display(Name="Total Quantity")]
        public int TotalQuantity { get; set; }

        public PurchaseType PurchaseType { get; set; }

    }
}
