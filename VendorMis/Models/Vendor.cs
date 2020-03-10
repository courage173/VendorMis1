using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VendorMis.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [Display(Name = "Vendor Name")]
        public string VendorName { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Website")]
        public string Website { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [Display(Name = "Contact Person Number")]
        public string ContactPersonNumber { get; set; }
        [Display(Name = "Contact Person Email")]
        public string ContactPersonEmail { get; set; }
        [Display(Name = "Class of Business")]
        public string ClassOfBusiness { get; set; }
        [Display(Name = "CAC Reg Number")]
        public string CACRegNumber { get; set; }
        [Display(Name = "Year of Registration")]
        public string YearOfRegistration { get; set; }
        [Display(Name = "Team no")]
        public int TeamNo { get; set; }
        [Display(Name = "Line of Business")]
        public string LineOfBusiness { get; set; }
        [Display(Name = "Key Strenght")]
        public string keyStrength { get; set; }
        [Display(Name = "Identity Key Weakness")]
        public string IdentifiedKeyWeakeness { get; set; }
        [Display(Name = "Remarks")]
        public string Remarks { get; set; }
        [Display(Name = "Score")]
        public int Score { get; set; }
        [Display(Name = "Creator")]
        public string Creator { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
        public virtual Category Categorys { get; set; }
}
}