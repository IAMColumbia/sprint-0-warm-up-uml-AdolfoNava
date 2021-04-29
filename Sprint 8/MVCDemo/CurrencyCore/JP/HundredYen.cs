using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Currency.JP
{
    [Serializable]
    public class HundredYen : JPCoin
    {
        public HundredYen(CoinMaterial cm)
        {
            this.Name = "One Hundred Yen";
            this.Year = System.DateTime.Now.Year;
            this.Coinmaterial = CoinMaterial.Cupronickel;
            this.MonetaryValue = 100;
            this.Portait = "Cherry Blossoms";
            this.ReverseMotif = "100";
            this.Coinmaterial = cm;
        }
        public HundredYen()
        {
            this.Name = "One Hundred Yen";
            this.Year = System.DateTime.Now.Year;
            this.Coinmaterial = CoinMaterial.Cupronickel;
            this.MonetaryValue = 100;
            this.Portait = "Cherry Blossoms";
            this.ReverseMotif = "100";
        }
        public override string About()
        {
            string stringAbout = $"hundred yen coin was made in {System.DateTime.Now.Year}. It is worth ¥{MonetaryValue}. It was made in Hiroshima.";
            return "Japan's " + stringAbout;
        }
        protected HundredYen(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
