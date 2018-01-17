using System;
using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.Registration;
using Unity.WebApi;
using Virtualmind.TestGenerico.Core;
using Virtualmind.TestGenerico.Core.Behaviors;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Core.Enums;
using Virtualmind.TestGenerico.Core.Interface;
using Virtualmind.TestGenerico.Impl.Services;
using Virtualmind.TestGenerico.Services.Factory;
using Virtualmind.TestGenerico.Services.Interfaces;

namespace Virtualmind.TestGenerico
{
    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();

            RegisterBehaviours(container);
            RegisterServices(container);
            RegisterRepositories(container);


        }

        private static void RegisterBehaviours(IUnityContainer container)
        {
            container.RegisterType<IQuotable, DolarQuotable>(Constants.DolarQuotable);
            container.RegisterType<IQuotable, PesoQuotable>(Constants.PesoQuotable);
            container.RegisterType<IQuotable, RealQuotable>(Constants.RealQuotable);
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<ICurrencyService, CurrencyService>();
            container.RegisterType<IStrategyResolver, StrategyResolver>();

            container.RegisterType<ICurrency, Currency>(Currencies.Dolar.ToString(), new InjectionConstructor(new ResolvedParameter<IQuotable>(Constants.DolarQuotable)));
            container.RegisterType<ICurrency, Currency>(Currencies.Peso.ToString(), new InjectionConstructor(new ResolvedParameter<IQuotable>(Constants.PesoQuotable)));
            container.RegisterType<ICurrency, Currency>(Currencies.Real.ToString(), new InjectionConstructor(new ResolvedParameter<IQuotable>(Constants.RealQuotable)));
        }

        private static void RegisterRepositories(IUnityContainer container)
        {

        }
    }
}