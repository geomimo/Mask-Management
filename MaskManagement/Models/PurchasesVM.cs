using MaskManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MaskManagement.Models
{
    public class PurchaseDetailsVM
    {
        public string Name { get; set; }

        [Display(Name="Total Quantity")]
        public int TotalQuantity { get; set; }

        [Display(Name = "Purchase Type")]
        public PurchaseType PurchaseType { get; set; }

        public decimal Price { get; set; }
        public DateTime Date { get; set; }

    }


    //TODO: Complete this
    public class PurchaseCreateVM 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PurchaseType PurchaseType { get; set; }
        public ICollection<PurchasedMasks> SelectedMasks { get; set; }

    }


}
