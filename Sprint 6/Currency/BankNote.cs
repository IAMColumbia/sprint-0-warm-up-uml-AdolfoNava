using System;
using System.Collections.Generic;
using System.Text;

namespace Currency
{
    public abstract class BankNote : IBankNote
    {
        public double MonetaryValue { get; set; }
        public string Name { get; set; }

        public string Portait { get; set; }
        public string ReverseMotif { get; set; }

        public virtual string About()
        {
            string strAbout = "Banknote about";
            return strAbout;
        }
    }
}
