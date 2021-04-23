using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    public class HalfDollar : USCoin
    {
        public HalfDollar()
        {
            this.MonetaryValue = .5;
            this.Name = "Half Dollar";
        }
    }
}
