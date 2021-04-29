using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.JP
{
    public class JPCurrencyRepo : CurrencyRepo
    {
        public JPCurrencyRepo()
        {
            this.Coins = new List<ICoin>();
            this.total = 0M;
        }
        public override void MakeChange(decimal Amount)
        {

            while (Amount >= 500)
            {
                Coins.Add(new FiveHundredYen());
                Amount -= 500;
            }
            while (Amount >= 100)
            {
                Coins.Add(new HundredYen());
                Amount -= 100;
            }
            while (Amount >= 25)
            {
                Coins.Add(new FiftyYen());
                Amount -= 50;
            }
            while (Amount >= 10)
            {
                Coins.Add(new TenYen());
                Amount -= 10;
            }
            while (Amount >= 5)
            {
                Coins.Add(new FiveYen());
                Amount -= 5;
            }
            while (Amount > 0)
            {
                Coins.Add(new OneYen());
                Amount -= 1;
            }
        }
        public void USDtoJP(decimal Amount)
        {
            decimal NewAmount;
            NewAmount = Math.Round(Amount * 109.2780M,0);
            while (NewAmount >= 500M)
            {
                Coins.Add(new FiveHundredYen());
                NewAmount -= 500M;
            }
            while (NewAmount >= 100M)
            {
                Coins.Add(new HundredYen());
                NewAmount -= 100M;
            }
            while (NewAmount >= 50M)
            {
                Coins.Add(new FiftyYen());
                NewAmount -= 50M;
            }
            while (NewAmount >= 10M)
            {
                Coins.Add(new TenYen());
                NewAmount -= 10M;
            }
            while (NewAmount >= 5M)
            {
                Coins.Add(new FiveYen());
                NewAmount -= 5M;
            }
            while (NewAmount > 0M)
            {
                Coins.Add(new OneYen());
                NewAmount -= 1M;
            }
        }
    }
}
