using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Currency.JP
{
    [Serializable]
    public class OneYen : JPCoin
    {
        public OneYen(CoinMaterial cm)
        {
            this.Name = "One Yen";
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = 1;
            this.Portait = "Sapling";
            this.ReverseMotif = "One Yen";
            this.Coinmaterial = cm;
        }
        public OneYen()
        {
            this.Name = "One Yen";
            this.Year = System.DateTime.Now.Year;
            this.Coinmaterial = CoinMaterial.Aluminum;
            this.MonetaryValue = 1;
            this.Portait = "Sapling";
            this.ReverseMotif = "1";
            
        }
        public override string About()
        {
            string stringAbout = $"one yen coin was made in {System.DateTime.Now.Year}. It is worth ¥{MonetaryValue}. It was made in Hiroshima.";
            return "Japan's " + stringAbout;
        }
        protected OneYen(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
