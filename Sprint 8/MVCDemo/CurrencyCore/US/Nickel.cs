using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    [Serializable]
    public class Nickel : USCoin
    {
        public Nickel(USCoinMintMark MintMark)
        {
            this.MintMark = MintMark;
        }

        public Nickel() : this(USCoinMintMark.D)
        {
            this.Name = "Nickel";
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = .05M;
            this.MintMark = USCoinMintMark.D;
            this.Portait = "Thomas Jefferson";
            this.ReverseMotif = "Monticello";
        }
        public override string About()
        {
            string stringAbout = $"Nickel is from {System.DateTime.Now.Year}. It is worth $0.05. It was made in Denver";
            return "US "+ stringAbout;
        }
    }
}
