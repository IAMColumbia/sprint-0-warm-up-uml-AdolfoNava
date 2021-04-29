using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Currency.JP
{
    [Serializable]
    public class FiveHundredYen : JPCoin
    {
        public FiveHundredYen(CoinMaterial cm)
        {
            this.Name = "Five Hundred Yen";
            this.Year = System.DateTime.Now.Year;
            this.Coinmaterial = CoinMaterial.Nickel_Brass;
            this.MonetaryValue = 500;
            this.Portait = "Paulownia";
            this.ReverseMotif = "500 Bamboo and Mandarin orange";
            this.Coinmaterial = cm;
        }
        public FiveHundredYen()
        {
            this.Name = "Five Hundred Yen";
            this.Year = System.DateTime.Now.Year;
            this.Coinmaterial = CoinMaterial.Nickel_Brass;
            this.MonetaryValue = 500M;
            this.Portait = "Paulownia";
            this.ReverseMotif = "500 Bamboo and Mandarin orange";
        }
        public override string About()
        {
            string stringAbout = $"five hundred yen coin was made in {System.DateTime.Now.Year}. It is worth ¥{MonetaryValue}. It was made in Hiroshima.";
            return "Japan's " + stringAbout;
        }
        protected FiveHundredYen(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
