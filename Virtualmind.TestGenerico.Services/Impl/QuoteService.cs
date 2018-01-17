using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Services.Interfaces;
using Virtualming.TestGenerico.Data.Interfaces;

namespace Virtualmind.TestGenerico.Services.Impl
{
    public class QuoteService : IQuoteService
    {
        private IQuoteData data;

        public QuoteService(IQuoteData data)
        {
            this.data = data;
        }

        public Quote GetQuote()
        {
            var quote = this.data.GetQuote();

            return new Quote
            {
                Buy = quote.Buy,
                Date = quote.Date,
                Sell = quote.Sell
            };
        }
    }
}
