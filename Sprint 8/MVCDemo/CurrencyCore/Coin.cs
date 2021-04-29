//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Currency
{
    [Serializable]
    public abstract class Coin : ICoin
    {
        public int Year { get; set; }
        
        public decimal MonetaryValue { get; set; }
        //public decimal  CollectorsValue;
        
        public string Name { get; set; }
        public string Portait { get; set; }
        public string ReverseMotif { get; set; }

        public Coin()
        {
            this.Name = "Coin";
            this.Year = System.DateTime.Now.Year;
            
        }

        protected Coin(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Year = info.GetInt16("Year");
            MonetaryValue = info.GetDecimal("MonetaryValue");
            Portait = info.GetString("Portait"); 
            ReverseMotif = info.GetString("ReverseMotif");
            //info.AddValue("Name", Name);
            //info.AddValue("Year", Year);
            //info.AddValue("MonetaryValue", MonetaryValue);
            //info.AddValue("Portait", Portait);
            //info.AddValue("ReverseMotif", ReverseMotif);
        }

        /// <summary>
        /// Tells infomation about a Coin
        /// </summary>
        /// <returns></returns>
        public virtual string About()
        {
            
            return string.Empty;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Year", Year);
            info.AddValue("MonetaryValue", MonetaryValue);
            info.AddValue("Portait", Portait);
            info.AddValue("ReverseMotif", ReverseMotif);
        }
    }    
}
