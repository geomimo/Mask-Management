﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Models
{
    public class MaskVM
    {
        public int MaskId { get; set; }

        [Display(Name = "Fabric ID")]
        public string FabricId { get; set; }

        [Display(Name = "Image of Fabric")]
        public IFormFile Image { get; set; }


        [Display(Name = "Image of Fabric")]
        public string ImagePath { get; set; }

        public string Description { get; set; }
    }


}
