﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VendorMis.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Creator { get; set; }
         [Display(Name = "Create Date")]
        public DateTime CreatedDate { get; set; }
    }
}