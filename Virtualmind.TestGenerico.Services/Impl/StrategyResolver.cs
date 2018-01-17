using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Virtualmind.TestGenerico.Core.Interface;
using Virtualmind.TestGenerico.Services.Interfaces;

namespace Virtualmind.TestGenerico.Services.Factory
{
    public class StrategyResolver : IStrategyResolver
    {
        private IUnityContainer unityContainer;

        public StrategyResolver(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        public T Resolve<T>(string name)
        {
            return this.unityContainer.Resolve<T>(name);
        }
    }
}
