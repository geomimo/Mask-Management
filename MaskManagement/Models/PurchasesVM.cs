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
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name="Total Quantity")]
        public int TotalQuantity { get; set; }

        [Display(Name = "Purchase Type")]
        public PurchaseType PurchaseType { get; set; }

        [Display(Name = "Total Price")]
        public float TotalPrice { get; set; }
        public DateTime Date { get; set; }

    }


    //TODO: Complete this
    public class PurchaseCreateVM 
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Purchase Type")]
        public PurchaseType PurchaseType { get; set; }
       
        [Display(Name = "Masks")]
        public ICollection<PurchasedMasks> SelectedMasks { get; set; }

    }


}
