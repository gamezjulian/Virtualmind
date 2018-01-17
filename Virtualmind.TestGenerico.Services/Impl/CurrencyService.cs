using System.Web.Mvc;
using Virtualmind.TestGenerico.Core;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Core.Enums;
using Virtualmind.TestGenerico.Core.Interface;
using Virtualmind.TestGenerico.Services.Interfaces;

namespace Virtualmind.TestGenerico.Impl.Services
{
    public class CurrencyService : ICurrencyService
    {
        private IStrategyResolver resolver;

        public CurrencyService(IStrategyResolver resolver)
        {
            this.resolver = resolver;
        }

        public Quote GetQuote(Currencies currencyType)
        {
            ICurrency currency = null;
            Quote result = new Quote();

            switch (currencyType)
            {
                case Currencies.Dolar:
                    {
                        currency = this.resolver.Resolve<ICurrency>(Currencies.Dolar.ToString());
                        break;
                    }
                case Currencies.Peso:
                    {
                        currency = this.resolver.Resolve<ICurrency>(Currencies.Peso.ToString());
                        break;
                    }
                case Currencies.Real:
                    {
                        currency = this.resolver.Resolve<ICurrency>(Currencies.Real.ToString());
                        break;
                    }
                default:
                    {
                        throw new System.Exception("Not currency available");
                    }
            }

            if (currency != null)
            {
                result = currency.Quote.GetQuote();
            }

            return result;
        }
    }
}
