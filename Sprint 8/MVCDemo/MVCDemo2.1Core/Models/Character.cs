using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2._1Core.Models
{
    public class Character : IHuman
{
        
        public Character()
        {
            this.Strength = 10;
            this.Name = "Bob";
            this.Magic = 5;
            this.Health = 100;

        }

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Magic { get; set; }
        public int Health { get; set; }

        public string About()
        {
            return $@"Name -> {Name}
stat list:
Strength: {Strength}
Magic: {Magic}
Health: {Health}";
            
        }

        public int Stat(int value)
        {
            return value++;
        }
    }
}
