using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtualming.TestGenerico.Data.Entities;

namespace Virtualming.TestGenerico.Data.Interfaces
{
    public interface IQuoteData
    {
        QuoteResponse GetQuote();
    }
}
