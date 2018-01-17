using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Virtualmind.TestGenerico.Core.Enums;
using Virtualmind.TestGenerico.Models;
using Virtualmind.TestGenerico.Services.Interfaces;

namespace Virtualmind.TestGenerico.Controllers.Api
{
    public class CurrencyController : ApiController
    {
        private ICurrencyService currencyService;

        public CurrencyController(ICurrencyService currencyService)
        {
            this.currencyService = currencyService;
        }

        // GET api/<controller>/<currencyType>
        [HttpGet]
        [Route("api/currency/{currencyType}")]
        public QuoteViewModel Get(Currencies currencyType)
        {
            var quote = this.currencyService.GetQuote(currencyType);

            return new QuoteViewModel
            {
                Buy = quote.Buy,
                Sell = quote.Sell,
                Date = quote.Date
            };
        }
    }
}