using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Core.Interface;
using Virtualmind.TestGenerico.Services.Behaviors;
using Virtualmind.TestGenerico.Services.Interfaces;

namespace Virtualmind.TestGenerico.Tests.Services
{
    [TestClass]
    public class CurrencyServiceTest
    {
        private IQuotable pesoQuotable;
        private IQuotable dolarQuotable;
        private IQuotable realQuotable;
        private IQuoteService quoteService;

        [TestInitialize]
        public void Initialize()
        {
            this.quoteService = A.Fake<IQuoteService>();
            this.pesoQuotable = A.Fake<PesoQuotable>();
            this.dolarQuotable = A.Fake<DolarQuotable>(x => x.WithArgumentsForConstructor(new List<IQuoteService>() { this.quoteService }));
            this.realQuotable = A.Fake<RealQuotable>();
        }

        [TestMethod]
        public void TestPeso()
        {
            Currency peso = new Currency(this.pesoQuotable);
            A.CallTo(() => peso.Quote.GetQuote()).Throws(new HttpException(401, "Unauthorized"));

            Assert.ThrowsException<HttpException>(() => peso.Quote.GetQuote());
        }

        public void TestReal()
        {
            Currency real = new Currency(this.realQuotable);
            A.CallTo(() => real.Quote.GetQuote()).Throws(new HttpException(401, "Unauthorized"));

            Assert.ThrowsException<HttpException>(() => real.Quote.GetQuote());
        }

        [TestMethod]
        public void TestDolar()
        {
            A.CallTo(() => this.quoteService.GetQuote()).Returns(
               new Quote
               {
                   Buy = 2,
                   Sell = 3,
                   Date = "Nothing here"
               });

            var dolarQuotable = new DolarQuotable(this.quoteService);

            Currency dolar = new Currency(dolarQuotable);

            Assert.AreEqual(2, dolar.Quote.GetQuote().Buy);
            Assert.AreEqual(3, dolar.Quote.GetQuote().Sell);
            Assert.AreNotEqual(string.Empty, dolar.Quote.GetQuote().Date);
        }
    }
}
