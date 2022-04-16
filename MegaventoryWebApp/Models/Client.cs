using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryWebApp.Models
{

    public class Rootobject
    {
        public string APIKEY { get; set; }
        public Mvsupplierclient mvSupplierClient { get; set; }
        public string mvRecordAction { get; set; }
        public string mvGrantPermissionsToAllUsers { get; set; }
        public string mvInsertUpdateDeleteSourceApplication { get; set; }
    }

    public class Mvsupplierclient
    {
        public string SupplierClientName { get; set; }
        public string SupplierClientShippingAddress1 { get; set; }
        public string SupplierClientPhone1 { get; set; }
        public string SupplierClientEmail { get; set; }
        
    }

   
}
