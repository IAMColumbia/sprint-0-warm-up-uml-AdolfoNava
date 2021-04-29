using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Currency.JP
{
    [Serializable]
    public class FiveYen : JPCoin
    {
            
        public FiveYen(CoinMaterial cm)
        {
            this.Name = "Five Yen";
            this.Year = System.DateTime.Now.Year;
            this.Coinmaterial = CoinMaterial.Brass;
            this.MonetaryValue = 5;
            this.Portait = "Rice stalk, gear, and water";
            this.ReverseMotif = "Leaf sprout";
            this.Coinmaterial = cm;
        }
        public FiveYen()
        {
            this.Name = "Five Yen";
            this.Year = System.DateTime.Now.Year;
            this.Coinmaterial = CoinMaterial.Brass;
            this.MonetaryValue = 5;
            this.Portait = "Rice stalk, gear, and water";
            this.ReverseMotif = "Leaf sprout";

        }
        public override string About()
        {
            string stringAbout = $"five yen coin was made in {System.DateTime.Now.Year}. It is worth ¥{MonetaryValue}. It was made in Hiroshima.";
            return "Japan's " + stringAbout;
        }
        protected FiveYen(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
    

