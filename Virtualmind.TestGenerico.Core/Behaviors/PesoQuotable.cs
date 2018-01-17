﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtualmind.TestGenerico.Core.Interface;

namespace Virtualmind.TestGenerico.Core.Behaviors
{
    public class PesoQuotable : IQuotable
    {
        public double GetQuote()
        {
            return 2;
        }
    }
}