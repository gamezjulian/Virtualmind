using System.Web;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Core.Interface;

namespace Virtualmind.TestGenerico.Services.Behaviors
{
    public class RealQuotable : IQuotable
    {
        public Quote GetQuote()
        {
            throw new HttpException(401, "Unauthorized");
        }
    }
}
