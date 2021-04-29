using Currency.US;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }
        double total;

        public CurrencyRepo()
        {
            this.Coins = new List<ICoin>();
        }


        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public int GetCoinCount()
        {
            int count = 0;
            foreach(Coin c in Coins)
            {
                count++;
            }
            return count;
        }

        public ICurrencyRepo MakeChange(double Amount)
        {
            CurrencyRepo cr = new CurrencyRepo();
            return cr;
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            throw new NotImplementedException();
        }

        public ICoin RemoveCoin(ICoin c)
        {
            Coins.Remove(c);
            return c;
            
        }

        public double TotalValue()
        {
            total = 0;
            foreach(Coin c in Coins)
            {
                total +=c.MonetaryValue;
            }
            return total;
        }

        public string About()
        {
            return "";
        }

        public ICurrencyRepo CreateChange(double Amount)
        {
            CurrencyRepo cr = new CurrencyRepo();
            switch (Amount)
            {
                case 2.0:
                    cr.Coins.Add(new DollarCoin());
                    cr.Coins.Add(new DollarCoin());
                    break;
                case 1.5:
                    cr.Coins.Add(new DollarCoin());
                    cr.Coins.Add(new HalfDollar());
                    break;
                case .75:
                    cr.Coins.Add(new HalfDollar());
                    cr.Coins.Add(new Quarter());
                    break;
                case .11:
                    cr.Coins.Add(new Dime());
                    cr.Coins.Add(new Penny());
                    break;
                case .06:
                    cr.Coins.Add(new Nickel());
                    cr.Coins.Add(new Penny());
                    break;
                case .04:
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

        public ICurrencyRepo CreateChange(double AmountTendered, double TotalCost)
        {
            throw new NotImplementedException();
        }
    }
}
