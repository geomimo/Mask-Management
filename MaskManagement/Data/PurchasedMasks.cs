using System.ComponentModel.DataAnnotations;

namespace MaskManagement.Data
{
    public class PurchasedMasks
    {
        [Key]
        public int PurchasedMasksId { get; set; }
        public Mask Mask { get; set; }
        public int Quantity { get; set; }

    }
}