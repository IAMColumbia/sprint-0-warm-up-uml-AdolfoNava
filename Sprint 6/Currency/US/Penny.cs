using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    public class Penny : USCoin
    {

        public Penny(USCoinMintMark MintMark)
        {
            this.MintMark = MintMark; 
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = .01;
            this.Portait = "Abraham Lincoln";
            this.ReverseMotif = "Union shield";
        }

        public Penny() 
        {
            this.Name = "Penny";
            this.MintMark = USCoinMintMark.D;
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = .01;
            this.Portait = "Abraham Lincoln";
            this.ReverseMotif = "Union shield";
        }
        public string About()
        {
            string stringAbout = $"Penny is from {System.DateTime.Now.Year}. It is worth ${MonetaryValue}. It was made in Denver";
            return "US " + stringAbout;
        }
    }
}
