using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Currency.JP
{
    [Serializable]
    public class FiftyYen : JPCoin
    {
        public FiftyYen(CoinMaterial cm)
        {
            this.Name = "Fifty Yen";
            this.Year = System.DateTime.Now.Year;
            this.Coinmaterial = CoinMaterial.Cupronickel;
            this.MonetaryValue = 50;
            this.Portait = "Chrysanthemums";
            this.ReverseMotif = "50";
            this.Coinmaterial = cm;
        }
        public FiftyYen()
        {
            this.Name = "Fifty Yen";
            this.Year = System.DateTime.Now.Year;
            this.Coinmaterial = CoinMaterial.Cupronickel;
            this.MonetaryValue = 50;
            this.Portait = "Chrysanthemums";
            this.ReverseMotif = "50";
        }
        public override string About()
        {
            string stringAbout = $"fifty yen coin was made in {System.DateTime.Now.Year}. It is worth ¥{MonetaryValue}. It was made in Hiroshima.";
            return "Japan's " + stringAbout;
        }
        protected FiftyYen(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
