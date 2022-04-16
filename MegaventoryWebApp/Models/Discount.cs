using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryWebApp.Models
{

    public class Discount
    {
        public string APIKEY { get; set; }
        public Mvdiscount mvDiscount { get; set; }
        public string mvRecordAction { get; set; }
        public string mvInsertUpdateDeleteSourceApplication { get; set; }
    }

    public class Mvdiscount
    {
        public string DiscountName { get; set; }
        public string DiscountDescription { get; set; }
        public double DiscountValue { get; set; }
    }

}
