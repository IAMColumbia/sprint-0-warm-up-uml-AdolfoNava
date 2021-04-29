using Currency.US;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Currency
{
    [Serializable]
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }
        protected decimal total;

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
            foreach (Coin c in Coins)
            {
                count++;
            }
            return count;
        }

        public virtual void MakeChange(decimal Amount)
        {
            //while (Amount >= 1.0M)
            //{
            //    Coins.Add(new DollarCoin());
            //    Amount -= 1.0M;
            //}
            //while (Amount >= .50M)
            //{
            //    Coins.Add(new HalfDollar());
            //    Amount -= 0.50M;
            //}
            //while (Amount >= .25M)
            //{
            //    Coins.Add(new Quarter());
            //    Amount -= 0.25M;
            //}
            //while (Amount >= .10M)
            //{
            //    Coins.Add(new Dime());
            //    Amount -= 0.10M;
            //}
            //while (Amount >= .05M)
            //{
            //    Coins.Add(new Nickel());
            //    Amount -= 0.05M;
            //}
            //while (Amount > .00M)
            //{
            //    Coins.Add(new Penny());
            //    Amount -= 0.01M;
            //}
        }

        public ICurrencyRepo MakeChange(decimal AmountTendered, decimal TotalCost)
        {
            throw new NotImplementedException();
        }

        public ICoin RemoveCoin(ICoin c)
        {
            Coins.Remove(c);
            return c;

        }

        public decimal TotalValue()
        {
            total = 0;
            foreach (ICoin c in Coins)
            {
                total += c.MonetaryValue;
            }
            return total;
        }

        public string About()
        {
            return "";
        }

        public virtual ICurrencyRepo CreateChange(decimal Amount)
        {
            CurrencyRepo cr = new CurrencyRepo();
            //switch (Amount)
            //{
            //    case 2.0M:
            //        cr.Coins.Add(new DollarCoin());
            //        cr.Coins.Add(new DollarCoin());
            //        break;
            //    case 1.5M:
            //        cr.Coins.Add(new DollarCoin());
            //        cr.Coins.Add(new HalfDollar());
            //        break;
            //    case .75M:
            //        cr.Coins.Add(new HalfDollar());
            //        cr.Coins.Add(new Quarter());
            //        break;
            //    case .11M:
            //        cr.Coins.Add(new Dime());
            //        cr.Coins.Add(new Penny());
            //        break;
            //    case .06M:
            //        cr.Coins.Add(new Nickel());
            //        cr.Coins.Add(new Penny());
            //        break;
            //    case .04M:
            //        cr.Coins.Add(new Penny());
            //        cr.Coins.Add(new Penny());
            //        cr.Coins.Add(new Penny());
            //        cr.Coins.Add(new Penny());
            //        break;
            //    default:
            //        break;
            //}

            return cr;

        }
        public void ClearChange()
        {
            Coins.Clear();
        }

        public ICurrencyRepo CreateChange(decimal AmountTendered, decimal TotalCost)
        {
            throw new NotImplementedException();
        }


    }
}
