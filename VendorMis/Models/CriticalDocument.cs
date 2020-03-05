using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendorMis.Models
{
    public class CriticalDocument
    {
        public int CriticalDocumentId { get; set; }
        public int VendorId { get; set; }
        public string Document { get; set; }
        public int  Score { get; set; }
    }
}