using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtualmind.TestGenerico.Core.Interface;

namespace Virtualmind.TestGenerico.Core.Entities
{
    public class Currency : ICurrency
    {
        public IQuotable Quote { get; set; }

        public Currency(IQuotable quote)
        {
            this.Quote = quote;
        }
    }
}
