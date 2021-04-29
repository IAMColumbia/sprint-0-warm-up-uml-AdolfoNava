using Currency.US;
//using Microsoft.AspNetCore.Mvc.ViewFeatures;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
//using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Currency
{
    public class SaveableCurrencyRepo : CurrencyRepo, ISerializable
    {
        public List<ICoin> SavableCoins;
        public string savelocation;
        public SaveableCurrencyRepo(ICurrencyRepo cr)
        {
            this.SavableCoins = cr.Coins;
            savelocation = "test.json";
        }
        public void Save()
        {
            //var json = JsonConvert.SerializeObject(SavableCoins);
            //File.WriteAllText(this.savelocation, json);
        }
        public void Load()
        {
            //XmlSerializer xml = new XmlSerializer(typeof(List<Coin>));
            //StringReader sr = new StringReader(File.ReadAllText(savelocation));          
            //    SavableCoins = (List<iCoin>)xml.Deserialize(sr);
            //this.Coins.Clear();
            //foreach(var coin in SavableCoins)
            //{
            //    this.Coins.Add(coin);
            //}

            using (StreamReader file = File.OpenText(savelocation))
            {
               // JsonSerializer js = new JsonSerializer();
                List<USCoin> coin = new List<USCoin>();
                //coin = (List<USCoin>)js.Deserialize(file, typeof(List<USCoin>));
                foreach (Coin item in coin)
                {
                    SavableCoins.Add(item);
                }
                //SavableCoins = JsonConvert.DeserializeObject<List<ICoin>>(File.ReadAllText(savelocation));
                //SavableCoins = (List<ICoin>)js.Deserialize(file, typeof(List<ICoin>));

            }
            
            //var json = JsonConvert.DeserializeObject(savelocation);
            
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
