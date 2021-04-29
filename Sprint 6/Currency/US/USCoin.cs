using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    public abstract class USCoin : Coin
    {

        public USCoinMintMark MintMark  { get; set; }

        public USCoin()
        {
            
        }

        public USCoin(USCoinMintMark MintMark)
        {
            this.MintMark = MintMark;
        }

        /// <summary>
        /// Tells informatrion about  a US Coin
        /// </summary>
        /// <returns></returns>
        public override string About()
        {
            string strAbout = "";
            
            return "US " + strAbout;
        }

        /// <summary>
        /// Returns the full name of a coind Mint Mark
        /// </summary>
        /// <param name="MintMark"></param>
        /// <returns>Full Mint Namt</returns>
        public static string GetMintNameFromMark(USCoinMintMark MintMark)
        {
            string MintName = "";
            switch (MintMark)
            {
                case USCoinMintMark.P:
                    MintName = "Philadephia";
                    break;
                case USCoinMintMark.D:
                    MintName = "Denver";
                    break;
                case USCoinMintMark.S:
                    MintName = "San Francisco";
                    break;
                case USCoinMintMark.W:
                    MintName = "West Point";
                    break;
            }


            return MintName;
        }

        public static List<Coin> GetUSCoinList()
        {
            List<Coin> uscoins = new List<Coin>();
            uscoins.Add(new DollarCoin());
            uscoins.Add(new HalfDollar());
            uscoins.Add(new Quarter());
            uscoins.Add(new Dime());
            uscoins.Add(new Nickel());
            uscoins.Add(new Penny());
            
            return uscoins;

        }

    }

    public enum USCoinMintMark
    {
        P, D, S, W
    }
}
