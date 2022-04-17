using MegaventoryWebApp.Models;
using MegaventoryWebApp.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;
        private IClientService _clientService;
        private IDiscountService _discountService;
        private IInventoryLocationService _inventoryLocationService;
        private IProductService _productService;
        private ITaxService _taxService;

        public HomeController
            (
            IConfiguration configuration,
            IClientService clientService,
            IDiscountService discountService,
            IInventoryLocationService inventoryLocationService,
            IProductService productService,
            ITaxService taxService
            )
        {
            _configuration = configuration;
            _clientService = clientService;
            _discountService = discountService;
            _inventoryLocationService = inventoryLocationService;
            _productService = productService;
            _taxService = taxService;
           
            
        }

        public IActionResult Index()
        {
            var APIKEY = _configuration["ApiKey:Key"];

            //var mvsupplierclient = new Mvsupplierclient
            //{
            //    SupplierClientEmail = "babis@exampletest.com",
            //    SupplierClientName = "babis",
            //    SupplierClientPhone1 = "1235698967",
            //    SupplierClientShippingAddress1 = "Example 8, Athens "
            //};
            //var client = new Client
            //{
            //    APIKEY = APIKEY,
            //    mvInsertUpdateDeleteSourceApplication = "Magento",
            //    mvSupplierClient = mvsupplierclient,
            //    mvGrantPermissionsToAllUsers = "true",
            //    mvRecordAction = "Insert"
            //};
            //_clientService.InsertClient(client);

            //var mvdiscount = new Mvdiscount { DiscountName = "Loyalty", DiscountDescription = "Loyalty Customer Discount", DiscountValue = 50 };
            //var discount = new Discount { APIKEY = APIKEY, mvDiscount = mvdiscount, mvInsertUpdateDeleteSourceApplication = "WooCommerce", mvRecordAction = "Insert" };
            //_discountService.InsertDiscount(discount);

            //var mvinventorylocation = new Mvinventorylocation { InventoryLocationAbbreviation = "Test", InventoryLocationName = "Test Project Location", InventoryLocationAddress = "Example 20, Athens " };
            //var inventorylocation = new InventoryLocation { APIKEY = APIKEY, mvInventoryLocation = mvinventorylocation, mvInsertUpdateDeleteSourceApplication = "WooCommerce", mvRecordAction = "Insert" };
            //_inventoryLocationService.InsertInventoryLocation(inventorylocation);

            //var mvproduct = new Mvproduct { ProductDescription = "Nike shoes", ProductSKU = "1112256", ProductSellingPrice = 99.99, ProductPurchasePrice = 44.99 };
            //var product = new Product { APIKEY = APIKEY, mvProduct = mvproduct, mvInsertUpdateDeleteSourceApplication = "WooCommerce", mvRecordAction = "Insert" };
            //_productService.InsertProduct(product);

            //var mvtax = new Mvtax { TaxDescription = "VAT GR", TaxName = "VAT", TaxValue = 24 };
            //var tax = new Tax { APIKEY = APIKEY, mvTax = mvtax, mvInsertUpdateDeleteSourceApplication = "Magento", mvRecordAction = "Insert" };
            //_taxService.InsertTax(tax);

            //var supplierClientId = 6;
            //var productID = 25;
            //var inventoryLocationId = 3;
            //var taxId = 2;
            //var DiscountId = 1;







            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
