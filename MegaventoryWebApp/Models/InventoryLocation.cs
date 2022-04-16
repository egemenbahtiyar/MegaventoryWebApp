using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryWebApp.Models
{

    public class InventoryLocation
    {
        public string APIKEY { get; set; }
        public Mvinventorylocation mvInventoryLocation { get; set; }
        public string mvRecordAction { get; set; }
        public string mvInsertUpdateDeleteSourceApplication { get; set; }
    }

    public class Mvinventorylocation
    {
        public string InventoryLocationName { get; set; }
        public string InventoryLocationAbbreviation { get; set; }
        public string InventoryLocationAddress { get; set; }
   
    }

   
}
