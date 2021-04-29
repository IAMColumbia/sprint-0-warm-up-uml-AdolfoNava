using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace SimpleWPF.Model
{
    [Serializable]
    public class Characters : ISerializable
    {
        
        public string Name { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public int Strength { get; set; }
        public int Magic { get; set; }
        public int Endurance { get; set; }
        protected Guid id;

        public Characters()
        {
            this.Name = "Timmy";
            this.Class = "Hunter";
            this.Race = "Human";
            this.Strength = 4;
            this.Magic = 5;
            this.Endurance = 5;
            this.id = new Guid();
        }
        public void IncreaseStrength()
        {
            this.Strength++;
        }
        public void IncreaseMagic()
        {
            this.Magic++;
        }
        public void IncreaseEndurance()
        {
            this.Endurance++;
        }
        public void DecreaseStrength()
        {
            this.Strength--;
        }
        public void DecreaseMagic()
        {
            this.Magic--;
        }
        public void DecreaseEndurance()
        {
            this.Endurance--;
        }
        public string About()
        {
            return $@"Hello my name is {this.Name} and I am a {this.Race} whose class is {this.Class}.
Stats: 
Strength: {this.Strength}
Magic: {this.Magic}
Endurance: {this.Endurance}";
        }
        protected Characters(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Class = info.GetString("Class");
            Race = info.GetString("Race");
            Strength = info.GetInt32("Strength");
            Magic = info.GetInt32("Magic");
            Endurance = info.GetInt32("Endurance");

        }
        public virtual void GetObjectData(SerializationInfo info,
    StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Class", Class);
            info.AddValue("Race", Race);
            info.AddValue("Strength", Strength);
            info.AddValue("Magic", Magic);
            info.AddValue("Endurance", Endurance);
        }
    }
}
