using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendorMis.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public int CategoryId { get; set; }
        public string VendorName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonNumber { get; set; }
        public string ContactPersonEmail { get; set; }
        public string ClassOfBusiness { get; set; }
        public string CACRegNumber { get; set; }
        public string YearOfRegistration { get; set; }
        public int TeamNo { get; set; }
        public string LineOfBusiness { get; set; }
        public string keyStrength { get; set; }
        public string IdentifiedKeyWeakeness { get; set; }
        public string Remarks { get; set; }
        public int Score { get; set; }
        public virtual Category Categorys { get; set; }
}
}