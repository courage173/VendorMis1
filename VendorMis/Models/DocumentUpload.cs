using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VendorMis.Models
{
    public class DocumentUpload
    {
        //table
        public int DocumentUploadId { get; set; }
        public int VendorId { get; set; }
        public string Document { get; set; }
        public string Creator { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
        public virtual Vendor Vendors { get; set; }
    }
}