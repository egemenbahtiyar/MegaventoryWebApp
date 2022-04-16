using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryWebApp.Models
{
    public class Tax
    {
        public string APIKEY { get; set; }
        public Mvtax mvTax { get; set; }
        public string mvRecordAction { get; set; }
        public string mvInsertUpdateDeleteSourceApplication { get; set; }
    }

    public class Mvtax
    {
        public string TaxName { get; set; }
        public string TaxDescription { get; set; }
        public double TaxValue { get; set; }
    }

}
