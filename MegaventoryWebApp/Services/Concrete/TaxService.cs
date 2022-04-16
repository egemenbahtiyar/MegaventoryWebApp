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
    public class TaxService : ITaxService
    {
        public void InsertTax(Tax tax)
        {
            var url = "https://api.megaventory.com/v2017a/Tax/TaxUpdate";
            var responseTax = new Tax();
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";

            var data = JsonSerializer.Serialize(tax);

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                responseTax = JsonSerializer.Deserialize<Tax>(result);
            }
            var debug = httpResponse.StatusCode;
        }
    }
}
