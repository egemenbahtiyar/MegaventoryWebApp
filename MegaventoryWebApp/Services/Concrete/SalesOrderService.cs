using MegaventoryWebApp.Models;
using MegaventoryWebApp.Services.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace MegaventoryWebApp.Services.Concrete
{
    public class SalesOrderService : ISalesOrderService
    {
        public void InsertSalesOrder(SalesOrder salesOrder)
        {
            var url = "https://api.megaventory.com/v2017a/SalesOrder/SalesOrderUpdate";
            var responseSalesOrder = new SalesOrder();
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";

            var data = JsonSerializer.Serialize(salesOrder);

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                responseSalesOrder = JsonSerializer.Deserialize<SalesOrder>(result);
            }
            var debug = httpResponse.StatusCode;
        }
    }
}
