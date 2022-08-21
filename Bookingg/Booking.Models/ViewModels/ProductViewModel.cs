﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models.ViewModels
{
    public class ProductViewModel
    {
        public Product product { get; set; }

        // 1st DropDown preparation for projection
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }

        // 2nd DropDown Preparation for Projection
        [ValidateNever]
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
