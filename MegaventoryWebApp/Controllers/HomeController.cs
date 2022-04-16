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
