using MegaventoryWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryWebApp.Services.Abstract
{
    public interface IProductService
    {
        void InsertProduct(Product product);
    }
}
