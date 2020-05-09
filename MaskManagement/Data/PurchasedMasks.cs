using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaskManagement.Data
{
    public class PurchasedMasks
    {
        [Key]
        public int PurchasedMasksId { get; set; }
        public Mask Mask { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("PurchaseId")]
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }
    }
}