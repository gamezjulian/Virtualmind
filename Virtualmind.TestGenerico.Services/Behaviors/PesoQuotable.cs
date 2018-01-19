using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Core.Interface;

namespace Virtualmind.TestGenerico.Services.Behaviors
{
    public class PesoQuotable : IQuotable
    {
        public virtual Quote GetQuote()
        {
            throw new HttpException(401, "Unauthorized");
        }
    }
}
