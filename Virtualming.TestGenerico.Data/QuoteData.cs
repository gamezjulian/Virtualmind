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
            var result = new QuoteResponse();
            var requestUrl = ConfigurationManager.AppSettings.Get(Constants.QuoteServiceUrl);
            var request = WebRequest.Create(requestUrl);

            request.Method = "GET";
            request.ContentType = "application/json; charset=utf-8";

            var response = request.GetResponse();

            var dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            JavaScriptSerializer javascriptSerializer = new JavaScriptSerializer();
            result = javascriptSerializer.Deserialize<QuoteResponse>(responseFromServer);

            return result;
        }
    }
}
