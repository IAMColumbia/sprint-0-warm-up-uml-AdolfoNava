using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.US
{
    public class USCurrencyRepo : CurrencyRepo
    {
        public USCurrencyRepo()
        {
            this.Coins = new List<ICoin>();
            this.total = 0M;
        }
        public override void MakeChange(decimal Amount) 
        {
        
            while (Amount >= 1.0M)
            {
                Coins.Add(new DollarCoin());
                Amount -= 1.0M;
            }
            while (Amount >= .50M)
            {
                Coins.Add(new HalfDollar());
                Amount -= 0.50M;
            }
            while (Amount >= .25M)
            {
                Coins.Add(new Quarter());
                Amount -= 0.25M;
            }
            while (Amount >= .10M)
            {
                Coins.Add(new Dime());
                Amount -= 0.10M;
            }
            while (Amount >= .05M)
            {
                Coins.Add(new Nickel());
                Amount -= 0.05M;
            }
            while (Amount > .00M)
            {
                Coins.Add(new Penny());
                Amount -= 0.01M;
            }
        }
        public void JPtoUSD(decimal Amount)
        {
            decimal NewAmount;
            NewAmount = Math.Round(Amount * 0.009151M,2);
            while (NewAmount >= 1.0M)
            {
                Coins.Add(new DollarCoin());
                NewAmount -= 1.0M;
            }
            while (NewAmount >= .50M)
            {
                Coins.Add(new HalfDollar());
                NewAmount -= 0.50M;
            }
            while (NewAmount >= .25M)
            {
                Coins.Add(new Quarter());
                NewAmount -= 0.25M;
            }
            while (NewAmount >= .10M)
            {
                Coins.Add(new Dime());
                NewAmount -= 0.10M;
            }
            while (NewAmount >= .05M)
            {
                Coins.Add(new Nickel());
                NewAmount -= 0.05M;
            }
            while (NewAmount > .00M)
            {
                Coins.Add(new Penny());
                NewAmount -= 0.01M;
            }
        }
        public override ICurrencyRepo CreateChange(decimal Amount)
        {
            USCurrencyRepo cr = new USCurrencyRepo();
            switch (Amount)
            {
                case 2.0M:
                    cr.Coins.Add(new DollarCoin());
                    cr.Coins.Add(new DollarCoin());
                    break;
                case 1.5M:
                    cr.Coins.Add(new DollarCoin());
                    cr.Coins.Add(new HalfDollar());
                    break;
                case .75M:
                    cr.Coins.Add(new HalfDollar());
                    cr.Coins.Add(new Quarter());
                    break;
                case .11M:
                    cr.Coins.Add(new Dime());
                    cr.Coins.Add(new Penny());
                    break;
                case .06M:
                    cr.Coins.Add(new Nickel());
                    cr.Coins.Add(new Penny());
                    break;
                case .04M:
                    cr.Coins.Add(new Penny());
                    cr.Coins.Add(new Penny());
                    cr.Coins.Add(new Penny());
                    cr.Coins.Add(new Penny());
                    break;
                default:
                    break;
            }

            return cr;

        }
    }
}
