using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendorMIS.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Creator { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}