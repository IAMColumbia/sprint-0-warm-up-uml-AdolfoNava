using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    public class Dime : USCoin
    {
        public Dime(USCoinMintMark MintMark)
        {
            this.Year = System.DateTime.Now.Year;
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = .10;
            this.Portait = "Franklin D. Roosevelt";
            this.ReverseMotif = "torch, oak branch, olive branch";
            this.MintMark = MintMark;
        }

        public Dime() 
        {
            this.Name = "Dime";
            this.Year = System.DateTime.Now.Year;
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = .10;
            this.Portait = "Franklin D. Roosevelt";
            this.ReverseMotif = "torch, oak branch, olive branch";
        }
        public string About()
        {
            string stringAbout = $"Dime is from { System.DateTime.Now.Year }. It is worth ${ MonetaryValue}. It was made in Denver";
            return "US " + stringAbout;
        }
        
    }
}
