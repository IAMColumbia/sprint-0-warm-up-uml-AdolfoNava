using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    [Serializable]
    public class DollarCoin : USCoin
    {
        public DollarCoin(USCoinMintMark MintMark)
        {
           
        }

        public DollarCoin() 
        {
            this.MonetaryValue = 1;
            this.Name = "Dollar Coin";
        }
    }
}