using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Virtualmind.TestGenerico.Core;
using Virtualming.TestGenerico.Data.Entities;
using Virtualming.TestGenerico.Data.Interfaces;

namespace Virtualming.TestGenerico.Data
{
    public class QuoteData : IQuoteData
    {
        public QuoteResponse GetQuote()
        {
            var values = new List<string>();
            var requestUrl = ConfigurationManager.AppSettings.Get(Constants.QuoteServiceUrl);
            var request = WebRequest.Create(requestUrl);
            var result = new QuoteResponse();

            request.Method = "GET";

            var response = request.GetResponse();

            var dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            JavaScriptSerializer javascriptSerializer = new JavaScriptSerializer();
            values = javascriptSerializer.Deserialize<List<string>>(responseFromServer);

            result.Values = values;

            return result;
        }
    }
}
