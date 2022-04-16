using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryWebApp.Models
{

    public class Product
    {
        public string APIKEY { get; set; }
        public Mvproduct mvProduct { get; set; }
        public string mvRecordAction { get; set; }
        public string mvInsertUpdateDeleteSourceApplication { get; set; }
    }

    public class Mvproduct
    {
        public string ProductSKU { get; set; }
        public string ProductDescription { get; set; }
        public double ProductSellingPrice { get; set; }
        public double ProductPurchasePrice { get; set; }
    }



}
