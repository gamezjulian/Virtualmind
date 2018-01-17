using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualmind.TestGenerico.Core.Interface
{
    public interface ICurrency
    {
        IQuotable Quote { get; set; }
    }
}
