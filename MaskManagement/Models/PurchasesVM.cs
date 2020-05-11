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
        public int PurchaseId { get; set; }
        public string Name { get; set; }

        [Display(Name="Total Quantity")]
        public int TotalQuantity { get; set; }

        [Display(Name = "Purchase Type")]
        public PurchaseType PurchaseType { get; set; }

        [Display(Name = "Total Price")]
        [DisplayFormat(DataFormatString = "{0:n} €")]
        public float TotalPrice { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Selected Masks")]
        public List<PurchasedMasks> Masks { get; set; }

    }


    //TODO: Complete this
    public class PurchaseCreateVM 
    {
        public string Name { get; set; }

        [Display(Name = "Purchase Type")]
        public PurchaseType PurchaseType { get; set; }
       
        [Display(Name = "Selected Masks")]
        public List<PurchasedMasks> SelectedMasks { get; set; }

    }


}
