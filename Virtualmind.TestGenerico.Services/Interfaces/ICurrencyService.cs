using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Core.Enums;

namespace Virtualmind.TestGenerico.Services.Interfaces
{
    public interface ICurrencyService
    {
        Quote GetQuote(Currencies currencyType);
    }
}
