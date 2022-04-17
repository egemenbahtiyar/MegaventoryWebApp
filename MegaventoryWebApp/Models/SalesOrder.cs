using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryWebApp.Models
{

    public class SalesOrder
    {
        public string APIKEY { get; set; }
        public Mvsalesorder mvSalesOrder { get; set; }
        public string mvRecordAction { get; set; }
    }

    public class Mvsalesorder
    {
        public int SalesOrderInventoryLocationID { get; set; }
        public int SalesOrderClientId { get; set; }
        public string SalesOrderStatus { get; set; }
        public Salesorderdetail[] SalesOrderDetails { get; set; }
    }

    public class Salesorderdetail
    {
        public string SalesOrderRowProductSKU { get; set; }
        public string SalesOrderRowQuantity { get; set; }
        public int SalesOrderRowTaxID { get; set; }
        public int SalesOrderRowDiscountID { get; set; }
        public int SalesOrderRowProductID { get; set; }
    }



}
