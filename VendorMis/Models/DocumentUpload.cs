using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendorMis.Models
{
    public class DocumentUpload
    {
        public int DocumentUploadId { get; set; }
        public int VendorId { get; set; }
        public String Document { get; set; }
        public String Creator { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}