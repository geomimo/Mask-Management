using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Data
{
    public class Mask
    {
        [Key]
        public int Id { get; set; }
        public string FabricId { get; set; }
        public string ImagePath { get; set; }

        public string Description { get; set; }
    }
}
