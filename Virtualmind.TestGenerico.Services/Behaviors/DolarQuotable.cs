using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Core.Interface;
using Virtualmind.TestGenerico.Services.Interfaces;

namespace Virtualmind.TestGenerico.Services.Behaviors
{
    public class DolarQuotable : IQuotable
    {
        private IQuoteService quoteService;

        public DolarQuotable(IQuoteService service)
        {
            this.quoteService = service;
        }

        public virtual Quote GetQuote()
        {
            return this.quoteService.GetQuote();
        }
    }
}
