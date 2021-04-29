using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Currency.US
{
    [Serializable]
    public class Dime : USCoin
    {
        public Dime(USCoinMintMark MintMark)
        {
            this.Year = System.DateTime.Now.Year;
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = .10M;
            this.Portait = "Franklin D. Roosevelt";
            this.ReverseMotif = "torch, oak branch, olive branch";
            this.MintMark = MintMark;
        }

        public Dime() 
        {
            this.Name = "Dime";
            this.Year = System.DateTime.Now.Year;
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = .10M;
            this.Portait = "Franklin D. Roosevelt";
            this.ReverseMotif = "torch, oak branch, olive branch";
        }
        public override string About()
        {
            string stringAbout = $"Dime is from {System.DateTime.Now.Year }. It is worth ${MonetaryValue}. It was made in Denver";
            return "US " + stringAbout;
        }
        protected Dime(SerializationInfo info, StreamingContext context) : base(info, context) { }
        
    }
}
