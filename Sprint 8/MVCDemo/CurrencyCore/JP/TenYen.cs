using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Currency.JP
{
    [Serializable]
    public class TenYen : JPCoin
    {
        public TenYen(CoinMaterial cm)
        {
            this.Name = "Ten Yen";
            this.Year = System.DateTime.Now.Year;
            this.Coinmaterial = CoinMaterial.Bronze;
            this.MonetaryValue = 10;
            this.Portait = "Phoenix Hall at the Byōdō-in temple";
            this.ReverseMotif = "Tokiwa (evergreen) tree";
            this.Coinmaterial = cm;
        }
        public TenYen()
        {
            this.Name = "Ten Yen";
            this.Year = System.DateTime.Now.Year;
            this.Coinmaterial = CoinMaterial.Bronze;
            this.MonetaryValue = 10;
            this.Portait = "Phoenix Hall at the Byōdō-in temple";
            this.ReverseMotif = "Tokiwa (evergreen) tree";

        }
        public override string About()
        {
            string stringAbout = $"ten yen coin was made in {System.DateTime.Now.Year}. It is worth ¥{MonetaryValue}. It was made in Hiroshima.";
            return "Japan's " + stringAbout;
        }
        protected TenYen(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
