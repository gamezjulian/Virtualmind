using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualmind.TestGenerico.Services.Interfaces
{
    public interface IStrategyResolver
    {
        T Resolve<T>(string name);
    }
}
