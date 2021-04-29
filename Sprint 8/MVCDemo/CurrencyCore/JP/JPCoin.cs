using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Currency.JP
{
    [Serializable]
    public class JPCoin : Coin
    {
        //Conversion rate .914019 to usd
        public CoinMaterial Coinmaterial { get; set; }
        public JPCoin()
        {

        }
        public JPCoin(CoinMaterial cm)
        {
            this.Coinmaterial = cm;
        }
        public override string About()
        {
            return "Japan";
        }

        public static List<Coin> GetJPCoinList()
        {
            List<Coin> jpcoins = new List<Coin>();
            jpcoins.Add(new OneYen());
            jpcoins.Add(new FiveYen());
            jpcoins.Add(new TenYen());
            jpcoins.Add(new FiftyYen());
            jpcoins.Add(new HundredYen());
            jpcoins.Add(new FiveHundredYen());

            return jpcoins;
        }
        public static string GetNameforCoinMaterial(CoinMaterial cm)
        {
            string CoinMaterialName = "";
            switch (cm)
            {
                case CoinMaterial.Aluminum:
                    CoinMaterialName = "Aluminum";
                    break;
                case CoinMaterial.Bronze:
                    CoinMaterialName = "Bronze";
                    break;
                case CoinMaterial.Brass:
                    CoinMaterialName = "Brass";
                    break;
                case CoinMaterial.Cupronickel:
                    CoinMaterialName = "Cupronickel";
                    break;
                case CoinMaterial.Nickel_Brass:
                    CoinMaterialName = "Nickel-Brass";
                    break;
                default:
                    break;
            }
            return CoinMaterialName;
        }
        public CoinMaterial GetCoinMaterial(CoinMaterial cm)
        {
            return cm;
        }
        protected JPCoin(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
    public enum CoinMaterial
    {
        Aluminum,Brass,Bronze,Cupronickel,Nickel_Brass
    }
}
