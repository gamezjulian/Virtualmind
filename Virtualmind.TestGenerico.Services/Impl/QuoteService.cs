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

            if (quote != null && quote.Values.Any())
            {
                var buyValue = double.Parse(quote.Values.First());
                var dateValue = quote.Values.Last().ToString();
                var sellValue = double.Parse(quote.Values.ElementAt(1));

                return new Quote
                {
                    Buy = buyValue,
                    Date = dateValue,
                    Sell = sellValue
                };
            }

            throw new Exception("There was an error getting quote value.");
        }
    }
}
