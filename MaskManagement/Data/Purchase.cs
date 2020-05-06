using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Data
{
    public class Purchase
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public ICollection<PurchasedMasks> Masks { get; set; }
    }
}
