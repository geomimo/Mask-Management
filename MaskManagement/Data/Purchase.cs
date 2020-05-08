using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Data
{
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public PurchaseType PurchaseType { get; set; }


        [ForeignKey("PurchasedMasksId")]
        public List<PurchasedMasks> Masks { get; set; }

        /*
        [ForeignKey("CustomerId")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }*/
    }
}
